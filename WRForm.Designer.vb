<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WRForm
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
        Me.WRDataset = New Lpetelin_FinalProjectNFLDraft.WRDataset()
        Me.WideReceiversBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Wide_ReceiversTableAdapter = New Lpetelin_FinalProjectNFLDraft.WRDatasetTableAdapters.Wide_ReceiversTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchoolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConferenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GamesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceptionsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YardsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AverageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WRDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WideReceiversBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.SchoolDataGridViewTextBoxColumn, Me.ConferenceDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.GamesDataGridViewTextBoxColumn, Me.ReceptionsDataGridViewTextBoxColumn, Me.YardsDataGridViewTextBoxColumn, Me.AverageDataGridViewTextBoxColumn, Me.TDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.WideReceiversBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(25, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(951, 430)
        Me.DataGridView1.TabIndex = 0
        '
        'WRDataset
        '
        Me.WRDataset.DataSetName = "WRDataset"
        Me.WRDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WideReceiversBindingSource
        '
        Me.WideReceiversBindingSource.DataMember = "Wide Receivers"
        Me.WideReceiversBindingSource.DataSource = Me.WRDataset
        '
        'Wide_ReceiversTableAdapter
        '
        Me.Wide_ReceiversTableAdapter.ClearBeforeFill = True
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
        'ReceptionsDataGridViewTextBoxColumn
        '
        Me.ReceptionsDataGridViewTextBoxColumn.DataPropertyName = "Receptions"
        Me.ReceptionsDataGridViewTextBoxColumn.HeaderText = "Receptions"
        Me.ReceptionsDataGridViewTextBoxColumn.Name = "ReceptionsDataGridViewTextBoxColumn"
        '
        'YardsDataGridViewTextBoxColumn
        '
        Me.YardsDataGridViewTextBoxColumn.DataPropertyName = "Yards"
        Me.YardsDataGridViewTextBoxColumn.HeaderText = "Yards"
        Me.YardsDataGridViewTextBoxColumn.Name = "YardsDataGridViewTextBoxColumn"
        '
        'AverageDataGridViewTextBoxColumn
        '
        Me.AverageDataGridViewTextBoxColumn.DataPropertyName = "Average"
        Me.AverageDataGridViewTextBoxColumn.HeaderText = "Average"
        Me.AverageDataGridViewTextBoxColumn.Name = "AverageDataGridViewTextBoxColumn"
        '
        'TDDataGridViewTextBoxColumn
        '
        Me.TDDataGridViewTextBoxColumn.DataPropertyName = "TD"
        Me.TDDataGridViewTextBoxColumn.HeaderText = "TD"
        Me.TDDataGridViewTextBoxColumn.Name = "TDDataGridViewTextBoxColumn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(241, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(525, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Top 10 College Football Wide Receivers and their Statistics from the 2017 Season"
        '
        'WRForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 505)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "WRForm"
        Me.Text = "WRForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WRDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WideReceiversBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents WRDataset As WRDataset
    Friend WithEvents WideReceiversBindingSource As BindingSource
    Friend WithEvents Wide_ReceiversTableAdapter As WRDatasetTableAdapters.Wide_ReceiversTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SchoolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConferenceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GamesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReceptionsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YardsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AverageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
