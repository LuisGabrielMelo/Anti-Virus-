<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Basededatos1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Base_de_datos1DataSet = New WindowsApplication1.Base_de_datos1DataSet()
        Me.Nombres_de_VirusTableAdapter = New WindowsApplication1.Base_de_datos1DataSetTableAdapters.Nombres_de_VirusTableAdapter()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Selecionar = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Vendedor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Fecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Ubicacion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        CType(Me.Basededatos1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Base_de_datos1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Basededatos1DataSetBindingSource
        '
        Me.Basededatos1DataSetBindingSource.DataMember = "Nombres de Virus"
        Me.Basededatos1DataSetBindingSource.DataSource = Me.Base_de_datos1DataSet
        '
        'Base_de_datos1DataSet
        '
        Me.Base_de_datos1DataSet.DataSetName = "Base_de_datos1DataSet"
        Me.Base_de_datos1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Nombres_de_VirusTableAdapter
        '
        Me.Nombres_de_VirusTableAdapter.ClearBeforeFill = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Selecionar, Me.Vendedor, Me.Fecha, Me.Tipo, Me.Ubicacion})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(729, 433)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Selecionar
        '
        Me.Selecionar.Text = "Selecionar"
        Me.Selecionar.Width = 105
        '
        'Vendedor
        '
        Me.Vendedor.Text = "Vendedor"
        Me.Vendedor.Width = 110
        '
        'Fecha
        '
        Me.Fecha.Text = "Fecha"
        Me.Fecha.Width = 115
        '
        'Tipo
        '
        Me.Tipo.Text = "Tipo"
        Me.Tipo.Width = 102
        '
        'Ubicacion
        '
        Me.Ubicacion.Text = "Ubicacion"
        Me.Ubicacion.Width = 104
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 411)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(729, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 433)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ListView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Cuarentena"
        CType(Me.Basededatos1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Base_de_datos1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Basededatos1DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Base_de_datos1DataSet As WindowsApplication1.Base_de_datos1DataSet
    Friend WithEvents Nombres_de_VirusTableAdapter As WindowsApplication1.Base_de_datos1DataSetTableAdapters.Nombres_de_VirusTableAdapter
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Selecionar As System.Windows.Forms.ColumnHeader
    Friend WithEvents Vendedor As System.Windows.Forms.ColumnHeader
    Friend WithEvents Fecha As System.Windows.Forms.ColumnHeader
    Friend WithEvents Tipo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Ubicacion As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
End Class
