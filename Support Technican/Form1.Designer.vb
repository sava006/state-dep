<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTechName = New System.Windows.Forms.TextBox()
        Me.txtTechEmail = New System.Windows.Forms.TextBox()
        Me.grdTechnicians = New System.Windows.Forms.DataGridView()
        Me.btnAddTech = New System.Windows.Forms.Button()
        Me.btnEditTech = New System.Windows.Forms.Button()
        Me.btnEmailTech = New System.Windows.Forms.Button()
        Me.cboTechRole = New System.Windows.Forms.ComboBox()
        CType(Me.grdTechnicians, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Role"
        '
        'txtTechName
        '
        Me.txtTechName.Location = New System.Drawing.Point(59, 25)
        Me.txtTechName.Name = "txtTechName"
        Me.txtTechName.Size = New System.Drawing.Size(121, 20)
        Me.txtTechName.TabIndex = 3
        '
        'txtTechEmail
        '
        Me.txtTechEmail.Location = New System.Drawing.Point(59, 61)
        Me.txtTechEmail.Name = "txtTechEmail"
        Me.txtTechEmail.Size = New System.Drawing.Size(121, 20)
        Me.txtTechEmail.TabIndex = 4
        '
        'grdTechnicians
        '
        Me.grdTechnicians.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTechnicians.Location = New System.Drawing.Point(197, 25)
        Me.grdTechnicians.Name = "grdTechnicians"
        Me.grdTechnicians.Size = New System.Drawing.Size(240, 150)
        Me.grdTechnicians.TabIndex = 6
        '
        'btnAddTech
        '
        Me.btnAddTech.Location = New System.Drawing.Point(59, 148)
        Me.btnAddTech.Name = "btnAddTech"
        Me.btnAddTech.Size = New System.Drawing.Size(102, 23)
        Me.btnAddTech.TabIndex = 7
        Me.btnAddTech.Text = "Add Technician"
        Me.btnAddTech.UseVisualStyleBackColor = True
        '
        'btnEditTech
        '
        Me.btnEditTech.Location = New System.Drawing.Point(59, 207)
        Me.btnEditTech.Name = "btnEditTech"
        Me.btnEditTech.Size = New System.Drawing.Size(102, 23)
        Me.btnEditTech.TabIndex = 8
        Me.btnEditTech.Text = "Edit Technician"
        Me.btnEditTech.UseVisualStyleBackColor = True
        '
        'btnEmailTech
        '
        Me.btnEmailTech.Location = New System.Drawing.Point(197, 207)
        Me.btnEmailTech.Name = "btnEmailTech"
        Me.btnEmailTech.Size = New System.Drawing.Size(177, 23)
        Me.btnEmailTech.TabIndex = 9
        Me.btnEmailTech.Text = "email selected technicians"
        Me.btnEmailTech.UseVisualStyleBackColor = True
        '
        'cboTechRole
        '
        Me.cboTechRole.FormattingEnabled = True
        Me.cboTechRole.Location = New System.Drawing.Point(59, 90)
        Me.cboTechRole.Name = "cboTechRole"
        Me.cboTechRole.Size = New System.Drawing.Size(121, 21)
        Me.cboTechRole.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 262)
        Me.Controls.Add(Me.cboTechRole)
        Me.Controls.Add(Me.btnEmailTech)
        Me.Controls.Add(Me.btnEditTech)
        Me.Controls.Add(Me.btnAddTech)
        Me.Controls.Add(Me.grdTechnicians)
        Me.Controls.Add(Me.txtTechEmail)
        Me.Controls.Add(Me.txtTechName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.grdTechnicians, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTechName As System.Windows.Forms.TextBox
    Friend WithEvents txtTechEmail As System.Windows.Forms.TextBox
    Friend WithEvents grdTechnicians As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddTech As System.Windows.Forms.Button
    Friend WithEvents btnEditTech As System.Windows.Forms.Button
    Friend WithEvents btnEmailTech As System.Windows.Forms.Button
    Friend WithEvents cboTechRole As System.Windows.Forms.ComboBox

End Class
