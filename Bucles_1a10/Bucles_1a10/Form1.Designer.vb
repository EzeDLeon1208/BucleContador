<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VI = New System.Windows.Forms.TextBox()
        Me.VF = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.F = New System.Windows.Forms.TextBox()
        Me.D_W = New System.Windows.Forms.TextBox()
        Me.D_U = New System.Windows.Forms.TextBox()
        Me.L_W = New System.Windows.Forms.TextBox()
        Me.L_U = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Inc = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor Inicial:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor Final:"
        '
        'VI
        '
        Me.VI.Location = New System.Drawing.Point(166, 28)
        Me.VI.Name = "VI"
        Me.VI.Size = New System.Drawing.Size(28, 20)
        Me.VI.TabIndex = 3
        '
        'VF
        '
        Me.VF.Location = New System.Drawing.Point(166, 73)
        Me.VF.Name = "VF"
        Me.VF.Size = New System.Drawing.Size(28, 20)
        Me.VF.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "For"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(93, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Do-While"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(189, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 18)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Do-Until"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(285, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 18)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Loop-While"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(403, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 18)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Loop-Until"
        '
        'F
        '
        Me.F.Location = New System.Drawing.Point(29, 200)
        Me.F.Multiline = True
        Me.F.Name = "F"
        Me.F.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.F.Size = New System.Drawing.Size(50, 142)
        Me.F.TabIndex = 11
        '
        'D_W
        '
        Me.D_W.Location = New System.Drawing.Point(119, 200)
        Me.D_W.Multiline = True
        Me.D_W.Name = "D_W"
        Me.D_W.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.D_W.Size = New System.Drawing.Size(41, 142)
        Me.D_W.TabIndex = 12
        '
        'D_U
        '
        Me.D_U.Location = New System.Drawing.Point(207, 200)
        Me.D_U.Multiline = True
        Me.D_U.Name = "D_U"
        Me.D_U.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.D_U.Size = New System.Drawing.Size(36, 142)
        Me.D_U.TabIndex = 13
        '
        'L_W
        '
        Me.L_W.Location = New System.Drawing.Point(310, 200)
        Me.L_W.Multiline = True
        Me.L_W.Name = "L_W"
        Me.L_W.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.L_W.Size = New System.Drawing.Size(42, 142)
        Me.L_W.TabIndex = 14
        '
        'L_U
        '
        Me.L_U.Location = New System.Drawing.Point(427, 200)
        Me.L_U.Multiline = True
        Me.L_U.Name = "L_U"
        Me.L_U.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.L_U.Size = New System.Drawing.Size(42, 142)
        Me.L_U.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(207, 369)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 46)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Mostrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 23)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Incremento:"
        '
        'Inc
        '
        Me.Inc.Location = New System.Drawing.Point(166, 118)
        Me.Inc.Name = "Inc"
        Me.Inc.Size = New System.Drawing.Size(28, 20)
        Me.Inc.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 436)
        Me.Controls.Add(Me.Inc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.L_U)
        Me.Controls.Add(Me.L_W)
        Me.Controls.Add(Me.D_U)
        Me.Controls.Add(Me.D_W)
        Me.Controls.Add(Me.F)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.VF)
        Me.Controls.Add(Me.VI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Bucles 1 al 10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents VI As TextBox
    Friend WithEvents VF As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents F As TextBox
    Friend WithEvents D_W As TextBox
    Friend WithEvents D_U As TextBox
    Friend WithEvents L_W As TextBox
    Friend WithEvents L_U As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Inc As TextBox
End Class
