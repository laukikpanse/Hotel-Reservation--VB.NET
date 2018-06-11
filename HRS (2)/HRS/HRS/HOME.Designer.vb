<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HOME
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HOME))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.unametext = New System.Windows.Forms.TextBox()
        Me.passstext = New System.Windows.Forms.TextBox()
        Me.loginbutton = New System.Windows.Forms.Button()
        Me.resetbutton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.signupbutton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(273, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USERNAME"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(273, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PASSWORD"
        '
        'unametext
        '
        Me.unametext.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.unametext.Location = New System.Drawing.Point(373, 187)
        Me.unametext.Name = "unametext"
        Me.unametext.Size = New System.Drawing.Size(133, 20)
        Me.unametext.TabIndex = 2
        '
        'passstext
        '
        Me.passstext.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.passstext.Location = New System.Drawing.Point(373, 227)
        Me.passstext.Name = "passstext"
        Me.passstext.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passstext.Size = New System.Drawing.Size(133, 20)
        Me.passstext.TabIndex = 3
        '
        'loginbutton
        '
        Me.loginbutton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.loginbutton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbutton.Location = New System.Drawing.Point(57, 131)
        Me.loginbutton.Name = "loginbutton"
        Me.loginbutton.Size = New System.Drawing.Size(75, 23)
        Me.loginbutton.TabIndex = 4
        Me.loginbutton.Text = "LOGIN"
        Me.loginbutton.UseVisualStyleBackColor = True
        '
        'resetbutton
        '
        Me.resetbutton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.resetbutton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetbutton.Location = New System.Drawing.Point(149, 131)
        Me.resetbutton.Name = "resetbutton"
        Me.resetbutton.Size = New System.Drawing.Size(75, 23)
        Me.resetbutton.TabIndex = 5
        Me.resetbutton.Text = "RESET"
        Me.resetbutton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.signupbutton)
        Me.GroupBox1.Controls.Add(Me.resetbutton)
        Me.GroupBox1.Controls.Add(Me.loginbutton)
        Me.GroupBox1.Location = New System.Drawing.Point(246, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 212)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LOGIN"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(181, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(459, 45)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "WELCOME TO HOTEL CEASERS"
        '
        'signupbutton
        '
        Me.signupbutton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.signupbutton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signupbutton.Location = New System.Drawing.Point(240, 131)
        Me.signupbutton.Name = "signupbutton"
        Me.signupbutton.Size = New System.Drawing.Size(75, 23)
        Me.signupbutton.TabIndex = 8
        Me.signupbutton.Text = "SIGN UP"
        Me.signupbutton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(176, 370)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(503, 85)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'HOME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(799, 467)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.passstext)
        Me.Controls.Add(Me.unametext)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "HOME"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents unametext As TextBox
    Friend WithEvents passstext As TextBox
    Friend WithEvents loginbutton As Button
    Friend WithEvents resetbutton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents signupbutton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
