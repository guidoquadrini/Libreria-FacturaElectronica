Public Class UnitTest
    Private Property controladora As New ctrlFacturaElectronica
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


    End Sub

    Private Sub UnitTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles txtImpTotConc.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim TipoDeComprobante As Integer = CInt(txtTipoDeComprobante.Text)


        Dim PuntoDeVenta As Integer = txtPuntoDeVenta.Text
        Dim Concepto As Integer = txtConcepto.Text
        Dim DocTipo As Integer = txtDocTipo.Text
        Dim DocNro As Long = CLng(txtDocNro.Text)
        Dim Cbte As Long = txtCbte.Text
        'Dim cbtedesde As Long = txtcbtedesde.text
        'Dim CbteHasta As Long = txtCbteHasta.text
        Dim CbteFch As String = txtCbteFch.text
        Dim ImpTotal As Decimal = txtImpTotal.text
        Dim ImpTotConc As Decimal = txtImpTotConc.text
        Dim ImpNeto As Decimal = txtImpNeto.text
        Dim ImpOpEx As Decimal = txtImpOpEx.text
        Dim ImpTrib As Decimal = txtImpTrib.text
        Dim ImpIVA As Decimal = txtImpIVA.text
        Dim FchServDesde As String = txtFchServDesde.text
        Dim FchServHasta As String = txtFchServHasta.text
        Dim FchVtoPago As String = txtFchVtoPago.text
        Dim MonId As String = txtMonId.text
        Dim MonCotiz As Double = txtMonCotiz.text
        Dim NROCEA As String
        Dim dtiva As New DataTable
        dtiva.Columns.Add(New DataColumn("ID"))
        dtiva.Columns.Add(New DataColumn("BASE"))
        dtiva.Columns.Add(New DataColumn("Importe"))
        dtiva.Rows.Add.ItemArray = {5, 100, 21}
        dtiva.Rows.Add.ItemArray = {4, 50, 5.25}

        NROCEA = controladora.ObtenerCAE(TipoDeComprobante, PuntoDeVenta, Concepto, DocTipo, _
                                DocNro, CbteFch, ImpTotal, ImpTotConc, _
                                ImpNeto, ImpOpEx, ImpTrib, ImpIVA, FchServDesde, FchServHasta, _
                                FchVtoPago, MonId, MonCotiz, dtIVA)
        txtCAE.Text = NROCEA
        MsgBox("Ultimo Nro de Comprobante: " & controladora.ObtenerUltimoNumeroDeComprobante(PuntoDeVenta, TipoDeComprobante))
    End Sub

    Private Sub Comrpobante_TextChanged(sender As Object, e As EventArgs) Handles txtCbte.TextChanged

    End Sub

    Private Sub txtFchVtoPago_TextChanged(sender As Object, e As EventArgs) Handles txtFchVtoPago.TextChanged

    End Sub

    Private Sub txtImpTotal_TextChanged(sender As Object, e As EventArgs) Handles txtImpTotal.TextChanged

    End Sub
End Class