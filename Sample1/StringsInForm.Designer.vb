<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StringsInForm
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
        Me.MainDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdCreateWhere = New System.Windows.Forms.Button()
        Me.contriesCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.contactsCheckedListBox = New System.Windows.Forms.CheckedListBox()
        CType(Me.MainDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainDataGridView
        '
        Me.MainDataGridView.AllowUserToAddRows = False
        Me.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MainDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainDataGridView.Location = New System.Drawing.Point(0, 172)
        Me.MainDataGridView.Name = "MainDataGridView"
        Me.MainDataGridView.Size = New System.Drawing.Size(691, 329)
        Me.MainDataGridView.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 501)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(691, 57)
        Me.Panel2.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdCreateWhere)
        Me.Panel1.Controls.Add(Me.contriesCheckedListBox)
        Me.Panel1.Controls.Add(Me.contactsCheckedListBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(691, 172)
        Me.Panel1.TabIndex = 9
        '
        'cmdCreateWhere
        '
        Me.cmdCreateWhere.Location = New System.Drawing.Point(428, 12)
        Me.cmdCreateWhere.Name = "cmdCreateWhere"
        Me.cmdCreateWhere.Size = New System.Drawing.Size(130, 23)
        Me.cmdCreateWhere.TabIndex = 6
        Me.cmdCreateWhere.Text = "Create where"
        Me.cmdCreateWhere.UseVisualStyleBackColor = True
        '
        'contriesCheckedListBox
        '
        Me.contriesCheckedListBox.FormattingEnabled = True
        Me.contriesCheckedListBox.Location = New System.Drawing.Point(12, 12)
        Me.contriesCheckedListBox.Name = "contriesCheckedListBox"
        Me.contriesCheckedListBox.Size = New System.Drawing.Size(192, 139)
        Me.contriesCheckedListBox.TabIndex = 1
        '
        'contactsCheckedListBox
        '
        Me.contactsCheckedListBox.FormattingEnabled = True
        Me.contactsCheckedListBox.Location = New System.Drawing.Point(230, 12)
        Me.contactsCheckedListBox.Name = "contactsCheckedListBox"
        Me.contactsCheckedListBox.Size = New System.Drawing.Size(192, 139)
        Me.contactsCheckedListBox.TabIndex = 0
        '
        'StringsInForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 558)
        Me.Controls.Add(Me.MainDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "StringsInForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StringsInForm"
        CType(Me.MainDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainDataGridView As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents contactsCheckedListBox As CheckedListBox
    Friend WithEvents contriesCheckedListBox As CheckedListBox
    Friend WithEvents cmdCreateWhere As Button
End Class
