<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DBForm
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
        Me.DBDataset = New Lpetelin_FinalProjectNFLDraft.DBDataset()
        Me.DefensiveBacksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Defensive_BacksTableAdapter = New Lpetelin_FinalProjectNFLDraft.DBDatasetTableAdapters.Defensive_BacksTableAdapter()
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
        Me.InterceptionsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefensiveBacksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.SchoolDataGridViewTextBoxColumn, Me.ConferenceDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.GamesDataGridViewTextBoxColumn, Me.SoloTacklesDataGridViewTextBoxColumn, Me.AssistsDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.InterceptionsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DefensiveBacksBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 50)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1109, 433)
        Me.DataGridView1.TabIndex = 0
        '
        'DBDataset
        '
        Me.DBDataset.DataSetName = "DBDataset"
        Me.DBDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DefensiveBacksBindingSource
        '
        Me.DefensiveBacksBindingSource.DataMember = "Defensive Backs"
        Me.DefensiveBacksBindingSource.DataSource = Me.DBDataset
        '
        'Defensive_BacksTableAdapter
        '
        Me.Defensive_BacksTableAdapter.ClearBeforeFill = True
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
        'InterceptionsDataGridViewTextBoxColumn
        '
        Me.InterceptionsDataGridViewTextBoxColumn.DataPropertyName = "Interceptions"
        Me.InterceptionsDataGridViewTextBoxColumn.HeaderText = "Interceptions"
        Me.InterceptionsDataGridViewTextBoxColumn.Name = "InterceptionsDataGridViewTextBoxColumn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(315, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(531, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Top 10 College Football Defensive Backs and their Statistics from the 2017 Season" &
    ""
        '
        'DBForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1171, 503)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "DBForm"
        Me.Text = "DBForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefensiveBacksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DBDataset As DBDataset
    Friend WithEvents DefensiveBacksBindingSource As BindingSource
    Friend WithEvents Defensive_BacksTableAdapter As DBDatasetTableAdapters.Defensive_BacksTableAdapter
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
    Friend WithEvents InterceptionsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
