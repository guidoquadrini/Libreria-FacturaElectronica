<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnitTest
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtImpIVA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTipoDeComprobante = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPuntoDeVenta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDocTipo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtImpTrib = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtImpOpEx = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtImpNeto = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtImpTotConc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtImpTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCbteFch = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCbte = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDocNro = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtFchServDesde = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtMonCotiz = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtMonId = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtFchVtoPago = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtFchServHasta = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCAE = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 73)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Instanciar Controladora de Autenticacion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtImpIVA
        '
        Me.txtImpIVA.Location = New System.Drawing.Point(476, 117)
        Me.txtImpIVA.Name = "txtImpIVA"
        Me.txtImpIVA.Size = New System.Drawing.Size(122, 20)
        Me.txtImpIVA.TabIndex = 1
        Me.txtImpIVA.Text = "26.25"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(426, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ImpIVA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(150, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tipo de Comprobante:"
        '
        'txtTipoDeComprobante
        '
        Me.txtTipoDeComprobante.Location = New System.Drawing.Point(268, 12)
        Me.txtTipoDeComprobante.Name = "txtTipoDeComprobante"
        Me.txtTipoDeComprobante.Size = New System.Drawing.Size(122, 20)
        Me.txtTipoDeComprobante.TabIndex = 3
        Me.txtTipoDeComprobante.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(178, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Punto de Venta:"
        '
        'txtPuntoDeVenta
        '
        Me.txtPuntoDeVenta.Location = New System.Drawing.Point(268, 39)
        Me.txtPuntoDeVenta.Name = "txtPuntoDeVenta"
        Me.txtPuntoDeVenta.Size = New System.Drawing.Size(122, 20)
        Me.txtPuntoDeVenta.TabIndex = 5
        Me.txtPuntoDeVenta.Text = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(206, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Concepto:"
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(268, 65)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(122, 20)
        Me.txtConcepto.TabIndex = 7
        Me.txtConcepto.Text = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(158, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tipo de Documento:"
        '
        'txtDocTipo
        '
        Me.txtDocTipo.Location = New System.Drawing.Point(268, 91)
        Me.txtDocTipo.Name = "txtDocTipo"
        Me.txtDocTipo.Size = New System.Drawing.Size(122, 20)
        Me.txtDocTipo.TabIndex = 9
        Me.txtDocTipo.Text = "80"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(425, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "ImpTrib:"
        '
        'txtImpTrib
        '
        Me.txtImpTrib.Location = New System.Drawing.Point(476, 91)
        Me.txtImpTrib.Name = "txtImpTrib"
        Me.txtImpTrib.Size = New System.Drawing.Size(122, 20)
        Me.txtImpTrib.TabIndex = 33
        Me.txtImpTrib.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(417, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "ImpOpEx:"
        '
        'txtImpOpEx
        '
        Me.txtImpOpEx.Location = New System.Drawing.Point(476, 65)
        Me.txtImpOpEx.Name = "txtImpOpEx"
        Me.txtImpOpEx.Size = New System.Drawing.Size(122, 20)
        Me.txtImpOpEx.TabIndex = 31
        Me.txtImpOpEx.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(420, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "ImpNeto:"
        '
        'txtImpNeto
        '
        Me.txtImpNeto.Location = New System.Drawing.Point(476, 39)
        Me.txtImpNeto.Name = "txtImpNeto"
        Me.txtImpNeto.Size = New System.Drawing.Size(122, 20)
        Me.txtImpNeto.TabIndex = 29
        Me.txtImpNeto.Text = "150"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(402, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "ImpTotConc:"
        '
        'txtImpTotConc
        '
        Me.txtImpTotConc.Location = New System.Drawing.Point(476, 12)
        Me.txtImpTotConc.Name = "txtImpTotConc"
        Me.txtImpTotConc.Size = New System.Drawing.Size(122, 20)
        Me.txtImpTotConc.TabIndex = 27
        Me.txtImpTotConc.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(190, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Importe Total:"
        '
        'txtImpTotal
        '
        Me.txtImpTotal.Location = New System.Drawing.Point(268, 196)
        Me.txtImpTotal.Name = "txtImpTotal"
        Me.txtImpTotal.Size = New System.Drawing.Size(122, 20)
        Me.txtImpTotal.TabIndex = 41
        Me.txtImpTotal.Text = "176.25"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(139, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Fecha del Comprobante:"
        '
        'txtCbteFch
        '
        Me.txtCbteFch.Location = New System.Drawing.Point(268, 170)
        Me.txtCbteFch.Name = "txtCbteFch"
        Me.txtCbteFch.Size = New System.Drawing.Size(122, 20)
        Me.txtCbteFch.TabIndex = 39
        Me.txtCbteFch.Text = "20150517"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(189, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Comprobante:"
        '
        'txtCbte
        '
        Me.txtCbte.Location = New System.Drawing.Point(268, 144)
        Me.txtCbte.Name = "txtCbte"
        Me.txtCbte.Size = New System.Drawing.Size(122, 20)
        Me.txtCbte.TabIndex = 37
        Me.txtCbte.Text = "1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(142, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Numero de Documento:"
        '
        'txtDocNro
        '
        Me.txtDocNro.Location = New System.Drawing.Point(268, 117)
        Me.txtDocNro.Name = "txtDocNro"
        Me.txtDocNro.Size = New System.Drawing.Size(122, 20)
        Me.txtDocNro.TabIndex = 35
        Me.txtDocNro.Text = "20249875113"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(673, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(127, 13)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "Fecha de Servicio Hasta:"
        '
        'txtFchServDesde
        '
        Me.txtFchServDesde.Location = New System.Drawing.Point(676, 39)
        Me.txtFchServDesde.Name = "txtFchServDesde"
        Me.txtFchServDesde.Size = New System.Drawing.Size(122, 20)
        Me.txtFchServDesde.TabIndex = 51
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(641, 176)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "MonCotiz:"
        '
        'txtMonCotiz
        '
        Me.txtMonCotiz.Location = New System.Drawing.Point(700, 173)
        Me.txtMonCotiz.Name = "txtMonCotiz"
        Me.txtMonCotiz.Size = New System.Drawing.Size(122, 20)
        Me.txtMonCotiz.TabIndex = 49
        Me.txtMonCotiz.Text = "1"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(644, 150)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 13)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "MonId:"
        '
        'txtMonId
        '
        Me.txtMonId.Location = New System.Drawing.Point(700, 147)
        Me.txtMonId.Name = "txtMonId"
        Me.txtMonId.Size = New System.Drawing.Size(122, 20)
        Me.txtMonId.TabIndex = 47
        Me.txtMonId.Text = "PES"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(626, 123)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(69, 13)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "FchVtoPago:"
        '
        'txtFchVtoPago
        '
        Me.txtFchVtoPago.Location = New System.Drawing.Point(700, 120)
        Me.txtFchVtoPago.Name = "txtFchVtoPago"
        Me.txtFchVtoPago.Size = New System.Drawing.Size(122, 20)
        Me.txtFchVtoPago.TabIndex = 45
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(673, 68)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(130, 13)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "Fecha de Servicio Desde:"
        '
        'txtFchServHasta
        '
        Me.txtFchServHasta.Location = New System.Drawing.Point(676, 91)
        Me.txtFchServHasta.Name = "txtFchServHasta"
        Me.txtFchServHasta.Size = New System.Drawing.Size(122, 20)
        Me.txtFchServHasta.TabIndex = 43
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(394, 233)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(171, 28)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "ObtenerCae"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(391, 279)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(31, 13)
        Me.Label19.TabIndex = 55
        Me.Label19.Text = "CAE:"
        '
        'txtCAE
        '
        Me.txtCAE.Location = New System.Drawing.Point(441, 276)
        Me.txtCAE.Name = "txtCAE"
        Me.txtCAE.Size = New System.Drawing.Size(211, 20)
        Me.txtCAE.TabIndex = 54
        '
        'UnitTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 332)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtCAE)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtFchServDesde)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtMonCotiz)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtMonId)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtFchVtoPago)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtFchServHasta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtImpTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCbteFch)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCbte)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDocNro)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtImpTrib)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtImpOpEx)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtImpNeto)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtImpTotConc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDocTipo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtConcepto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPuntoDeVenta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTipoDeComprobante)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtImpIVA)
        Me.Controls.Add(Me.Button1)
        Me.Name = "UnitTest"
        Me.Text = "UnitTest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtImpIVA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTipoDeComprobante As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPuntoDeVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDocTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtImpTrib As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtImpOpEx As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtImpNeto As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtImpTotConc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtImpTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCbteFch As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCbte As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDocNro As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtFchServDesde As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtMonCotiz As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtMonId As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtFchVtoPago As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtFchServHasta As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtCAE As System.Windows.Forms.TextBox
End Class
