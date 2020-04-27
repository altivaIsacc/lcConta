Imports System.ComponentModel
Imports System.Threading
Public Class EstadosFinancieros
    Dim hacer As New BackgroundWorker
    Private Shared dts As New dtsEstadosFinancieros
    Public Shared Function Cargar(EsExtendido As Boolean, EsBalance As Boolean, EsMensual As Boolean, Moneda As Integer, MonedaNombre As String, CantPeriodos As Integer, Mes As Integer, MesNombre As String, Año As Integer, Nivel As Integer) As CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim dtPeriodoConsultar As New DataTable
        Dim cmd As New SqlClient.SqlCommand
        dts = New dtsEstadosFinancieros
        cmd.CommandText = "Select Empresa, Cedula AS Juridica, Tel_01 As Telefono, Tel_01 As Telefono2, Email, Logo As Foto , Dirrecion_Web AS SitioWeb, PersonaJuridica AS NombreJuridico  From configuraciones"
        bdAcceso.Cargar(cmd, dts.configuracion)
        Dim fecha As DateTime
        Dim Filtro As String = ""
        Dim fp2 As DateTime
        Dim fp3 As DateTime
        Dim fp1 As DateTime
        Dim periodo1 As String = ""
        Dim periodo2 As String = ""
        Dim periodo3 As String = ""
        If EsBalance Or Not EsExtendido Then
            If EsMensual Then
                fecha = "01/" & Mes & "/" & Año
                fp1 = fecha
                fp1 = fp1.AddMonths(1)
                fp1 = fp1.AddDays(-1)


                fecha = fecha.AddMonths(-1)
                fp2 = fecha
                fp2 = fp2.AddMonths(1)
                fp2 = fp2.AddDays(-1)

                fecha = fecha.AddMonths(-1)
                fp3 = fecha
                fp3 = fp3.AddMonths(1)
                fp3 = fp3.AddDays(-1)
            Else
                fecha = "01/" & Mes & "/" & Año
                fp1 = fecha
                fp1 = fp1.AddMonths(1)
                fp1 = fp1.AddDays(-1)


                fecha = "01/" & Mes & "/" & (Año - 1)
                fp2 = fecha
                fp2 = fp2.AddMonths(1)
                fp2 = fp2.AddDays(-1)

                fecha = "01/" & Mes & "/" & (Año - 2)
                fp3 = fecha
                fp3 = fp3.AddMonths(1)
                fp3 = fp3.AddDays(-1)
            End If
            cmd.CommandText = consulta(CantPeriodos, Moneda)
            cmd.Parameters.AddWithValue("@fp1", fp1)
            cmd.Parameters.AddWithValue("@fp2", fp2)
            cmd.Parameters.AddWithValue("@fp3", fp3)
            periodo1 = Format(fp1, "MMM") & "/" & fp1.Year
            periodo2 = Format(fp2, "MMM") & "/" & fp2.Year
            periodo3 = Format(fp3, "MMM") & "/" & fp3.Year
            If CantPeriodos = 1 Then
                periodo2 = "" : periodo3 = ""
            End If
            If CantPeriodos = 2 Then
                periodo3 = ""
            End If
            Filtro &= " en " & periodo1 & "" & IIf(periodo2.Equals(""), "", ", " & periodo2) & "" & IIf(periodo2.Equals(""), "", ", " & periodo3)


        ElseIf EsExtendido And EsMensual Then
            Filtro = "Periodo: " & Año

			Dim cd As New SqlClient.SqlCommand
			cd.CommandText = "Select P.*, DATEPART(YEAR,PF.FechaFinal) AS Periodo From Periodo P, PeriodoFiscal PF Where  PF.Id = P.Id_PeriodoFiscal AND P.Anno = @aa and P.Mes <= @mm"
			cd.Parameters.AddWithValue("@aa", Año)
			cd.Parameters.AddWithValue("@mm", Mes)
			bdAcceso.Cargar(cd, dtPeriodoConsultar)
			cmd.CommandText = consulta12M(Moneda, dtPeriodoConsultar.Rows.Count)
			For i As Integer = 0 To dtPeriodoConsultar.Rows.Count - 1
                Dim fD As DateTime = "01/" & dtPeriodoConsultar.Rows(i).Item("Mes") & "/" & dtPeriodoConsultar.Rows(i).Item("Anno")
                Dim fH As DateTime = fD.AddMonths(+1).AddDays(-1)
                cmd.Parameters.AddWithValue("@i" & i + 1, fD)
                cmd.Parameters.AddWithValue("@e" & i + 1, fH)
            Next
            cmd.Parameters.AddWithValue("@IdMoneda", Moneda)
            cmd.Parameters.AddWithValue("@asiento", asiento(Año))
        Else
            Filtro = "Periodo: " & Año & " vs " & (Año - 1)
            cmd.CommandText = consultaComparativo(Moneda)
            Dim i As Date = "01/" & Mes & "/" & Año
            fp1 = i
            Dim e As Date = i
            e = e.AddMonths(1)
            e = e.AddDays(-1)
            cmd.Parameters.AddWithValue("@i1", i)
            cmd.Parameters.AddWithValue("@e1", e)
            i = i.AddYears(-1)
            fp2 = i
            e = i
            e = e.AddMonths(1)
            e = e.AddDays(-1)
            cmd.Parameters.AddWithValue("@i2", i)
            cmd.Parameters.AddWithValue("@e2", e)
            cmd.Parameters.AddWithValue("@IdMoneda", Moneda)
            cmd.Parameters.AddWithValue("@asiento1", asiento(Año))
            cmd.Parameters.AddWithValue("@asiento2", asiento(Año - 1))

        End If
        bdAcceso.Cargar(cmd, dts.Resultados)

        Calculos(dts)

        For Each linea In dts.Resultados
            If linea.Movimientos Then
                SumarPadre(linea, dts, linea.PARENTID)
            End If
        Next
        GenerarSubTotales(Nivel, dts)

        Dim Titulo As String = ""
        Dim TipoReporte As String = ""
        If EsBalance Then
            Titulo = "Balance Situación"
            TipoReporte = "Balance"
        Else
            Titulo = "Estado Resultado"
            TipoReporte = "Estado"
        End If

        If CantPeriodos > 1 Then
            If EsMensual Then
                Titulo &= " Compartivo Mensual"
            Else
                Titulo &= " Comparativo Anual"
            End If
        End If


        If Moneda = 1 Then
            Filtro &= " Colón"
        Else
            Filtro &= " Dolar"
        End If
        Dim rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument

        If EsExtendido Then
            If Not EsMensual Then
                rpt = New rptEstadoResultadoMensual
                rpt.SetDataSource(dts)
                rpt.SetParameterValue("Periodo1", Format(fp1, "MMM") & "/" & fp1.Year)
                rpt.SetParameterValue("Periodo2", Format(fp2, "MMM") & "/" & fp2.Year)
                rpt.SetParameterValue("Periodo3", Format(fp1, "MMM") & "/" & fp1.Year)
                rpt.SetParameterValue("Periodo4", Format(fp2, "MMM") & "/" & fp2.Year)
            Else
                rpt = New rptEstadoResultado
                rpt.SetDataSource(dts)
                For i As Integer = 0 To dtPeriodoConsultar.Rows.Count - 1
                    Dim p As Date = "01/" & dtPeriodoConsultar.Rows(i).Item("Mes") & "/" & dtPeriodoConsultar.Rows(i).Item("Anno")
					rpt.SetParameterValue("Periodo" & (i + 1), p.ToString("MMM/yy"))
					If dtPeriodoConsultar.Rows.Count = (i + 1) Then
						For n As Integer = dtPeriodoConsultar.Rows.Count To 11
							rpt.SetParameterValue("Periodo" & (n + 1), "-")
						Next
					End If
				Next
                rpt.SetParameterValue("Acumulado", "Acum. " & Año)
            End If

        Else
            rpt = New rptBalanceSituacion
            rpt.SetDataSource(dts)
            rpt.SetParameterValue("Periodo1", periodo1)
            rpt.SetParameterValue("Periodo2", periodo2)
            rpt.SetParameterValue("Periodo3", periodo3)
        End If
        rpt.SetParameterValue("Filtros", Filtro)
        rpt.SetParameterValue("Titulo", Titulo)
        rpt.SetParameterValue("Nivel", Nivel)
        rpt.SetParameterValue("TipoReporte", TipoReporte)
        rpt.SetParameterValue("Imprime", usuario)
        Return rpt
    End Function
    Private Shared Sub generarMesesPeriodo(cmd As SqlClient.SqlCommand, Mes As Integer, año As Integer)
        Dim consul As New SqlClient.SqlCommand
        consul.CommandText = "Select * From PeriodoTrabajo WHERE Periodo = '" & Mes & "/" & año & "'"
        Dim dt As New DataTable
        bdAcceso.Cargar(consul, dt)


    End Sub
    Private Shared Sub Calculos(ByRef dts As dtsEstadosFinancieros)

        Dim lista As New List(Of CalculoRenta)
        lista.Add(New CalculoRenta) : lista.Add(New CalculoRenta) : lista.Add(New CalculoRenta) : lista.Add(New CalculoRenta) : lista.Add(New CalculoRenta)
        lista.Add(New CalculoRenta) : lista.Add(New CalculoRenta) : lista.Add(New CalculoRenta) : lista.Add(New CalculoRenta) : lista.Add(New CalculoRenta)
        lista.Add(New CalculoRenta) : lista.Add(New CalculoRenta) : lista.Add(New CalculoRenta) : lista.Add(New CalculoRenta) : lista.Add(New CalculoRenta)
        For Each line As dtsEstadosFinancieros.ResultadosRow In dts.Resultados
            If line.Movimientos Then
                If line.Tipo.Equals("INGRESOS") Then
                    For i As Integer = 0 To 12 - 1
                        If Not line.GastoNoDeducible Then
                            lista(i).Ingresos += IIf(line.Item("SaldoAcumulado" & i + 1) Is DBNull.Value, 0, line.Item("SaldoAcumulado" & i + 1))
                        End If
                        lista(i).IngresosCompletos += IIf(line.Item("SaldoAcumulado" & i + 1) Is DBNull.Value, 0, line.Item("SaldoAcumulado" & i + 1))
                    Next
                End If
                If line.Tipo.Equals("COSTO VENTA") Then
                    For i As Integer = 0 To 12 - 1
                        If Not line.GastoNoDeducible Then
                            lista(i).Costos += IIf(line.Item("SaldoAcumulado" & i + 1) Is DBNull.Value, 0, line.Item("SaldoAcumulado" & i + 1))
                        End If
                        lista(i).CostosCompletos += IIf(line.Item("SaldoAcumulado" & i + 1) Is DBNull.Value, 0, line.Item("SaldoAcumulado" & i + 1))
                    Next

                End If
                If line.Tipo.Equals("GASTOS") Then
                    For i As Integer = 0 To 12 - 1
                        If Not line.GastoNoDeducible Then
                            lista(i).Gastos += IIf(line.Item("SaldoAcumulado" & i + 1) Is DBNull.Value, 0, line.Item("SaldoAcumulado" & i + 1))
                        End If
                        lista(i).GastosCompletos += IIf(line.Item("SaldoAcumulado" & i + 1) Is DBNull.Value, 0, line.Item("SaldoAcumulado" & i + 1))
                    Next

                End If
            End If

        Next

        addItemTotal(dts, "5zzz", "UTILIDAD BRUTA", lista)
        '  addItemTotal(dts, "5zzz", "UTILIDAD BRUTA RENTA", lista)
        addItemTotal(dts, "6zzz", "UTILIDAD NETA ANTES RENTA", lista)
        ' addItemTotal(dts, "6zzz", "UTILIDAD NETA ANTES RENTA", lista)
        addItemTotal(dts, "6zzz", "RENTA", lista)
        addItemTotal(dts, "6zzz", "UTILIDAD NETA DESPUÉS RENTA", lista)
    End Sub
    Private Shared Sub addItemTotal(ByRef dts As dtsEstadosFinancieros, CuentaContable As String, Descripcion As String, saldos As List(Of CalculoRenta))
        Dim linea As dtsEstadosFinancieros.ResultadosRow
		linea = dts.Resultados.NewResultadosRow

		Dim AcumuladoUtilidadNeta As Double = 0
		Dim AcumuladoIngresosCompletos As Double = 0

		With linea
            .CuentaContable = CuentaContable
            .Descripcion = Descripcion
            .Tipo = "SUBTOTAL"
            .Nivel = -10
            .Movimientos = 0
			For i As Integer = 0 To 12 - 1
				If Descripcion.Equals("UTILIDAD BRUTA") Then
					.Item("SaldoAcumulado" & (i + 1)) = saldos(i).UtilidadBrutaCompleta
					.Item("Acumulado") += saldos(i).UtilidadBrutaCompleta
				End If
				If Descripcion.Equals("UTILIDAD BRUTA RENTA") Then
					.Item("SaldoAcumulado" & (i + 1)) = saldos(i).UtilidadBruta
				End If
				If Descripcion.Equals("UTILIDAD NETA COMPLETA") Then
					.Item("SaldoAcumulado" & (i + 1)) = saldos(i).UtilidadNetaCompleta
				End If
				If Descripcion.Equals("UTILIDAD NETA ANTES RENTA") Then
					.Item("SaldoAcumulado" & (i + 1)) = saldos(i).UtilidadNetaCompleta
					.Item("Acumulado") += saldos(i).UtilidadNetaCompleta
				End If
				If Descripcion.Equals("RENTA") Then
					.Item("SaldoAcumulado" & (i + 1)) = saldos(i).Renta30
					AcumuladoUtilidadNeta += saldos(i).UtilidadNetaCompleta
					AcumuladoIngresosCompletos += saldos(i).IngresosCompletos
					If (i = 11) Then
						saldos(i).AcumuladoUtilidadNeta = AcumuladoUtilidadNeta
						saldos(i).AcumuladoIngresosCompletos = AcumuladoIngresosCompletos
						.Item("Acumulado") = saldos(i).Renta
					End If
				End If
				If Descripcion.Equals("UTILIDAD NETA DESPUÉS RENTA") Then
					.Item("SaldoAcumulado" & (i + 1)) = saldos(i).Ganancia30
					AcumuladoUtilidadNeta += saldos(i).UtilidadNetaCompleta
					AcumuladoIngresosCompletos += saldos(i).IngresosCompletos
					If (i = 11) Then
						saldos(i).AcumuladoUtilidadNeta = AcumuladoUtilidadNeta
						saldos(i).AcumuladoIngresosCompletos = AcumuladoIngresosCompletos
						.Item("Acumulado") += saldos(i).Ganancia
					End If
				End If
			Next

			.PARENTID = 0
        End With
        dts.Resultados.AddResultadosRow(linea)
    End Sub
	Private Shared Sub addItemSubTotal(ByRef dts As dtsEstadosFinancieros, CuentaContable As String, Descripcion As String, Nivel As Integer,
									   Saldo1 As Double, Saldo2 As Double, Saldo3 As Double,
									Optional Saldo4 As Double = 0, Optional Saldo5 As Double = 0, Optional Saldo6 As Double = 0,
									Optional Saldo7 As Double = 0, Optional Saldo8 As Double = 0, Optional Saldo9 As Double = 0,
									Optional Saldo10 As Double = 0, Optional Saldo11 As Double = 0, Optional Saldo12 As Double = 0,
									Optional Acumulado As Double = 0)
		Dim linea As dtsEstadosFinancieros.ResultadosRow
		linea = dts.Resultados.NewResultadosRow
		With linea
			.CuentaContable = CuentaContable
			.Descripcion = Descripcion
			.Tipo = "SUBTOTAL"
			.Nivel = Nivel
			.Movimientos = 0
			.PARENTID = 0
			.SaldoAcumulado1 = Saldo1
			.SaldoAcumulado2 = Saldo2
			.SaldoAcumulado3 = Saldo3
			.SaldoAcumulado4 = Saldo4
			.SaldoAcumulado5 = Saldo5
			.SaldoAcumulado6 = Saldo6
			.SaldoAcumulado7 = Saldo7
			.SaldoAcumulado8 = Saldo8
			.SaldoAcumulado9 = Saldo9
			.SaldoAcumulado10 = Saldo10
			.SaldoAcumulado11 = Saldo11
			.SaldoAcumulado12 = Saldo12
			.Acumulado = Acumulado

		End With
		dts.Resultados.AddResultadosRow(linea)
	End Sub
	Private Shared Sub GenerarSubTotales(Nivel As Integer, ByRef dts As dtsEstadosFinancieros)
        Dim rdts As dtsEstadosFinancieros
        rdts = dts.Copy()
        For Each line As dtsEstadosFinancieros.ResultadosRow In rdts.Resultados
            If Not line.Movimientos And (line.Nivel - Nivel) = -2 Then
                Dim cuenta As String = ""
                For Each hija As dtsEstadosFinancieros.ResultadosRow In rdts.Resultados
                    If line.id = hija.PARENTID Then
                        If cuenta < hija.CuentaContable Then
                            cuenta = hija.CuentaContable
                        End If
                    End If
                Next
				addItemSubTotal(dts, cuenta & "zA", "TOTAL " & line.Descripcion, line.Nivel,
								line.SaldoAcumulado1, line.SaldoAcumulado2, line.SaldoAcumulado3,
								line.SaldoAcumulado4, line.SaldoAcumulado5, line.SaldoAcumulado6,
								line.SaldoAcumulado7, line.SaldoAcumulado8, line.SaldoAcumulado9,
								line.SaldoAcumulado10, line.SaldoAcumulado11, line.SaldoAcumulado12, line.Acumulado)
			End If
            If Not line.Movimientos And line.Nivel = 0 Then
                Dim cuenta As String = ""
                For Each hija As dtsEstadosFinancieros.ResultadosRow In rdts.Resultados
                    If line.id = hija.PARENTID Then
                        If cuenta < hija.CuentaContable Then
                            cuenta = hija.CuentaContable
                        End If
                    End If
                Next
                cuenta = cuenta.Replace("00", "zB")
				addItemSubTotal(dts, cuenta, "TOTAL " & line.Descripcion, line.Nivel,
								line.SaldoAcumulado1, line.SaldoAcumulado2, line.SaldoAcumulado3,
								line.SaldoAcumulado4, line.SaldoAcumulado5, line.SaldoAcumulado6,
								line.SaldoAcumulado7, line.SaldoAcumulado8, line.SaldoAcumulado9,
								line.SaldoAcumulado10, line.SaldoAcumulado11, line.SaldoAcumulado12, line.Acumulado)
			End If
        Next
    End Sub

    Private Shared Function consulta(cantPeriodos As Integer, idMoneda As Integer) As String
        Dim saldo As String = ""
        If idMoneda = 1 Then
            saldo = "dbo.SaldoColon"
        Else

            saldo = "dbo.SaldoDolar"

        End If

        If cantPeriodos = 3 Then
            Return "Select CuentaContable, Descripcion, '' AS Notas, " & saldo & "(CuentaContable.CuentaContable,@fp1) as SaldoAcumulado1, " & saldo & "(CuentaContable,@fp2) As SaldoAcumulado2, " & saldo & "(CuentaContable,@fp3) as SaldoAcumulado3, Nivel, Movimiento As Movimientos, PARENTID, id, Tipo, GastoNoDeducible, 0 AS SaldoAcumulado4, 0 AS SaldoAcumulado5, 0 AS SaldoAcumulado6, 0 AS SaldoAcumulado7, 0 AS SaldoAcumulado8, 0 AS SaldoAcumulado9, 0 AS SaldoAcumulado10, 0 AS SaldoAcumulado11, 0 AS SaldoAcumulado12, 0 AS Acumulado From CuentaContable WHERE Inactivo = 0"
        End If
        If cantPeriodos = 2 Then
            Return "Select CuentaContable, Descripcion, '' AS Notas,  " & saldo & "(CuentaContable.CuentaContable,@fp1) as SaldoAcumulado1, " & saldo & "(CuentaContable,@fp2) As SaldoAcumulado2, 0 as SaldoAcumulado3, Nivel, Movimiento As Movimientos, PARENTID, id, Tipo, GastoNoDeducible, 0 AS SaldoAcumulado4, 0 AS SaldoAcumulado5, 0 AS SaldoAcumulado6, 0 AS SaldoAcumulado7, 0 AS SaldoAcumulado8, 0 AS SaldoAcumulado9, 0 AS SaldoAcumulado10, 0 AS SaldoAcumulado11, 0 AS SaldoAcumulado12, 0 AS Acumulado  From CuentaContable WHERE Inactivo = 0"
        End If
        If cantPeriodos = 1 Then
            Return "Select CuentaContable, Descripcion, '' AS Notas,  " & saldo & "(CuentaContable.CuentaContable,@fp1) as SaldoAcumulado1, 0 As SaldoAcumulado2, 0 as SaldoAcumulado3, Nivel, Movimiento As Movimientos, PARENTID, id, Tipo, GastoNoDeducible,0 AS SaldoAcumulado4, 0 AS SaldoAcumulado5, 0 AS SaldoAcumulado6, 0 AS SaldoAcumulado7, 0 AS SaldoAcumulado8, 0 AS SaldoAcumulado9, 0 AS SaldoAcumulado10, 0 AS SaldoAcumulado11, 0 AS SaldoAcumulado12, 0 AS Acumulado  From CuentaContable WHERE Inactivo = 0"
        End If
        Return ""
    End Function
    Private Shared Function asiento(año As Integer)
        Dim cd As New SqlClient.SqlCommand
		cd.CommandText = "Select PF.* From PeriodoFiscal PF Where   @aa between Year(PF.FechaInicio) and Year(PF.FechaFinal)"
		cd.Parameters.AddWithValue("@aa", año)
        Dim dt As New DataTable
        bdAcceso.Cargar(cd, dt)
        If dt.Rows.Count > 0 Then
            cd.CommandText = "Select NumAsiento From AsientosContables Where NumAsiento LIKE 'CAN-%' AND dbo.DATEONLY(Fecha) >= @F1 AND dbo.DATEONLY(Fecha) <= @F2"
            cd.Parameters.AddWithValue("@F1", dt.Rows(0).Item("FechaInicio"))
            cd.Parameters.AddWithValue("@F2", dt.Rows(0).Item("FechaFinal"))
            bdAcceso.Cargar(cd, dt)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item("NumAsiento")
            End If
        End If
        Return ""
    End Function
	Private Shared Function consulta12M(idMoneda As Integer, cantMeses As Integer) As String
		Dim saldo As String = ""
		Dim saldoAcumulado As String = ""
		Dim sql As String = ""
		Dim i As Integer = 1

		If idMoneda = 1 Then
			saldo = "dbo.SaldoMesColon"
			saldoAcumulado = "dbo.Saldo"
		Else

			saldo = "dbo.SaldoMesDolar"
			saldoAcumulado = "dbo.Saldo"

		End If

		sql = "Select c.CuentaContable, Descripcion, '' AS Notas, "

		For i = 1 To cantMeses
			sql += saldo & "(@i" & i & ",@e" & i & ", c.CuentaContable) as SaldoAcumulado" & i & ","
		Next

		sql += saldoAcumulado & "(c.CuentaContable,@e" & i - 1 & ", @IdMoneda,@asiento) AS Acumulado,"

		sql += "Nivel, Movimiento As Movimientos, PARENTID, id, Tipo, GastoNoDeducible From CuentaContable c WHERE Inactivo = 0"

		Return sql
	End Function
	Private Shared Function consultaComparativo(idMoneda As Integer) As String
        Dim saldo As String = ""
        Dim saldoAcumulado As String = ""
        If idMoneda = 1 Then
            saldo = "dbo.SaldoMesColon"
            saldoAcumulado = "dbo.Saldo"
        Else

            saldo = "dbo.SaldoMesDolar"
            saldoAcumulado = "dbo.Saldo"

        End If

        Return "Select c.CuentaContable, Descripcion, '' AS Notas, Nivel, Movimiento As Movimientos, PARENTID, id, Tipo, GastoNoDeducible " &
            ", " & saldo & "(@i1,@e1, c.CuentaContable) as SaldoAcumulado1,  " & saldo & "(@i2,@e2, c.CuentaContable) as SaldoAcumulado2, " & saldoAcumulado & "(c.CuentaContable,@e1, @IdMoneda,@asiento1) AS SaldoAcumulado3,  " & saldoAcumulado & "(c.CuentaContable,@e2, @IdMoneda,@asiento2) AS SaldoAcumulado4, 0 AS SaldoAcumulado5, 0 AS SaldoAcumulado6, 0 AS SaldoAcumulado7, 0 AS SaldoAcumulado8, 0 AS SaldoAcumulado9, 0 AS SaldoAcumulado10, 0 AS SaldoAcumulado11, 0 AS SaldoAcumulado12, 0 AS Acumulado From CuentaContable c WHERE Inactivo = 0"

    End Function
    Private Shared Function Relleno(text As String) As String
        Dim tama As Integer = text.Length
        Dim re As String = ""
        For i As Integer = 1 To (21 - tama)
            re &= "_"
        Next
        Return re

    End Function
    Public Shared Sub SumarPadre(linea As dtsEstadosFinancieros.ResultadosRow, ByRef dts As dtsEstadosFinancieros, idPadre As Integer)
		If idPadre = 0 Then
			Exit Sub
		End If
		If linea.IsSaldoAcumulado1Null Then linea.SaldoAcumulado1 = 0
		If linea.IsSaldoAcumulado2Null Then linea.SaldoAcumulado2 = 0
		If linea.IsSaldoAcumulado3Null Then linea.SaldoAcumulado3 = 0
		If linea.IsSaldoAcumulado4Null Then linea.SaldoAcumulado4 = 0
		If linea.IsSaldoAcumulado5Null Then linea.SaldoAcumulado5 = 0
		If linea.IsSaldoAcumulado6Null Then linea.SaldoAcumulado6 = 0
		If linea.IsSaldoAcumulado7Null Then linea.SaldoAcumulado7 = 0
		If linea.IsSaldoAcumulado8Null Then linea.SaldoAcumulado8 = 0
		If linea.IsSaldoAcumulado9Null Then linea.SaldoAcumulado9 = 0
		If linea.IsSaldoAcumulado10Null Then linea.SaldoAcumulado10 = 0
		If linea.IsSaldoAcumulado11Null Then linea.SaldoAcumulado11 = 0
		If linea.IsSaldoAcumulado12Null Then linea.SaldoAcumulado12 = 0
		If linea.IsAcumuladoNull Then linea.Acumulado = 0


		For Each padre In dts.Resultados
			If padre.id = idPadre Then

				If padre.IsSaldoAcumulado1Null Then padre.SaldoAcumulado1 = 0
				If padre.IsSaldoAcumulado2Null Then padre.SaldoAcumulado2 = 0
				If padre.IsSaldoAcumulado3Null Then padre.SaldoAcumulado3 = 0
				If padre.IsSaldoAcumulado4Null Then padre.SaldoAcumulado4 = 0
				If padre.IsSaldoAcumulado5Null Then padre.SaldoAcumulado5 = 0
				If padre.IsSaldoAcumulado6Null Then padre.SaldoAcumulado6 = 0
				If padre.IsSaldoAcumulado7Null Then padre.SaldoAcumulado7 = 0
				If padre.IsSaldoAcumulado8Null Then padre.SaldoAcumulado8 = 0
				If padre.IsSaldoAcumulado9Null Then padre.SaldoAcumulado9 = 0
				If padre.IsSaldoAcumulado10Null Then padre.SaldoAcumulado10 = 0
				If padre.IsSaldoAcumulado11Null Then padre.SaldoAcumulado11 = 0
				If padre.IsSaldoAcumulado12Null Then padre.SaldoAcumulado12 = 0
				If padre.IsAcumuladoNull Then padre.Acumulado = 0

				padre.SaldoAcumulado1 += linea.SaldoAcumulado1
				padre.SaldoAcumulado2 += linea.SaldoAcumulado2
				padre.SaldoAcumulado3 += linea.SaldoAcumulado3
				padre.SaldoAcumulado4 += linea.SaldoAcumulado4
				padre.SaldoAcumulado5 += linea.SaldoAcumulado5
				padre.SaldoAcumulado6 += linea.SaldoAcumulado6
				padre.SaldoAcumulado7 += linea.SaldoAcumulado7
				padre.SaldoAcumulado8 += linea.SaldoAcumulado8
				padre.SaldoAcumulado9 += linea.SaldoAcumulado9
				padre.SaldoAcumulado10 += linea.SaldoAcumulado10
				padre.SaldoAcumulado11 += linea.SaldoAcumulado11
				padre.SaldoAcumulado12 += linea.SaldoAcumulado12
				padre.Acumulado += linea.Acumulado
				SumarPadre(linea, dts, padre.PARENTID)
			End If
		Next
    End Sub
    Public Shared usuario As String = ""
    Public Shared Sub Abrir(Mdi As System.Windows.Forms.Form, _usuario As String)
        Dim dts As New dtsEstadosFinancieros
        usuario = _usuario
        Dim cmd As New SqlClient.SqlCommand

        cmd.CommandText = "Select *  From Moneda Where CodMoneda = 1 Or CodMoneda = 2"
        bdAcceso.Cargar(cmd, dts.Moneda)


        Dim frm As New frmResultado(dts)
        frm.MdiParent = Mdi
        frm.WindowState = Windows.Forms.FormWindowState.Normal
        frm.Show()
    End Sub
    Public Shared Sub TestAbrir(Mdi As System.Windows.Forms.Form, _usuario As String)
        Dim dts As New dtsEstadosFinancieros
        usuario = _usuario
        Dim cmd As New SqlClient.SqlCommand

        cmd.CommandText = "Select *  From Moneda Where CodMoneda = 1 Or CodMoneda = 2"
        bdAcceso.Cargar(cmd, dts.Moneda)


        Dim frm As New frmResultado(dts)
        frm.MdiParent = Mdi
        frm.rbEstadoResultadoMensual.Checked = True
        frm.cbMoneda.SelectedValue = 2
        frm.nuAño.Value = 2019
        frm.WindowState = Windows.Forms.FormWindowState.Normal
        frm.WindowState = Windows.Forms.FormWindowState.Maximized
        frm.Show()
    End Sub

End Class
Public Class CalculoRenta
    Public Ingresos As Double = 0
    Public Gastos As Double = 0
    Public Costos As Double = 0

    Public IngresosCompletos As Double = 0
    Public CostosCompletos As Double = 0
	Public GastosCompletos As Double = 0

	Public AcumuladoUtilidadNeta As Double = 0
	Public AcumuladoIngresosCompletos As Double = 0

	Function UtilidadBrutaCompleta() As Double
        Return IngresosCompletos - GastosCompletos

    End Function
    Function UtilidadBruta() As Double
        Return Ingresos - Gastos

    End Function
    Function UtilidadNetaCompleta() As Double
        Return IngresosCompletos - GastosCompletos - CostosCompletos

    End Function
	Function UtilidadNetaMensual() As Double
		Return Ingresos - Gastos - Costos
	End Function
	Function UtilidadNetaTotal() As Double
		Return AcumuladoUtilidadNeta
	End Function
	Function PorcentajeRenta()
		Return auxCalculos.PorcentajeRenta(AcumuladoIngresosCompletos, UtilidadNetaTotal)
	End Function
	Function Renta()
		If UtilidadNetaTotal() > 0 Then
			Return UtilidadNetaTotal() * (PorcentajeRenta() / 100)
		End If
		Return 0
	End Function
	Function Renta30()
		If UtilidadNetaMensual() > 0 Then
			Return UtilidadNetaMensual() * (30 / 100)
		End If
		Return 0
	End Function
	Function Ganancia30()
		Return UtilidadNetaMensual() - Renta30()

	End Function
	Function Ganancia()
		Return UtilidadNetaTotal() - Renta()

	End Function
End Class

