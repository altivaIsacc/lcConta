Imports System.Collections.Generic

Public Class AjusteEcole
    Shared listaCuentas As New List(Of AjusteCuentaContable)
    Shared Sub CuentaAjustar()
        listaCuentas.Clear()
        listaCuentas.Add(New AjusteCuentaContable("1-01-02-01-01", 2104532.23, 3834671.6)) 'Cuenta Nacional Colones
        listaCuentas.Add(New AjusteCuentaContable("1-01-02-01-02", 430868667.98, -1603587.31)) 'Cuenta nacional Dolares
        listaCuentas.Add(New AjusteCuentaContable("1-01-02-01-03", 698801.82, 1697.24, True)) 'Cuenta Nacional Euros
        listaCuentas.Add(New AjusteCuentaContable("1-01-02-02-01", 5191988.03, 4391229.0)) 'BAC SJ Colones
        listaCuentas.Add(New AjusteCuentaContable("1-01-02-02-02", 2335054.77, 472.29)) 'BAC SJ Dolares
        listaCuentas.Add(New AjusteCuentaContable("1-01-02-06-01", 1915741.54, 5092.4)) 'Scotiaban Dolares


        listaCuentas.Add(New AjusteCuentaContable("2-01-01-01-00", 1501543835.0, 2773594.3)) 'CXP
        listaCuentas.Add(New AjusteCuentaContable("1-01-03-01-00", 313661988.31, -202670206.61)) 'CXC Internacional
        listaCuentas.Add(New AjusteCuentaContable("1-01-03-02-00", 5736027.24, 15174.01)) 'CXC Local


    End Sub
    Public Shared Sub AjustarCuenta(ByRef dts As DsBalances, FInicio As DateTime, monedaBalance As Integer, reporte As Integer)
        Dim INICIOAJUSTE As DateTime = "02/01/2020"

        If FInicio > INICIOAJUSTE Then
            CuentaAjustar()
            For Each tipo As AjusteCuentaContable In listaCuentas

                For Each linea As DsBalances.CuentaContableRow In dts.CuentaContable
                    If tipo.Cuenta.Equals(linea.CuentaContable) Then
                        If reporte = 1 Then
                            If Not tipo.EsEuro Then
                                linea.SaldoAnterior = tipo.MontoColon - linea.SaldoAnterior
                                If Not linea.IsSaldoAnteriorDNull Then
                                    linea.SaldoAnteriorD = tipo.MontoDolar - linea.SaldoAnteriorD
                                End If
                            End If

                        Else
                            If tipo.EsEuro Then
                                If monedaBalance = 3 Then
                                    linea.SaldoAnterior = tipo.MontoDolar - linea.SaldoAnterior

                                End If

                            Else
                                If monedaBalance = 1 Then
                                    linea.SaldoAnterior = tipo.MontoColon - linea.SaldoAnterior
                                Else
                                    linea.SaldoAnterior = tipo.MontoDolar - linea.SaldoAnterior
                                End If

                            End If


                        End If



                    End If
                Next
            Next
        End If


    End Sub
End Class
Public Class AjusteCuentaContable
    Public Sub New(Cu As String, MoCRC As Double, MoDol As Double, Optional EsE As Boolean = False)
        Cuenta = Cu
        MontoColon = MoCRC
        MontoDolar = MoDol
        EsEuro = EsE

    End Sub
    Public Cuenta As String = ""
    Public MontoDolar As Double = 0
    Public MontoColon As Double = 0
    Public EsEuro As Boolean = False

End Class
