<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvVagas = New System.Windows.Forms.DataGridView()
        Me.cbAndar = New System.Windows.Forms.ComboBox()
        Me.cbVaga = New System.Windows.Forms.ComboBox()
        Me.btnOcupar = New System.Windows.Forms.Button()
        Me.btnLiberar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnCarregar = New System.Windows.Forms.Button()
        CType(Me.dgvVagas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(236, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gerenciador de Estacionamento"
        '
        'dgvVagas
        '
        Me.dgvVagas.AllowDrop = True
        Me.dgvVagas.AllowUserToOrderColumns = True
        Me.dgvVagas.ColumnHeadersHeight = 30
        Me.dgvVagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVagas.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvVagas.GridColor = System.Drawing.SystemColors.GrayText
        Me.dgvVagas.Location = New System.Drawing.Point(12, 86)
        Me.dgvVagas.Name = "dgvVagas"
        Me.dgvVagas.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgvVagas.Size = New System.Drawing.Size(752, 107)
        Me.dgvVagas.TabIndex = 1
        '
        'cbAndar
        '
        Me.cbAndar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAndar.FormattingEnabled = True
        Me.cbAndar.Location = New System.Drawing.Point(106, 225)
        Me.cbAndar.Name = "cbAndar"
        Me.cbAndar.Size = New System.Drawing.Size(167, 28)
        Me.cbAndar.TabIndex = 2
        '
        'cbVaga
        '
        Me.cbVaga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVaga.FormattingEnabled = True
        Me.cbVaga.Location = New System.Drawing.Point(106, 274)
        Me.cbVaga.Name = "cbVaga"
        Me.cbVaga.Size = New System.Drawing.Size(167, 28)
        Me.cbVaga.TabIndex = 3
        '
        'btnOcupar
        '
        Me.btnOcupar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOcupar.Location = New System.Drawing.Point(313, 217)
        Me.btnOcupar.Name = "btnOcupar"
        Me.btnOcupar.Size = New System.Drawing.Size(192, 37)
        Me.btnOcupar.TabIndex = 4
        Me.btnOcupar.Text = "Registrar Ocupada"
        Me.btnOcupar.UseVisualStyleBackColor = True
        '
        'btnLiberar
        '
        Me.btnLiberar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLiberar.Location = New System.Drawing.Point(313, 267)
        Me.btnLiberar.Name = "btnLiberar"
        Me.btnLiberar.Size = New System.Drawing.Size(192, 37)
        Me.btnLiberar.TabIndex = 5
        Me.btnLiberar.Text = "Registrar Liberada"
        Me.btnLiberar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.Location = New System.Drawing.Point(515, 219)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(120, 37)
        Me.btnSalvar.TabIndex = 6
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnCarregar
        '
        Me.btnCarregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCarregar.Location = New System.Drawing.Point(515, 269)
        Me.btnCarregar.Name = "btnCarregar"
        Me.btnCarregar.Size = New System.Drawing.Size(120, 37)
        Me.btnCarregar.TabIndex = 7
        Me.btnCarregar.Text = "Carregar"
        Me.btnCarregar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 326)
        Me.Controls.Add(Me.btnCarregar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnLiberar)
        Me.Controls.Add(Me.btnOcupar)
        Me.Controls.Add(Me.cbVaga)
        Me.Controls.Add(Me.cbAndar)
        Me.Controls.Add(Me.dgvVagas)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvVagas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbAndar As ComboBox
    Friend WithEvents cbVaga As ComboBox
    Friend WithEvents btnOcupar As Button
    Friend WithEvents btnLiberar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnCarregar As Button
    Friend WithEvents dgvVagas As DataGridView
End Class
