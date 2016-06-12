Friend Class ctrlAutenticacion
    Public Property Ticket As New WSAA.LoginTicket
    Private Property ClienteWSAA As New WSAA.ProgramaPrincipal
    Private Shared _instancia As ctrlAutenticacion
    Private Shared ReadOnly _Sync As New Object

    Public Sub Autenticar()
        Ticket = ClienteWSAA.CargarTicketDeAcceso
    End Sub
    Private Sub New()
        Try
            Autenticar()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Sub
    Public Shared ReadOnly Property ObtenerInstancia() As ctrlAutenticacion
        Get
            If _instancia Is Nothing Then
                SyncLock _Sync
                    If _instancia Is Nothing Then
                        _instancia = New ctrlAutenticacion
                    End If
                End SyncLock
            End If
            Return _instancia
        End Get
    End Property
    Public Sub CargarTicketDeAcceso()
        Ticket = ClienteWSAA.CargarTicketDeAcceso()
    End Sub

End Class
