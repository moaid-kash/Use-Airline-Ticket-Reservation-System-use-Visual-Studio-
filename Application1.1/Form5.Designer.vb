<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PzDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InstDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DategoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New Application1._1.databaseDataSet()
        Me.EmpTableAdapter = New Application1._1.databaseDataSetTableAdapters.empTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.PhonDataGridViewTextBoxColumn, Me.AccoDataGridViewTextBoxColumn, Me.PzDataGridViewTextBoxColumn, Me.InstDataGridViewTextBoxColumn, Me.ToenDataGridViewTextBoxColumn, Me.DrDataGridViewTextBoxColumn, Me.PrsDataGridViewTextBoxColumn, Me.DategoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmpBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(-1, -4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(809, 261)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'PhonDataGridViewTextBoxColumn
        '
        Me.PhonDataGridViewTextBoxColumn.DataPropertyName = "phon"
        Me.PhonDataGridViewTextBoxColumn.HeaderText = "phon"
        Me.PhonDataGridViewTextBoxColumn.Name = "PhonDataGridViewTextBoxColumn"
        '
        'AccoDataGridViewTextBoxColumn
        '
        Me.AccoDataGridViewTextBoxColumn.DataPropertyName = "acco"
        Me.AccoDataGridViewTextBoxColumn.HeaderText = "acco"
        Me.AccoDataGridViewTextBoxColumn.Name = "AccoDataGridViewTextBoxColumn"
        '
        'PzDataGridViewTextBoxColumn
        '
        Me.PzDataGridViewTextBoxColumn.DataPropertyName = "pz"
        Me.PzDataGridViewTextBoxColumn.HeaderText = "pz"
        Me.PzDataGridViewTextBoxColumn.Name = "PzDataGridViewTextBoxColumn"
        '
        'InstDataGridViewTextBoxColumn
        '
        Me.InstDataGridViewTextBoxColumn.DataPropertyName = "in_st"
        Me.InstDataGridViewTextBoxColumn.HeaderText = "in_st"
        Me.InstDataGridViewTextBoxColumn.Name = "InstDataGridViewTextBoxColumn"
        '
        'ToenDataGridViewTextBoxColumn
        '
        Me.ToenDataGridViewTextBoxColumn.DataPropertyName = "to_en"
        Me.ToenDataGridViewTextBoxColumn.HeaderText = "to_en"
        Me.ToenDataGridViewTextBoxColumn.Name = "ToenDataGridViewTextBoxColumn"
        '
        'DrDataGridViewTextBoxColumn
        '
        Me.DrDataGridViewTextBoxColumn.DataPropertyName = "dr"
        Me.DrDataGridViewTextBoxColumn.HeaderText = "dr"
        Me.DrDataGridViewTextBoxColumn.Name = "DrDataGridViewTextBoxColumn"
        '
        'PrsDataGridViewTextBoxColumn
        '
        Me.PrsDataGridViewTextBoxColumn.DataPropertyName = "prs"
        Me.PrsDataGridViewTextBoxColumn.HeaderText = "prs"
        Me.PrsDataGridViewTextBoxColumn.Name = "PrsDataGridViewTextBoxColumn"
        '
        'DategoDataGridViewTextBoxColumn
        '
        Me.DategoDataGridViewTextBoxColumn.DataPropertyName = "date_go"
        Me.DategoDataGridViewTextBoxColumn.HeaderText = "date_go"
        Me.DategoDataGridViewTextBoxColumn.Name = "DategoDataGridViewTextBoxColumn"
        '
        'EmpBindingSource
        '
        Me.EmpBindingSource.DataMember = "emp"
        Me.EmpBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "databaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpTableAdapter
        '
        Me.EmpTableAdapter.ClearBeforeFill = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Application1._1.My.Resources.Resources._2016_6_5_13_54_37_479
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(805, 453)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DatabaseDataSet As Application1._1.databaseDataSet
    Friend WithEvents EmpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpTableAdapter As Application1._1.databaseDataSetTableAdapters.empTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PzDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InstDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DategoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
