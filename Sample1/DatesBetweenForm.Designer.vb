<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatesBetweenForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmdAddNewItem = New System.Windows.Forms.Button()
        Me.cmdRemoveCurrentItem = New System.Windows.Forms.Button()
        Me.CalendarColumn1 = New Sample1.Classes.CalendarColumn()
        Me.CalendarColumn2 = New Sample1.Classes.CalendarColumn()
        Me.cmdCreateWhere = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MainDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.ProcessColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColumnNameColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.StartDateColumn = New Sample1.Classes.CalendarColumn()
        Me.EndDateColumn = New Sample1.Classes.CalendarColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.MainDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProcessColumn, Me.ColumnNameColumn, Me.StartDateColumn, Me.EndDateColumn})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(509, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'cmdAddNewItem
        '
        Me.cmdAddNewItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAddNewItem.Location = New System.Drawing.Point(549, 42)
        Me.cmdAddNewItem.Name = "cmdAddNewItem"
        Me.cmdAddNewItem.Size = New System.Drawing.Size(130, 23)
        Me.cmdAddNewItem.TabIndex = 3
        Me.cmdAddNewItem.Text = "Add"
        Me.cmdAddNewItem.UseVisualStyleBackColor = True
        '
        'cmdRemoveCurrentItem
        '
        Me.cmdRemoveCurrentItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRemoveCurrentItem.Location = New System.Drawing.Point(549, 71)
        Me.cmdRemoveCurrentItem.Name = "cmdRemoveCurrentItem"
        Me.cmdRemoveCurrentItem.Size = New System.Drawing.Size(130, 23)
        Me.cmdRemoveCurrentItem.TabIndex = 4
        Me.cmdRemoveCurrentItem.Text = "Remove"
        Me.cmdRemoveCurrentItem.UseVisualStyleBackColor = True
        '
        'CalendarColumn1
        '
        Me.CalendarColumn1.DataPropertyName = "StartRange"
        Me.CalendarColumn1.HeaderText = "Start"
        Me.CalendarColumn1.Name = "CalendarColumn1"
        '
        'CalendarColumn2
        '
        Me.CalendarColumn2.DataPropertyName = "EndRange"
        Me.CalendarColumn2.HeaderText = "End"
        Me.CalendarColumn2.Name = "CalendarColumn2"
        '
        'cmdCreateWhere
        '
        Me.cmdCreateWhere.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCreateWhere.Location = New System.Drawing.Point(549, 100)
        Me.cmdCreateWhere.Name = "cmdCreateWhere"
        Me.cmdCreateWhere.Size = New System.Drawing.Size(130, 23)
        Me.cmdCreateWhere.TabIndex = 5
        Me.cmdCreateWhere.Text = "Create where"
        Me.cmdCreateWhere.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.cmdCreateWhere)
        Me.Panel1.Controls.Add(Me.cmdAddNewItem)
        Me.Panel1.Controls.Add(Me.cmdRemoveCurrentItem)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(691, 172)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblCount)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 505)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(691, 57)
        Me.Panel2.TabIndex = 7
        '
        'MainDataGridView
        '
        Me.MainDataGridView.AllowUserToAddRows = False
        Me.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MainDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainDataGridView.Location = New System.Drawing.Point(0, 172)
        Me.MainDataGridView.Name = "MainDataGridView"
        Me.MainDataGridView.Size = New System.Drawing.Size(691, 333)
        Me.MainDataGridView.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Count"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(51, 15)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(13, 13)
        Me.lblCount.TabIndex = 1
        Me.lblCount.Text = "0"
        '
        'ProcessColumn
        '
        Me.ProcessColumn.DataPropertyName = "Process"
        Me.ProcessColumn.HeaderText = "Use"
        Me.ProcessColumn.Name = "ProcessColumn"
        '
        'ColumnNameColumn
        '
        Me.ColumnNameColumn.DataPropertyName = "ColumnName"
        Me.ColumnNameColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.ColumnNameColumn.HeaderText = "Field"
        Me.ColumnNameColumn.Name = "ColumnNameColumn"
        '
        'StartDateColumn
        '
        Me.StartDateColumn.DataPropertyName = "StartRange"
        Me.StartDateColumn.HeaderText = "Start range"
        Me.StartDateColumn.Name = "StartDateColumn"
        '
        'EndDateColumn
        '
        Me.EndDateColumn.DataPropertyName = "EndRange"
        Me.EndDateColumn.HeaderText = "End range"
        Me.EndDateColumn.Name = "EndDateColumn"
        '
        'DatesBetweenForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 562)
        Me.Controls.Add(Me.MainDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "DatesBetweenForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dates between code sample"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.MainDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmdAddNewItem As Button
    Friend WithEvents cmdRemoveCurrentItem As Button
    Friend WithEvents CalendarColumn1 As Classes.CalendarColumn
    Friend WithEvents CalendarColumn2 As Classes.CalendarColumn
    Friend WithEvents cmdCreateWhere As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MainDataGridView As DataGridView
    Friend WithEvents lblCount As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ProcessColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ColumnNameColumn As DataGridViewComboBoxColumn
    Friend WithEvents StartDateColumn As Classes.CalendarColumn
    Friend WithEvents EndDateColumn As Classes.CalendarColumn
End Class
