<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMIN_HOME
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HOMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RESTAURANTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rnotxt = New System.Windows.Forms.TextBox()
        Me.ratetxt = New System.Windows.Forms.TextBox()
        Me.rtypetxt = New System.Windows.Forms.ComboBox()
        Me.savebutton = New System.Windows.Forms.Button()
        Me.resetbutton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BOOKINGHISTORYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HOMEToolStripMenuItem, Me.RESTAURANTToolStripMenuItem, Me.BOOKINGHISTORYToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1052, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HOMEToolStripMenuItem
        '
        Me.HOMEToolStripMenuItem.Name = "HOMEToolStripMenuItem"
        Me.HOMEToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.HOMEToolStripMenuItem.Text = "HOME"
        '
        'RESTAURANTToolStripMenuItem
        '
        Me.RESTAURANTToolStripMenuItem.Name = "RESTAURANTToolStripMenuItem"
        Me.RESTAURANTToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.RESTAURANTToolStripMenuItem.Text = "GUEST LIST"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ROOM TYPE"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(153, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ROOM NO"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(153, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "RATE PER DAY"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(153, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 4
        '
        'rnotxt
        '
        Me.rnotxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rnotxt.Location = New System.Drawing.Point(254, 198)
        Me.rnotxt.Name = "rnotxt"
        Me.rnotxt.Size = New System.Drawing.Size(121, 20)
        Me.rnotxt.TabIndex = 5
        '
        'ratetxt
        '
        Me.ratetxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ratetxt.Enabled = False
        Me.ratetxt.Location = New System.Drawing.Point(254, 232)
        Me.ratetxt.Name = "ratetxt"
        Me.ratetxt.Size = New System.Drawing.Size(121, 20)
        Me.ratetxt.TabIndex = 6
        '
        'rtypetxt
        '
        Me.rtypetxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rtypetxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.rtypetxt.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rtypetxt.FormattingEnabled = True
        Me.rtypetxt.Items.AddRange(New Object() {"NON/AC DELUXE", "A/C DELUXE", "QUEENS SUITE", "KINGS SUITE", "PRESIDENTIAL SUITE"})
        Me.rtypetxt.Location = New System.Drawing.Point(254, 170)
        Me.rtypetxt.Name = "rtypetxt"
        Me.rtypetxt.Size = New System.Drawing.Size(121, 21)
        Me.rtypetxt.TabIndex = 7
        '
        'savebutton
        '
        Me.savebutton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.savebutton.Location = New System.Drawing.Point(98, 163)
        Me.savebutton.Name = "savebutton"
        Me.savebutton.Size = New System.Drawing.Size(75, 23)
        Me.savebutton.TabIndex = 8
        Me.savebutton.Text = "SAVE"
        Me.savebutton.UseVisualStyleBackColor = True
        '
        'resetbutton
        '
        Me.resetbutton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.resetbutton.Location = New System.Drawing.Point(206, 163)
        Me.resetbutton.Name = "resetbutton"
        Me.resetbutton.Size = New System.Drawing.Size(75, 23)
        Me.resetbutton.TabIndex = 9
        Me.resetbutton.Text = "RESET"
        Me.resetbutton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.resetbutton)
        Me.GroupBox1.Controls.Add(Me.savebutton)
        Me.GroupBox1.Location = New System.Drawing.Point(121, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 225)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ADD A ROOM"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(260, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "$"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(254, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(537, 37)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "WELCOME TO THE ADMINISTRATOR PANEL"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 33)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(437, 169)
        Me.DataGridView1.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "LOGIN TIME"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(87, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Label7"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(568, 102)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(472, 225)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "EXISTING ROOM DETAILS"
        '
        'BOOKINGHISTORYToolStripMenuItem
        '
        Me.BOOKINGHISTORYToolStripMenuItem.Name = "BOOKINGHISTORYToolStripMenuItem"
        Me.BOOKINGHISTORYToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.BOOKINGHISTORYToolStripMenuItem.Text = "BOOKING HISTORY"
        '
        'ADMIN_HOME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(1052, 550)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rtypetxt)
        Me.Controls.Add(Me.ratetxt)
        Me.Controls.Add(Me.rnotxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ADMIN_HOME"
        Me.Text = "ADMIN_HOME"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HOMEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RESTAURANTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents rnotxt As TextBox
    Friend WithEvents ratetxt As TextBox
    Friend WithEvents rtypetxt As ComboBox
    Friend WithEvents savebutton As Button
    Friend WithEvents resetbutton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BOOKINGHISTORYToolStripMenuItem As ToolStripMenuItem
End Class
