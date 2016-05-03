<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DebugMonitor
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
        Me.DebugGeneral = New System.Windows.Forms.ListBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DebugConnection = New System.Windows.Forms.ListBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DebugGeneral
        '
        Me.DebugGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DebugGeneral.FormattingEnabled = True
        Me.DebugGeneral.Location = New System.Drawing.Point(3, 3)
        Me.DebugGeneral.Name = "DebugGeneral"
        Me.DebugGeneral.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.DebugGeneral.Size = New System.Drawing.Size(640, 373)
        Me.DebugGeneral.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(654, 405)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DebugGeneral)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(646, 379)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "DEBUG: General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DebugConnection)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(309, 294)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "DEBUG: Connection"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DebugConnection
        '
        Me.DebugConnection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DebugConnection.FormattingEnabled = True
        Me.DebugConnection.Location = New System.Drawing.Point(3, 3)
        Me.DebugConnection.Name = "DebugConnection"
        Me.DebugConnection.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.DebugConnection.Size = New System.Drawing.Size(303, 288)
        Me.DebugConnection.TabIndex = 0
        '
        'DebugMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 405)
        Me.Controls.Add(Me.TabControl1)
        Me.HelpButton = True
        Me.KeyPreview = True
        Me.Name = "DebugMonitor"
        Me.Text = "MagiCorp uChat | Debug Monitor"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Public WithEvents DebugGeneral As System.Windows.Forms.ListBox
    Public WithEvents DebugConnection As System.Windows.Forms.ListBox
End Class
