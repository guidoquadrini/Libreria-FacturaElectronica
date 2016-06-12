Public Class ctrlFacturaElectronica
    Public Property Eventos As List(Of KeyValuePair(Of Integer, String))
    Public Property Errores As List(Of KeyValuePair(Of Integer, String))
    Private Property Autenticacion As ctrlAutenticacion
    Private Property WSFE As WSFE.WSFE

    Public Sub New()
        Try
            Autenticacion = ctrlAutenticacion.ObtenerInstancia
            WSFE = New WSFE.WSFE(Autenticacion.Ticket.Token, Autenticacion.Ticket.Sign, My.Settings.CUIT)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Sub

    Public Function ObtenerCAE(ByVal TipoDeComprobante As Integer, ByVal PuntoDeVenta As String, ByVal Concepto As Integer, _
                                   ByVal DocTipo As Integer, ByVal DocNro As Long, _
                                   ByVal CbteFch As String, _
                                   ByVal ImpTotal As Double, ByVal ImpTotConc As Double, ByVal ImpNeto As Double, _
                                   ByVal ImpOpEx As Double, ByVal ImpTrib As Double, ByVal ImpIVA As Double, _
                                   ByVal FchServDesde As String, ByVal FchServHasta As String, _
                                   ByVal FchVtoPago As String, ByVal MonId As String, ByVal MonCotiz As Double _
                                   ) As String
        Try
            Dim Cbte As Long = WSFE.FECompUltimoAutorizado(PuntoDeVenta, TipoDeComprobante).CbteNro + 1
            Dim Respuesta As New WSFE.wsfev1.FECAEResponse()
            Autenticacion.CargarTicketDeAcceso()
            Respuesta = WSFE.FECAESolicitar(TipoDeComprobante, PuntoDeVenta, Concepto, DocTipo, DocNro, Cbte, CbteFch, ImpTotal, ImpTotConc, ImpNeto, ImpOpEx, ImpTrib, ImpIVA, FchServDesde, FchServHasta, FchVtoPago, MonId, MonCotiz)
            If Respuesta IsNot Nothing Then Return Respuesta.FeDetResp(0).CAE
            RegistrarErroresEventos(Respuesta)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
        Return Nothing
    End Function
    Public Function ObtenerCAE(ByVal TipoDeComprobante As String, ByVal PuntoDeVenta As String, ByVal Detalle As DataTable) As Integer
        Dim CantidadDeRegistro As Integer = Detalle.Rows.Count
        Try
            'TODO: Declar una variable del tipo correcto tomar el CAE y devolverlo.
            Dim Respuesta As New WSFE.wsfev1.FECAEResponse()
            Autenticacion.CargarTicketDeAcceso()
            Respuesta = WSFE.FECAESolicitar(CantidadDeRegistro, TipoDeComprobante, PuntoDeVenta, Detalle)
            If Respuesta IsNot Nothing Then Return Respuesta.FeDetResp(0).CAE
            RegistrarErroresEventos(Respuesta)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
        Return Nothing
    End Function
    Public Function ObtenerUltimoNumeroDeComprobante(ByVal PuntoDeVenta As String, ByVal TipoComprobante As String) As Long
        Dim PtoVta As Long = Trim(PuntoDeVenta).Substring(0, 2)
        Dim CbteTipo As Long = Trim(TipoComprobante).Substring(0, 2)
        Dim Respuesta As WSFE.wsfev1.FERecuperaLastCbteResponse
        ' Invoco al método FECompUltimoAutorizado
        Try
            Autenticacion.CargarTicketDeAcceso()
            Respuesta = WSFE.FECompUltimoAutorizado(PtoVta, CbteTipo)
            If Respuesta IsNot Nothing Then Return Respuesta.CbteNro
            Errores.AddRange(Respuesta.Errors)
            Errores.AddRange(Respuesta.Events)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
        Return Nothing
    End Function
    Private Sub RegistrarErroresEventos(Respuesta As Global.WSFE.wsfev1.FECAEResponse)
        Errores = New List(Of KeyValuePair(Of Integer, String))
        Eventos = New List(Of KeyValuePair(Of Integer, String))
        Errores.AddRange(WSFE.Errores)
        Eventos.AddRange(WSFE.Eventos)
    End Sub

    Function ObtenerCAE(p1 As String, p2 As Integer, p3 As Integer) As Object
        Throw New NotImplementedException
    End Function

End Class
