<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuarentenaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformacionSobreElProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActulizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Lblcarpetas = New System.Windows.Forms.Label()
        Me.Lblvirus = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Btnlimpiar = New System.Windows.Forms.Button()
        Me.BtnAnalisis = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivosToolStripMenuItem, Me.ConfiguracionToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(777, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivosToolStripMenuItem
        '
        Me.ArchivosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivosToolStripMenuItem.Name = "ArchivosToolStripMenuItem"
        Me.ArchivosToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ArchivosToolStripMenuItem.Text = "Archivos"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem, Me.CuarentenaToolStripMenuItem})
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguracionToolStripMenuItem.Text = "Configuracion"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'CuarentenaToolStripMenuItem
        '
        Me.CuarentenaToolStripMenuItem.Name = "CuarentenaToolStripMenuItem"
        Me.CuarentenaToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.CuarentenaToolStripMenuItem.Text = "Cuarentena"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformacionSobreElProductoToolStripMenuItem, Me.ActulizarToolStripMenuItem, Me.SoporteToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'InformacionSobreElProductoToolStripMenuItem
        '
        Me.InformacionSobreElProductoToolStripMenuItem.Name = "InformacionSobreElProductoToolStripMenuItem"
        Me.InformacionSobreElProductoToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.InformacionSobreElProductoToolStripMenuItem.Text = "Informacion Sobre el Producto"
        '
        'ActulizarToolStripMenuItem
        '
        Me.ActulizarToolStripMenuItem.Name = "ActulizarToolStripMenuItem"
        Me.ActulizarToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.ActulizarToolStripMenuItem.Text = "Actulizar"
        '
        'SoporteToolStripMenuItem
        '
        Me.SoporteToolStripMenuItem.Name = "SoporteToolStripMenuItem"
        Me.SoporteToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.SoporteToolStripMenuItem.Text = "Soporte"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(756, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Versión 1.1.0"
        '
        'Timer1
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ProgressBar1.Location = New System.Drawing.Point(19, 87)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(689, 21)
        Me.ProgressBar1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(415, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 42)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Anti "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Brown
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label2.Location = New System.Drawing.Point(483, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 42)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Malware"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(25, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Estado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label5.Location = New System.Drawing.Point(82, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "..."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Lblcarpetas)
        Me.GroupBox2.Controls.Add(Me.Lblvirus)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.ProgressBar1)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(726, 127)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'Lblcarpetas
        '
        Me.Lblcarpetas.AutoSize = True
        Me.Lblcarpetas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Lblcarpetas.Location = New System.Drawing.Point(172, 65)
        Me.Lblcarpetas.Name = "Lblcarpetas"
        Me.Lblcarpetas.Size = New System.Drawing.Size(49, 13)
        Me.Lblcarpetas.TabIndex = 10
        Me.Lblcarpetas.Text = "Carpetas"
        '
        'Lblvirus
        '
        Me.Lblvirus.AutoSize = True
        Me.Lblvirus.BackColor = System.Drawing.SystemColors.Control
        Me.Lblvirus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Lblvirus.Location = New System.Drawing.Point(121, 65)
        Me.Lblvirus.Name = "Lblvirus"
        Me.Lblvirus.Size = New System.Drawing.Size(30, 13)
        Me.Lblvirus.TabIndex = 9
        Me.Lblvirus.Text = "Virus"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Hacking_48px1
        Me.PictureBox1.Location = New System.Drawing.Point(616, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Btnlimpiar)
        Me.GroupBox1.Controls.Add(Me.BtnAnalisis)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(726, 265)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Button6
        '
        Me.Button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button6.Location = New System.Drawing.Point(505, 112)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(215, 58)
        Me.Button6.TabIndex = 15
        Me.Button6.Text = "USB Desinfector"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button5.Location = New System.Drawing.Point(505, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(215, 59)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Carpetas "
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button4.Image = Global.WindowsApplication1.My.Resources.Resources.Refresh_Shield_48px
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(275, 195)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(216, 57)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Actulizar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.Stop_Sign_48px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(19, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(215, 58)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Detener Analisis"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Image = Global.WindowsApplication1.My.Resources.Resources.Sort_By_Modified_Date_48px
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(275, 110)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(215, 60)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Análisis Personalizado"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Image = Global.WindowsApplication1.My.Resources.Resources.Full_Version_40px
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(275, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(215, 60)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Análisis Completo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Btnlimpiar
        '
        Me.Btnlimpiar.AutoSize = True
        Me.Btnlimpiar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btnlimpiar.Image = Global.WindowsApplication1.My.Resources.Resources.Delete_48px
        Me.Btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnlimpiar.Location = New System.Drawing.Point(19, 195)
        Me.Btnlimpiar.Name = "Btnlimpiar"
        Me.Btnlimpiar.Size = New System.Drawing.Size(215, 58)
        Me.Btnlimpiar.TabIndex = 1
        Me.Btnlimpiar.Text = "Limpiar"
        Me.Btnlimpiar.UseVisualStyleBackColor = True
        '
        'BtnAnalisis
        '
        Me.BtnAnalisis.AutoSize = True
        Me.BtnAnalisis.ForeColor = System.Drawing.SystemColors.Desktop
        Me.BtnAnalisis.Image = Global.WindowsApplication1.My.Resources.Resources.Search_48px
        Me.BtnAnalisis.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnAnalisis.Location = New System.Drawing.Point(19, 19)
        Me.BtnAnalisis.Name = "BtnAnalisis"
        Me.BtnAnalisis.Size = New System.Drawing.Size(215, 60)
        Me.BtnAnalisis.TabIndex = 0
        Me.BtnAnalisis.Text = "Análisis Rápido"
        Me.BtnAnalisis.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(708, 439)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Version 1.1.0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(777, 461)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Inicio"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btnlimpiar As System.Windows.Forms.Button
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformacionSobreElProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActulizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SoporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuarentenaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAnalisis As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Lblvirus As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Lblcarpetas As System.Windows.Forms.Label

End Class
