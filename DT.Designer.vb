<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DT
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DTDataset = New Lpetelin_FinalProjectNFLDraft.DTDataset()
        Me.DefensiveTacklesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Defensive_TacklesTableAdapter = New Lpetelin_FinalProjectNFLDraft.DTDatasetTableAdapters.Defensive_TacklesTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchoolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GamesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoloTacklesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssistsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LossDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SacksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefensiveTacklesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(171, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(542, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Top 10 College Football Defensive Tackles and their Statistics from the 2017 Seas" &
    "on"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.SchoolDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.GamesDataGridViewTextBoxColumn, Me.SoloTacklesDataGridViewTextBoxColumn, Me.AssistsDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.LossDataGridViewTextBoxColumn, Me.SacksDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DefensiveTacklesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 78)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(904, 296)
        Me.DataGridView1.TabIndex = 3
        '
        'DTDataset
        '
        Me.DTDataset.DataSetName = "DTDataset"
        Me.DTDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DefensiveTacklesBindingSource
        '
        Me.DefensiveTacklesBindingSource.DataMember = "Defensive Tackles"
        Me.DefensiveTacklesBindingSource.DataSource = Me.DTDataset
        '
        'Defensive_TacklesTableAdapter
        '
        Me.Defensive_TacklesTableAdapter.ClearBeforeFill = True
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
        'DT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 386)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DT"
        Me.Text = "Defensive Tackles"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefensiveTacklesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents QBDatasetBindingSource As BindingSource
    Friend WithEvents QBDataset As QBDataset
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DTDataset As DTDataset
    Friend WithEvents DefensiveTacklesBindingSource As BindingSource
    Friend WithEvents Defensive_TacklesTableAdapter As DTDatasetTableAdapters.Defensive_TacklesTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SchoolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GamesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoloTacklesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssistsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LossDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SacksDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
