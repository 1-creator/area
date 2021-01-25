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
        Me.lblradius = New System.Windows.Forms.Label()
        Me.lblarea = New System.Windows.Forms.Label()
        Me.cmdarea = New System.Windows.Forms.Button()
        Me.cmdexit = New System.Windows.Forms.Button()
        Me.txtradius = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblradius
        '
        Me.lblradius.AutoSize = True
        Me.lblradius.Location = New System.Drawing.Point(53, 47)
        Me.lblradius.Name = "lblradius"
        Me.lblradius.Size = New System.Drawing.Size(62, 13)
        Me.lblradius.TabIndex = 0
        Me.lblradius.Text = "enter radius"
        '
        'lblarea
        '
        Me.lblarea.AutoSize = True
        Me.lblarea.Location = New System.Drawing.Point(95, 106)
        Me.lblarea.Name = "lblarea"
        Me.lblarea.Size = New System.Drawing.Size(0, 13)
        Me.lblarea.TabIndex = 1
        '
        'cmdarea
        '
        Me.cmdarea.Location = New System.Drawing.Point(82, 169)
        Me.cmdarea.Name = "cmdarea"
        Me.cmdarea.Size = New System.Drawing.Size(75, 23)
        Me.cmdarea.TabIndex = 2
        Me.cmdarea.Text = "findarea"
        Me.cmdarea.UseVisualStyleBackColor = True
        '
        'cmdexit
        '
        Me.cmdexit.Location = New System.Drawing.Point(215, 169)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(75, 23)
        Me.cmdexit.TabIndex = 3
        Me.cmdexit.Text = "exit"
        Me.cmdexit.UseVisualStyleBackColor = True
        '
        'txtradius
        '
        Me.txtradius.Location = New System.Drawing.Point(190, 40)
        Me.txtradius.Name = "txtradius"
        Me.txtradius.Size = New System.Drawing.Size(100, 20)
        Me.txtradius.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 293)
        Me.Controls.Add(Me.txtradius)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.cmdarea)
        Me.Controls.Add(Me.lblarea)
        Me.Controls.Add(Me.lblradius)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblradius As System.Windows.Forms.Label
    Friend WithEvents lblarea As System.Windows.Forms.Label
    Friend WithEvents cmdarea As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents txtradius As System.Windows.Forms.TextBox

End Class
