<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LBForm
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
        Me.LBDataset = New Lpetelin_FinalProjectNFLDraft.LBDataset()
        Me.LinebackersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LinebackersTableAdapter = New Lpetelin_FinalProjectNFLDraft.LBDatasetTableAdapters.LinebackersTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchoolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConferenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GamesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoloTacklesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssistsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LossDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SacksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LinebackersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.SchoolDataGridViewTextBoxColumn, Me.ConferenceDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.GamesDataGridViewTextBoxColumn, Me.SoloTacklesDataGridViewTextBoxColumn, Me.AssistsDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.LossDataGridViewTextBoxColumn, Me.SacksDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LinebackersBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 66)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1119, 387)
        Me.DataGridView1.TabIndex = 0
        '
        'LBDataset
        '
        Me.LBDataset.DataSetName = "LBDataset"
        Me.LBDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LinebackersBindingSource
        '
        Me.LinebackersBindingSource.DataMember = "Linebackers"
        Me.LinebackersBindingSource.DataSource = Me.LBDataset
        '
        'LinebackersTableAdapter
        '
        Me.LinebackersTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'SchoolDataGridViewTextBoxColumn
        '
        Me.SchoolDataGridViewTextBoxColumn.DataPropertyName = "School"
        Me.SchoolDataGridViewTextBoxColumn.HeaderText = "School"
        Me.SchoolDataGridViewTextBoxColumn.Name = "SchoolDataGridViewTextBoxColumn"
        '
        'ConferenceDataGridViewTextBoxColumn
        '
        Me.ConferenceDataGridViewTextBoxColumn.DataPropertyName = "Conference"
        Me.ConferenceDataGridViewTextBoxColumn.HeaderText = "Conference"
        Me.ConferenceDataGridViewTextBoxColumn.Name = "ConferenceDataGridViewTextBoxColumn"
        '
        'ClassDataGridViewTextBoxColumn
        '
        Me.ClassDataGridViewTextBoxColumn.DataPropertyName = "Class"
        Me.ClassDataGridViewTextBoxColumn.HeaderText = "Class"
        Me.ClassDataGridViewTextBoxColumn.Name = "ClassDataGridViewTextBoxColumn"
        '
        'GamesDataGridViewTextBoxColumn
        '
        Me.GamesDataGridViewTextBoxColumn.DataPropertyName = "Games"
        Me.GamesDataGridViewTextBoxColumn.HeaderText = "Games"
        Me.GamesDataGridViewTextBoxColumn.Name = "GamesDataGridViewTextBoxColumn"
        '
        'SoloTacklesDataGridViewTextBoxColumn
        '
        Me.SoloTacklesDataGridViewTextBoxColumn.DataPropertyName = "SoloTackles"
        Me.SoloTacklesDataGridViewTextBoxColumn.HeaderText = "SoloTackles"
        Me.SoloTacklesDataGridViewTextBoxColumn.Name = "SoloTacklesDataGridViewTextBoxColumn"
        '
        'AssistsDataGridViewTextBoxColumn
        '
        Me.AssistsDataGridViewTextBoxColumn.DataPropertyName = "Assists"
        Me.AssistsDataGridViewTextBoxColumn.HeaderText = "Assists"
        Me.AssistsDataGridViewTextBoxColumn.Name = "AssistsDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'LossDataGridViewTextBoxColumn
        '
        Me.LossDataGridViewTextBoxColumn.DataPropertyName = "Loss"
        Me.LossDataGridViewTextBoxColumn.HeaderText = "Loss"
        Me.LossDataGridViewTextBoxColumn.Name = "LossDataGridViewTextBoxColumn"
        '
        'SacksDataGridViewTextBoxColumn
        '
        Me.SacksDataGridViewTextBoxColumn.DataPropertyName = "Sacks"
        Me.SacksDataGridViewTextBoxColumn.HeaderText = "Sacks"
        Me.SacksDataGridViewTextBoxColumn.Name = "SacksDataGridViewTextBoxColumn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(295, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(503, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Top 10 College Football Linebackers and their Statistics from the 2017 Season"
        '
        'LBForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 483)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "LBForm"
        Me.Text = "LBForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LinebackersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LBDataset As LBDataset
    Friend WithEvents LinebackersBindingSource As BindingSource
    Friend WithEvents LinebackersTableAdapter As LBDatasetTableAdapters.LinebackersTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SchoolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConferenceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GamesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoloTacklesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssistsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LossDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SacksDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
