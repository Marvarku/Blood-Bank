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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BLOODINSTOCKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AVEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AVEToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BVEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BVEToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OVEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OVEToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DONATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonorsListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonorsListToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.RequestForBloodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestForBloodToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BLOODINSTOCKToolStripMenuItem, Me.DONATEToolStripMenuItem, Me.RequestForBloodToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(570, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BLOODINSTOCKToolStripMenuItem
        '
        Me.BLOODINSTOCKToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AVEToolStripMenuItem, Me.AVEToolStripMenuItem1, Me.BVEToolStripMenuItem, Me.BVEToolStripMenuItem1, Me.OVEToolStripMenuItem, Me.OVEToolStripMenuItem1})
        Me.BLOODINSTOCKToolStripMenuItem.Name = "BLOODINSTOCKToolStripMenuItem"
        Me.BLOODINSTOCKToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.BLOODINSTOCKToolStripMenuItem.Text = "BLOOD IN STOCK"
        '
        'AVEToolStripMenuItem
        '
        Me.AVEToolStripMenuItem.Name = "AVEToolStripMenuItem"
        Me.AVEToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AVEToolStripMenuItem.Text = "A +VE"
        '
        'AVEToolStripMenuItem1
        '
        Me.AVEToolStripMenuItem1.Name = "AVEToolStripMenuItem1"
        Me.AVEToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.AVEToolStripMenuItem1.Text = "A -VE"
        '
        'BVEToolStripMenuItem
        '
        Me.BVEToolStripMenuItem.Name = "BVEToolStripMenuItem"
        Me.BVEToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.BVEToolStripMenuItem.Text = "B +VE"
        '
        'BVEToolStripMenuItem1
        '
        Me.BVEToolStripMenuItem1.Name = "BVEToolStripMenuItem1"
        Me.BVEToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.BVEToolStripMenuItem1.Text = "B -VE"
        '
        'OVEToolStripMenuItem
        '
        Me.OVEToolStripMenuItem.Name = "OVEToolStripMenuItem"
        Me.OVEToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.OVEToolStripMenuItem.Text = "O +VE"
        '
        'OVEToolStripMenuItem1
        '
        Me.OVEToolStripMenuItem1.Name = "OVEToolStripMenuItem1"
        Me.OVEToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.OVEToolStripMenuItem1.Text = "O -VE"
        '
        'DONATEToolStripMenuItem
        '
        Me.DONATEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DonorsListToolStripMenuItem, Me.DonorsListToolStripMenuItem1})
        Me.DONATEToolStripMenuItem.Name = "DONATEToolStripMenuItem"
        Me.DONATEToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.DONATEToolStripMenuItem.Text = "DONATE"
        '
        'DonorsListToolStripMenuItem
        '
        Me.DonorsListToolStripMenuItem.Name = "DonorsListToolStripMenuItem"
        Me.DonorsListToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DonorsListToolStripMenuItem.Text = "Donate Blood"
        '
        'DonorsListToolStripMenuItem1
        '
        Me.DonorsListToolStripMenuItem1.Name = "DonorsListToolStripMenuItem1"
        Me.DonorsListToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.DonorsListToolStripMenuItem1.Text = "Donors List"
        '
        'RequestForBloodToolStripMenuItem
        '
        Me.RequestForBloodToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RequestForBloodToolStripMenuItem1})
        Me.RequestForBloodToolStripMenuItem.Name = "RequestForBloodToolStripMenuItem"
        Me.RequestForBloodToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.RequestForBloodToolStripMenuItem.Text = "Request For Blood "
        '
        'RequestForBloodToolStripMenuItem1
        '
        Me.RequestForBloodToolStripMenuItem1.Name = "RequestForBloodToolStripMenuItem1"
        Me.RequestForBloodToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.RequestForBloodToolStripMenuItem1.Text = "Request For Blood"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 367)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BLOODINSTOCKToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AVEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AVEToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BVEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BVEToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OVEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OVEToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DONATEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents DonorsListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DonorsListToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RequestForBloodToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RequestForBloodToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
