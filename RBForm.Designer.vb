<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RBForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchoolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConfDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GamesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YdsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RunningbacksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TopCollegeProspectsDataSet = New Lpetelin_FinalProjectNFLDraft.TopCollegeProspectsDataSet()
        Me.RunningbacksTableAdapter = New Lpetelin_FinalProjectNFLDraft.TopCollegeProspectsDataSetTableAdapters.RunningbacksTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RunningbacksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopCollegeProspectsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(160, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(520, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Top 10 College Football Running backs and their Statistics from the 2017 Season"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.SchoolDataGridViewTextBoxColumn, Me.ConfDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.GamesDataGridViewTextBoxColumn, Me.AttDataGridViewTextBoxColumn, Me.YdsDataGridViewTextBoxColumn, Me.TDDataGridViewTextBoxColumn, Me.AvgDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RunningbacksBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(44, 82)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1032, 407)
        Me.DataGridView1.TabIndex = 3
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
        'ConfDataGridViewTextBoxColumn
        '
        Me.ConfDataGridViewTextBoxColumn.DataPropertyName = "Conf"
        Me.ConfDataGridViewTextBoxColumn.HeaderText = "Conf"
        Me.ConfDataGridViewTextBoxColumn.Name = "ConfDataGridViewTextBoxColumn"
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
        'AttDataGridViewTextBoxColumn
        '
        Me.AttDataGridViewTextBoxColumn.DataPropertyName = "Att"
        Me.AttDataGridViewTextBoxColumn.HeaderText = "Att"
        Me.AttDataGridViewTextBoxColumn.Name = "AttDataGridViewTextBoxColumn"
        '
        'YdsDataGridViewTextBoxColumn
        '
        Me.YdsDataGridViewTextBoxColumn.DataPropertyName = "Yds"
        Me.YdsDataGridViewTextBoxColumn.HeaderText = "Yds"
        Me.YdsDataGridViewTextBoxColumn.Name = "YdsDataGridViewTextBoxColumn"
        '
        'TDDataGridViewTextBoxColumn
        '
        Me.TDDataGridViewTextBoxColumn.DataPropertyName = "TD"
        Me.TDDataGridViewTextBoxColumn.HeaderText = "TD"
        Me.TDDataGridViewTextBoxColumn.Name = "TDDataGridViewTextBoxColumn"
        '
        'AvgDataGridViewTextBoxColumn
        '
        Me.AvgDataGridViewTextBoxColumn.DataPropertyName = "Avg"
        Me.AvgDataGridViewTextBoxColumn.HeaderText = "Avg"
        Me.AvgDataGridViewTextBoxColumn.Name = "AvgDataGridViewTextBoxColumn"
        '
        'RunningbacksBindingSource
        '
        Me.RunningbacksBindingSource.DataMember = "Runningbacks"
        Me.RunningbacksBindingSource.DataSource = Me.TopCollegeProspectsDataSet
        '
        'TopCollegeProspectsDataSet
        '
        Me.TopCollegeProspectsDataSet.DataSetName = "TopCollegeProspectsDataSet"
        Me.TopCollegeProspectsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RunningbacksTableAdapter
        '
        Me.RunningbacksTableAdapter.ClearBeforeFill = True
        '
        'RBForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 518)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RBForm"
        Me.Text = "Running backs"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RunningbacksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopCollegeProspectsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TopCollegeProspectsDataSet As TopCollegeProspectsDataSet
    Friend WithEvents RunningbacksBindingSource As BindingSource
    Friend WithEvents RunningbacksTableAdapter As TopCollegeProspectsDataSetTableAdapters.RunningbacksTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SchoolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConfDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GamesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YdsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AvgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
