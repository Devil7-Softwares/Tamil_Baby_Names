<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_InsertTamilLetters
    Inherits XtraFormTemp

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_InsertTamilLetters))
        Me.grp_Letters = New DevExpress.XtraEditors.GroupControl()
        Me.lst_Letters = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.btn_Insert = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grp_Letters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Letters.SuspendLayout()
        CType(Me.lst_Letters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_Letters
        '
        Me.grp_Letters.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Letters.Controls.Add(Me.lst_Letters)
        Me.grp_Letters.Location = New System.Drawing.Point(12, 12)
        Me.grp_Letters.Name = "grp_Letters"
        Me.grp_Letters.Size = New System.Drawing.Size(232, 217)
        Me.grp_Letters.TabIndex = 0
        Me.grp_Letters.Text = "Select Letters"
        '
        'lst_Letters
        '
        Me.lst_Letters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lst_Letters.Location = New System.Drawing.Point(2, 20)
        Me.lst_Letters.Name = "lst_Letters"
        Me.lst_Letters.Size = New System.Drawing.Size(228, 195)
        Me.lst_Letters.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.lst_Letters.TabIndex = 0
        '
        'btn_Insert
        '
        Me.btn_Insert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Insert.Location = New System.Drawing.Point(169, 235)
        Me.btn_Insert.Name = "btn_Insert"
        Me.btn_Insert.Size = New System.Drawing.Size(75, 23)
        Me.btn_Insert.TabIndex = 1
        Me.btn_Insert.Text = "Insert"
        '
        'frm_InsertTamilLetters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 270)
        Me.Controls.Add(Me.btn_Insert)
        Me.Controls.Add(Me.grp_Letters)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_InsertTamilLetters"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Insert Tamil Letters"
        CType(Me.grp_Letters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Letters.ResumeLayout(False)
        CType(Me.lst_Letters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grp_Letters As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_Insert As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lst_Letters As DevExpress.XtraEditors.CheckedListBoxControl
End Class
