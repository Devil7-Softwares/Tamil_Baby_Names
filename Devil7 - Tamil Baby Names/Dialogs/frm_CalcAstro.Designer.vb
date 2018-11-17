<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CalcAstro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CalcAstro))
        Me.lbl_Date = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Time = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_BirthCity = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Date = New DevExpress.XtraEditors.DateEdit()
        Me.txt_Time = New DevExpress.XtraEditors.TimeEdit()
        Me.btn_OK = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_BirthCity = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lbl_DaylightSaving = New DevExpress.XtraEditors.LabelControl()
        Me.switch_DaylightSaving = New DevExpress.XtraEditors.ToggleSwitch()
        CType(Me.txt_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Time.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_BirthCity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.switch_DaylightSaving.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Date
        '
        Me.lbl_Date.Location = New System.Drawing.Point(25, 15)
        Me.lbl_Date.Name = "lbl_Date"
        Me.lbl_Date.Size = New System.Drawing.Size(68, 13)
        Me.lbl_Date.TabIndex = 0
        Me.lbl_Date.Text = "Date of Birth :"
        '
        'lbl_Time
        '
        Me.lbl_Time.Location = New System.Drawing.Point(26, 41)
        Me.lbl_Time.Name = "lbl_Time"
        Me.lbl_Time.Size = New System.Drawing.Size(67, 13)
        Me.lbl_Time.TabIndex = 1
        Me.lbl_Time.Text = "Time of Birth :"
        '
        'lbl_BirthCity
        '
        Me.lbl_BirthCity.Location = New System.Drawing.Point(42, 67)
        Me.lbl_BirthCity.Name = "lbl_BirthCity"
        Me.lbl_BirthCity.Size = New System.Drawing.Size(51, 13)
        Me.lbl_BirthCity.TabIndex = 2
        Me.lbl_BirthCity.Text = "Birth City :"
        '
        'txt_Date
        '
        Me.txt_Date.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Date.EditValue = Nothing
        Me.txt_Date.Location = New System.Drawing.Point(99, 12)
        Me.txt_Date.Name = "txt_Date"
        Me.txt_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Date.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txt_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_Date.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.txt_Date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txt_Date.Size = New System.Drawing.Size(244, 20)
        Me.txt_Date.TabIndex = 3
        '
        'txt_Time
        '
        Me.txt_Time.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Time.EditValue = New Date(2018, 11, 16, 0, 0, 0, 0)
        Me.txt_Time.Location = New System.Drawing.Point(99, 38)
        Me.txt_Time.Name = "txt_Time"
        Me.txt_Time.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Time.Size = New System.Drawing.Size(244, 20)
        Me.txt_Time.TabIndex = 4
        '
        'btn_OK
        '
        Me.btn_OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_OK.Location = New System.Drawing.Point(268, 119)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(75, 23)
        Me.btn_OK.TabIndex = 6
        Me.btn_OK.Text = "OK"
        '
        'txt_BirthCity
        '
        Me.txt_BirthCity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_BirthCity.Location = New System.Drawing.Point(99, 64)
        Me.txt_BirthCity.Name = "txt_BirthCity"
        Me.txt_BirthCity.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_BirthCity.Size = New System.Drawing.Size(244, 20)
        Me.txt_BirthCity.TabIndex = 7
        '
        'lbl_DaylightSaving
        '
        Me.lbl_DaylightSaving.Location = New System.Drawing.Point(12, 95)
        Me.lbl_DaylightSaving.Name = "lbl_DaylightSaving"
        Me.lbl_DaylightSaving.Size = New System.Drawing.Size(81, 13)
        Me.lbl_DaylightSaving.TabIndex = 8
        Me.lbl_DaylightSaving.Text = "Daylight Saving :"
        '
        'switch_DaylightSaving
        '
        Me.switch_DaylightSaving.Location = New System.Drawing.Point(99, 90)
        Me.switch_DaylightSaving.Name = "switch_DaylightSaving"
        Me.switch_DaylightSaving.Properties.OffText = "Off"
        Me.switch_DaylightSaving.Properties.OnText = "On"
        Me.switch_DaylightSaving.Size = New System.Drawing.Size(95, 24)
        Me.switch_DaylightSaving.TabIndex = 9
        '
        'frm_CalcAstro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 154)
        Me.Controls.Add(Me.switch_DaylightSaving)
        Me.Controls.Add(Me.lbl_DaylightSaving)
        Me.Controls.Add(Me.txt_BirthCity)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.txt_Time)
        Me.Controls.Add(Me.txt_Date)
        Me.Controls.Add(Me.lbl_BirthCity)
        Me.Controls.Add(Me.lbl_Time)
        Me.Controls.Add(Me.lbl_Date)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_CalcAstro"
        Me.Text = "Calculate Nakshatra & Rashi"
        CType(Me.txt_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Time.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_BirthCity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.switch_DaylightSaving.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Date As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Time As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_BirthCity As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_Time As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents btn_OK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_BirthCity As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lbl_DaylightSaving As DevExpress.XtraEditors.LabelControl
    Friend WithEvents switch_DaylightSaving As DevExpress.XtraEditors.ToggleSwitch
End Class
