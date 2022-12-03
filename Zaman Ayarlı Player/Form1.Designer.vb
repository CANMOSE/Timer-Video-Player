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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.VideoyuSeçToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ZamanlayıcıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TamEkranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UyarıÖnceTıklayınızToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TamEkranToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.HakkındaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 24)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(811, 466)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(80, 409)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(65, 17)
        Me.CheckBox2.TabIndex = 12
        Me.CheckBox2.Text = "Sifirlama"
        Me.CheckBox2.UseVisualStyleBackColor = True
        Me.CheckBox2.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VideoyuSeçToolStripMenuItem, Me.ZamanlayıcıToolStripMenuItem, Me.TamEkranToolStripMenuItem, Me.HakkındaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(811, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VideoyuSeçToolStripMenuItem
        '
        Me.VideoyuSeçToolStripMenuItem.Name = "VideoyuSeçToolStripMenuItem"
        Me.VideoyuSeçToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.VideoyuSeçToolStripMenuItem.Text = "Videoyu Seç"
        '
        'ZamanlayıcıToolStripMenuItem
        '
        Me.ZamanlayıcıToolStripMenuItem.Name = "ZamanlayıcıToolStripMenuItem"
        Me.ZamanlayıcıToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.ZamanlayıcıToolStripMenuItem.Text = "Zamanlayıcı"
        '
        'TamEkranToolStripMenuItem
        '
        Me.TamEkranToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UyarıÖnceTıklayınızToolStripMenuItem, Me.TamEkranToolStripMenuItem1})
        Me.TamEkranToolStripMenuItem.Name = "TamEkranToolStripMenuItem"
        Me.TamEkranToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.TamEkranToolStripMenuItem.Text = "Tam Ekran"
        '
        'UyarıÖnceTıklayınızToolStripMenuItem
        '
        Me.UyarıÖnceTıklayınızToolStripMenuItem.Name = "UyarıÖnceTıklayınızToolStripMenuItem"
        Me.UyarıÖnceTıklayınızToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.UyarıÖnceTıklayınızToolStripMenuItem.Text = "Uyarı Önce Tıklayınız"
        '
        'TamEkranToolStripMenuItem1
        '
        Me.TamEkranToolStripMenuItem1.Name = "TamEkranToolStripMenuItem1"
        Me.TamEkranToolStripMenuItem1.Size = New System.Drawing.Size(184, 22)
        Me.TamEkranToolStripMenuItem1.Text = "Tam Ekran"
        '
        'HakkındaToolStripMenuItem
        '
        Me.HakkındaToolStripMenuItem.Name = "HakkındaToolStripMenuItem"
        Me.HakkındaToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.HakkındaToolStripMenuItem.Text = "Hakkında"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 490)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Zaman Ayarlı Player"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents VideoyuSeçToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZamanlayıcıToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TamEkranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UyarıÖnceTıklayınızToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TamEkranToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HakkındaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
