<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QuarterBacks
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GamesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YdsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IntDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RatingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConfDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchoolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PctDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuarterbacksBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.QBDatasetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QBDataset = New Lpetelin_FinalProjectNFLDraft.QBDataset()
        Me.QuarterbacksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QuarterbacksTableAdapter1 = New Lpetelin_FinalProjectNFLDraft.QBDatasetTableAdapters.QuarterbacksTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuarterbacksBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QBDatasetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QBDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuarterbacksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FnameDataGridViewTextBoxColumn, Me.LnameDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.GamesDataGridViewTextBoxColumn, Me.CmpDataGridViewTextBoxColumn, Me.AttDataGridViewTextBoxColumn, Me.YdsDataGridViewTextBoxColumn, Me.TDDataGridViewTextBoxColumn, Me.IntDataGridViewTextBoxColumn, Me.RatingDataGridViewTextBoxColumn, Me.ConfDataGridViewTextBoxColumn, Me.SchoolDataGridViewTextBoxColumn, Me.PctDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.QuarterbacksBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(28, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1109, 255)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FnameDataGridViewTextBoxColumn
        '
        Me.FnameDataGridViewTextBoxColumn.DataPropertyName = "Fname"
        Me.FnameDataGridViewTextBoxColumn.HeaderText = "Fname"
        Me.FnameDataGridViewTextBoxColumn.Name = "FnameDataGridViewTextBoxColumn"
        Me.FnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LnameDataGridViewTextBoxColumn
        '
        Me.LnameDataGridViewTextBoxColumn.DataPropertyName = "Lname"
        Me.LnameDataGridViewTextBoxColumn.HeaderText = "Lname"
        Me.LnameDataGridViewTextBoxColumn.Name = "LnameDataGridViewTextBoxColumn"
        Me.LnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClassDataGridViewTextBoxColumn
        '
        Me.ClassDataGridViewTextBoxColumn.DataPropertyName = "Class"
        Me.ClassDataGridViewTextBoxColumn.HeaderText = "Class"
        Me.ClassDataGridViewTextBoxColumn.Name = "ClassDataGridViewTextBoxColumn"
        Me.ClassDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GamesDataGridViewTextBoxColumn
        '
        Me.GamesDataGridViewTextBoxColumn.DataPropertyName = "Games"
        Me.GamesDataGridViewTextBoxColumn.HeaderText = "Games"
        Me.GamesDataGridViewTextBoxColumn.Name = "GamesDataGridViewTextBoxColumn"
        Me.GamesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CmpDataGridViewTextBoxColumn
        '
        Me.CmpDataGridViewTextBoxColumn.DataPropertyName = "Cmp"
        Me.CmpDataGridViewTextBoxColumn.HeaderText = "Cmp"
        Me.CmpDataGridViewTextBoxColumn.Name = "CmpDataGridViewTextBoxColumn"
        Me.CmpDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AttDataGridViewTextBoxColumn
        '
        Me.AttDataGridViewTextBoxColumn.DataPropertyName = "Att"
        Me.AttDataGridViewTextBoxColumn.HeaderText = "Att"
        Me.AttDataGridViewTextBoxColumn.Name = "AttDataGridViewTextBoxColumn"
        Me.AttDataGridViewTextBoxColumn.ReadOnly = True
        '
        'YdsDataGridViewTextBoxColumn
        '
        Me.YdsDataGridViewTextBoxColumn.DataPropertyName = "Yds"
        Me.YdsDataGridViewTextBoxColumn.HeaderText = "Yds"
        Me.YdsDataGridViewTextBoxColumn.Name = "YdsDataGridViewTextBoxColumn"
        Me.YdsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TDDataGridViewTextBoxColumn
        '
        Me.TDDataGridViewTextBoxColumn.DataPropertyName = "TD"
        Me.TDDataGridViewTextBoxColumn.HeaderText = "TD"
        Me.TDDataGridViewTextBoxColumn.Name = "TDDataGridViewTextBoxColumn"
        Me.TDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IntDataGridViewTextBoxColumn
        '
        Me.IntDataGridViewTextBoxColumn.DataPropertyName = "Int"
        Me.IntDataGridViewTextBoxColumn.HeaderText = "Int"
        Me.IntDataGridViewTextBoxColumn.Name = "IntDataGridViewTextBoxColumn"
        Me.IntDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RatingDataGridViewTextBoxColumn
        '
        Me.RatingDataGridViewTextBoxColumn.DataPropertyName = "Rating"
        Me.RatingDataGridViewTextBoxColumn.HeaderText = "Rating"
        Me.RatingDataGridViewTextBoxColumn.Name = "RatingDataGridViewTextBoxColumn"
        Me.RatingDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConfDataGridViewTextBoxColumn
        '
        Me.ConfDataGridViewTextBoxColumn.DataPropertyName = "Conf"
        Me.ConfDataGridViewTextBoxColumn.HeaderText = "Conf"
        Me.ConfDataGridViewTextBoxColumn.Name = "ConfDataGridViewTextBoxColumn"
        Me.ConfDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SchoolDataGridViewTextBoxColumn
        '
        Me.SchoolDataGridViewTextBoxColumn.DataPropertyName = "School"
        Me.SchoolDataGridViewTextBoxColumn.HeaderText = "School"
        Me.SchoolDataGridViewTextBoxColumn.Name = "SchoolDataGridViewTextBoxColumn"
        Me.SchoolDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PctDataGridViewTextBoxColumn
        '
        Me.PctDataGridViewTextBoxColumn.DataPropertyName = "Pct"
        Me.PctDataGridViewTextBoxColumn.HeaderText = "Pct"
        Me.PctDataGridViewTextBoxColumn.Name = "PctDataGridViewTextBoxColumn"
        Me.PctDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuarterbacksBindingSource1
        '
        Me.QuarterbacksBindingSource1.DataMember = "Quarterbacks"
        Me.QuarterbacksBindingSource1.DataSource = Me.QBDatasetBindingSource
        '
        'QBDatasetBindingSource
        '
        Me.QBDatasetBindingSource.DataSource = Me.QBDataset
        Me.QBDatasetBindingSource.Position = 0
        '
        'QBDataset
        '
        Me.QBDataset.DataSetName = "QBDataset"
        Me.QBDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QuarterbacksBindingSource
        '
        Me.QuarterbacksBindingSource.DataMember = "Quarterbacks"
        Me.QuarterbacksBindingSource.DataSource = Me.QBDatasetBindingSource
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(311, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(512, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Top 10 College Football Quarterbacks and their Statistics from the 2017 Season"
        '
        'QuarterbacksTableAdapter1
        '
        Me.QuarterbacksTableAdapter1.ClearBeforeFill = True
        '
        'QuarterBacks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1163, 395)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "QuarterBacks"
        Me.Text = "QuarterBacks"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuarterbacksBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QBDatasetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QBDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuarterbacksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents QBDatasetBindingSource As BindingSource
    Friend WithEvents QBDataset As QBDataset
    Friend WithEvents QuarterbacksTableAdapter1 As QBDatasetTableAdapters.QuarterbacksTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GamesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CmpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YdsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IntDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RatingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConfDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SchoolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PctDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuarterbacksBindingSource As BindingSource
    Friend WithEvents QuarterbacksBindingSource1 As BindingSource
End Class
