<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Splash
    Inherits DevExpress.XtraSplashScreen.SplashScreen

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Splash))
        Me.pic_Devil7 = New DevExpress.XtraEditors.PictureEdit()
        Me.lbl_description = New DevExpress.XtraEditors.LabelControl()
        Me.progressBar = New DevExpress.XtraEditors.MarqueeProgressBarControl()
        Me.Theme = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.lbl_copyright = New DevExpress.XtraEditors.LabelControl()
        Me.pic_Devexpress = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.pic_Devil7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.progressBar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Devexpress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_Devil7
        '
        Me.pic_Devil7.Cursor = System.Windows.Forms.Cursors.Default
        Me.pic_Devil7.EditValue = CType(resources.GetObject("pic_Devil7.EditValue"), Object)
        Me.pic_Devil7.Location = New System.Drawing.Point(12, 12)
        Me.pic_Devil7.Name = "pic_Devil7"
        Me.pic_Devil7.Properties.AllowFocused = False
        Me.pic_Devil7.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pic_Devil7.Properties.Appearance.Options.UseBackColor = True
        Me.pic_Devil7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pic_Devil7.Properties.ShowMenu = False
        Me.pic_Devil7.Size = New System.Drawing.Size(426, 180)
        Me.pic_Devil7.TabIndex = 14
        '
        'lbl_description
        '
        Me.lbl_description.Location = New System.Drawing.Point(23, 206)
        Me.lbl_description.Name = "lbl_description"
        Me.lbl_description.Size = New System.Drawing.Size(50, 13)
        Me.lbl_description.TabIndex = 12
        Me.lbl_description.Text = "Starting..."
        '
        'progressBar
        '
        Me.progressBar.EditValue = 0
        Me.progressBar.Location = New System.Drawing.Point(23, 231)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(404, 12)
        Me.progressBar.TabIndex = 10
        '
        'lbl_copyright
        '
        Me.lbl_copyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lbl_copyright.Location = New System.Drawing.Point(23, 286)
        Me.lbl_copyright.Name = "lbl_copyright"
        Me.lbl_copyright.Size = New System.Drawing.Size(0, 13)
        Me.lbl_copyright.TabIndex = 11
        '
        'pic_Devexpress
        '
        Me.pic_Devexpress.Cursor = System.Windows.Forms.Cursors.Default
        Me.pic_Devexpress.EditValue = CType(resources.GetObject("pic_Devexpress.EditValue"), Object)
        Me.pic_Devexpress.Location = New System.Drawing.Point(278, 266)
        Me.pic_Devexpress.Name = "pic_Devexpress"
        Me.pic_Devexpress.Properties.AllowFocused = False
        Me.pic_Devexpress.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pic_Devexpress.Properties.Appearance.Options.UseBackColor = True
        Me.pic_Devexpress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pic_Devexpress.Properties.ShowMenu = False
        Me.pic_Devexpress.Size = New System.Drawing.Size(160, 48)
        Me.pic_Devexpress.TabIndex = 13
        '
        'frm_Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 320)
        Me.Controls.Add(Me.pic_Devil7)
        Me.Controls.Add(Me.pic_Devexpress)
        Me.Controls.Add(Me.lbl_description)
        Me.Controls.Add(Me.lbl_copyright)
        Me.Controls.Add(Me.progressBar)
        Me.Name = "frm_Splash"
        Me.Text = "Form1"
        CType(Me.pic_Devil7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.progressBar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Devexpress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents pic_Devil7 As DevExpress.XtraEditors.PictureEdit
    Private WithEvents lbl_description As DevExpress.XtraEditors.LabelControl
    Private WithEvents progressBar As DevExpress.XtraEditors.MarqueeProgressBarControl
    Friend WithEvents Theme As DevExpress.LookAndFeel.DefaultLookAndFeel
    Private WithEvents lbl_copyright As DevExpress.XtraEditors.LabelControl
    Private WithEvents pic_Devexpress As DevExpress.XtraEditors.PictureEdit
End Class
