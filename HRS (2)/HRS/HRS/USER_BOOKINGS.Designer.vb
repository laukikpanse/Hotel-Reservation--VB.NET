<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USER_BOOKINGS
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rnotxt = New System.Windows.Forms.TextBox()
        Me.unametxt = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(40, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(964, 113)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(505, 405)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "CANCEL RESERVATION"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rnotxt
        '
        Me.rnotxt.Enabled = False
        Me.rnotxt.Location = New System.Drawing.Point(418, 357)
        Me.rnotxt.Name = "rnotxt"
        Me.rnotxt.Size = New System.Drawing.Size(100, 20)
        Me.rnotxt.TabIndex = 2
        '
        'unametxt
        '
        Me.unametxt.Enabled = False
        Me.unametxt.Location = New System.Drawing.Point(630, 357)
        Me.unametxt.Name = "unametxt"
        Me.unametxt.Size = New System.Drawing.Size(100, 20)
        Me.unametxt.TabIndex = 3
        '
        'USER_BOOKINGS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(1105, 647)
        Me.Controls.Add(Me.unametxt)
        Me.Controls.Add(Me.rnotxt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "USER_BOOKINGS"
        Me.Text = "USER_BOOKINGS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents rnotxt As TextBox
    Friend WithEvents unametxt As TextBox
End Class
