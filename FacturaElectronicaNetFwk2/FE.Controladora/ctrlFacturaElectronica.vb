Imports LibGenerales

Public Class ctrlFacturaElectronica
    Public Property Eventos As List(Of KeyValuePair(Of Integer, String))
    Public Property Errores As List(Of KeyValuePair(Of Integer, String))
    Public Property Observaciones As New List(Of KeyValuePair(Of Integer, String))
    Public Property FechaCAE As String
    Private Property Autenticacion As ctrlAutenticacion
    Private Property WSFE As WSFE.WSFE
    Private Property CUIT As String = RegEdit.ObtenerRegistro(LibGenerales.eCategorias.FacturaElectronica, "CUIT")

    Public Sub New()
        Try
            Autenticacion = ctrlAutenticacion.ObtenerInstancia
            WSFE = New WSFE.WSFE(Autenticacion.Ticket.Token, Autenticacion.Ticket.Sign, CUIT)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Sub

    Public Function ObtenerCAE(ByVal TipoDeComprobante As Integer, ByVal PuntoDeVenta As Integer, ByVal Concepto As Integer,
                                   ByVal DocTipo As Integer, ByVal DocNro As Long,
                                   ByVal CbteFch As String,
                                   ByVal ImpTotal As Double, ByVal ImpTotConc As Double, ByVal ImpNeto As Double,
                                   ByVal ImpOpEx As Double, ByVal ImpTrib As Double, ByVal ImpIVA As Double,
                                   ByVal FchServDesde As String, ByVal FchServHasta As String,
                                   ByVal FchVtoPago As String, ByVal MonId As String, ByVal MonCotiz As Double,
                                   ByVal ArrayIVA As DataTable) As String
        Try
            FechaCAE = ""
            Dim Cabecera As New WSFE.wsfev1.FECAECabRequest
            With Cabecera
                .CantReg = 1
                .CbteTipo = TipoDeComprobante
                .PtoVta = PuntoDeVenta
            End With
            Dim Detalle(0) As WSFE.wsfev1.FECAEDetRequest
            Dim Comprobante As New WSFE.wsfev1.FECAEDetRequest
            With Comprobante
                .CbteFch = CbteFch
                .CbteDesde = ObtenerUltimoNumeroDeComprobante(PuntoDeVenta, TipoDeComprobante) + 1
                .CbteHasta = .CbteDesde
                .CbtesAsoc = Nothing
                .Concepto = Concepto
                .DocNro = DocNro
                .DocTipo = DocTipo
                .FchServDesde = IIf(Concepto = 1, String.Empty, .CbteFch)
                .FchServHasta = IIf(Concepto = 1, String.Empty, .CbteFch)
                .FchVtoPago = IIf(Concepto = 1, String.Empty, .CbteFch)
                .ImpIVA = ImpIVA
                .ImpNeto = ImpNeto
                .ImpOpEx = ImpOpEx
                .ImpTotal = ImpTotal
                .ImpTotConc = ImpTotConc
                .ImpTrib = ImpTrib
                '.Iva = Nothing
                .MonCotiz = MonCotiz
                .MonId = MonId
                .Opcionales = Nothing
                .Tributos = Nothing
                If Cabecera.CbteTipo = 11 Or Cabecera.CbteTipo = 12 Or Cabecera.CbteTipo = 13 Then

                Else
                    Dim IvaArreglo(ArrayIVA.Rows.Count - 1) As WSFE.wsfev1.AlicIva
                    For i = 0 To ArrayIVA.Rows.Count - 1
                        Dim Ivas As New WSFE.wsfev1.AlicIva
                        Ivas.Id = ArrayIVA.Rows(i).Item(0)
                        Ivas.BaseImp = ArrayIVA.Rows(i).Item(1)
                        Ivas.Importe = ArrayIVA.Rows(i).Item(2)
                        IvaArreglo(i) = Ivas
                        .Iva = IvaArreglo
                    Next
                End If

            End With
            Detalle(0) = Comprobante
            Dim Pedido As New WSFE.wsfev1.FECAERequest
            Pedido.FeCabReq = Cabecera
            Pedido.FeDetReq = Detalle

            Dim Respuesta As New WSFE.wsfev1.FECAEResponse()
            Autenticacion.CargarTicketDeAcceso()
            Respuesta = WSFE.FECAESolicitar(Pedido)
            If Respuesta IsNot Nothing Then
                If WSFE.Observaciones.Count > 0 Then
                    Observaciones.AddRange(WSFE.Observaciones)
                    For Each obs As KeyValuePair(Of Integer, String) In WSFE.Observaciones
                        MsgBox("Se informan la siguientes observacines, (" & CStr(obs.Key) & ")" & obs.Value, MsgBoxStyle.Information, "Observaciones de la transaccion")
                    Next
                End If
                FechaCAE = Respuesta.FeDetResp(0).CAEFchVto
                Return Respuesta.FeDetResp(0).CAE
            End If
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

    Public Function ObtenerUltimoNumeroDeComprobante(ByVal PuntoDeVenta As Integer, ByVal TipoComprobante As Integer) As Long
        Dim Respuesta As WSFE.wsfev1.FERecuperaLastCbteResponse
        ' Invoco al método FECompUltimoAutorizado
        Try
            Autenticacion.CargarTicketDeAcceso()
            Respuesta = WSFE.FECompUltimoAutorizado(PuntoDeVenta, TipoComprobante)
            If Respuesta IsNot Nothing Then
                If Respuesta.Errors Is Nothing And Respuesta.Events Is Nothing Then Return Respuesta.CbteNro
            End If
            RegistrarErroresEventos(Respuesta)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
        Return Nothing
    End Function

    Private Sub RegistrarErroresEventos(Respuesta As Object)
        Errores = New List(Of KeyValuePair(Of Integer, String))
        Eventos = New List(Of KeyValuePair(Of Integer, String))
        Observaciones = New List(Of KeyValuePair(Of Integer, String))
        Errores.AddRange(WSFE.Errores)
        Eventos.AddRange(WSFE.Eventos)
    End Sub

    Public Shared Function ObtenerAppConfig() As DataTable
        Dim vRet As New DataTable
        vRet.Columns.Add("Clave")
        vRet.Columns.Add("Valor")
        vRet.Rows.Add({"CUIT", RegEdit.ObtenerRegistro(eCategorias.FacturaElectronica, "CUIT")})
        Return vRet
    End Function

End Class

