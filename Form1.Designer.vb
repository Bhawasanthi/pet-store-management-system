<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFrontPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pbLoarding1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblReportProgress = New System.Windows.Forms.Label()
        Me.lblStatusText = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'pbLoarding1
        '
        Me.pbLoarding1.Location = New System.Drawing.Point(177, 457)
        Me.pbLoarding1.Name = "pbLoarding1"
        Me.pbLoarding1.Size = New System.Drawing.Size(868, 26)
        Me.pbLoarding1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 49.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(122, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(884, 93)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "V E T P E T S   C A R E"
        '
        'lblReportProgress
        '
        Me.lblReportProgress.BackColor = System.Drawing.Color.Transparent
        Me.lblReportProgress.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportProgress.Location = New System.Drawing.Point(923, 500)
        Me.lblReportProgress.Name = "lblReportProgress"
        Me.lblReportProgress.Size = New System.Drawing.Size(122, 29)
        Me.lblReportProgress.TabIndex = 2
        Me.lblReportProgress.Text = "000%"
        Me.lblReportProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStatusText
        '
        Me.lblStatusText.AutoSize = True
        Me.lblStatusText.BackColor = System.Drawing.Color.Transparent
        Me.lblStatusText.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusText.Location = New System.Drawing.Point(172, 500)
        Me.lblStatusText.Name = "lblStatusText"
        Me.lblStatusText.Size = New System.Drawing.Size(291, 29)
        Me.lblStatusText.TabIndex = 2
        Me.lblStatusText.Text = "Launching the application..."
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frmFrontPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.pet_store_management_system.My.Resources.Resources.iStock_1171733307_1_2000x1334
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1185, 675)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblStatusText)
        Me.Controls.Add(Me.lblReportProgress)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbLoarding1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmFrontPage"
        Me.Text = "frontPage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbLoarding1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents lblReportProgress As Label
    Friend WithEvents lblStatusText As Label
    Friend WithEvents Timer1 As Timer
End Class
