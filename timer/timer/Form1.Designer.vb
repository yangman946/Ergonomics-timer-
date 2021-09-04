<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProgressPanel = New System.Windows.Forms.Panel()
        Me.MetroCheckBox1 = New MetroFramework.Controls.MetroCheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Reset_Btn = New System.Windows.Forms.Button()
        Me.Stop_Btn = New System.Windows.Forms.Button()
        Me.Start_btn = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(198, 226)
        Me.TextBox1.MaxLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(108, 26)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "0"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(198, 194)
        Me.TextBox2.MaxLength = 2
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(108, 26)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "30"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(198, 162)
        Me.TextBox3.MaxLength = 2
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(108, 26)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = "0"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(0, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(414, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "00:00:00"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(126, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Hours"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(106, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Minutes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(102, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Seconds"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ProgressPanel)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(410, 98)
        Me.Panel1.TabIndex = 10
        '
        'ProgressPanel
        '
        Me.ProgressPanel.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ProgressPanel.Location = New System.Drawing.Point(0, 83)
        Me.ProgressPanel.Name = "ProgressPanel"
        Me.ProgressPanel.Size = New System.Drawing.Size(410, 15)
        Me.ProgressPanel.TabIndex = 4
        '
        'MetroCheckBox1
        '
        Me.MetroCheckBox1.AutoSize = True
        Me.MetroCheckBox1.Checked = True
        Me.MetroCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MetroCheckBox1.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.MetroCheckBox1.FontWeight = MetroFramework.MetroCheckBoxWeight.Light
        Me.MetroCheckBox1.Location = New System.Drawing.Point(198, 258)
        Me.MetroCheckBox1.Name = "MetroCheckBox1"
        Me.MetroCheckBox1.Size = New System.Drawing.Size(74, 25)
        Me.MetroCheckBox1.TabIndex = 11
        Me.MetroCheckBox1.Text = "Loop?"
        Me.MetroCheckBox1.UseSelectable = True
        '
        'Reset_Btn
        '
        Me.Reset_Btn.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Reset_Btn.FlatAppearance.BorderSize = 0
        Me.Reset_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Reset_Btn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reset_Btn.Image = Global.timer.My.Resources.Resources.StopMain
        Me.Reset_Btn.Location = New System.Drawing.Point(106, 308)
        Me.Reset_Btn.Name = "Reset_Btn"
        Me.Reset_Btn.Size = New System.Drawing.Size(100, 45)
        Me.Reset_Btn.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.Reset_Btn, "Reset/Stop")
        Me.Reset_Btn.UseVisualStyleBackColor = False
        '
        'Stop_Btn
        '
        Me.Stop_Btn.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Stop_Btn.BackgroundImage = Global.timer.My.Resources.Resources.pause
        Me.Stop_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Stop_Btn.FlatAppearance.BorderSize = 0
        Me.Stop_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Stop_Btn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stop_Btn.Location = New System.Drawing.Point(206, 308)
        Me.Stop_Btn.Name = "Stop_Btn"
        Me.Stop_Btn.Size = New System.Drawing.Size(100, 45)
        Me.Stop_Btn.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.Stop_Btn, "Pause")
        Me.Stop_Btn.UseVisualStyleBackColor = False
        '
        'Start_btn
        '
        Me.Start_btn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Start_btn.BackgroundImage = Global.timer.My.Resources.Resources.start
        Me.Start_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Start_btn.FlatAppearance.BorderSize = 0
        Me.Start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Start_btn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Start_btn.Location = New System.Drawing.Point(106, 352)
        Me.Start_btn.Name = "Start_btn"
        Me.Start_btn.Size = New System.Drawing.Size(200, 52)
        Me.Start_btn.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.Start_btn, "Start")
        Me.Start_btn.UseVisualStyleBackColor = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(409, 429)
        Me.Controls.Add(Me.MetroCheckBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Reset_Btn)
        Me.Controls.Add(Me.Stop_Btn)
        Me.Controls.Add(Me.Start_btn)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Timer Exerciser by Clarence Yang"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Start_btn As Button
    Friend WithEvents Stop_Btn As Button
    Friend WithEvents Reset_Btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MetroCheckBox1 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ProgressPanel As Panel
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
