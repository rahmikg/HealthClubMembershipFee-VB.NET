<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbSenior = New System.Windows.Forms.RadioButton()
        Me.rdbStudent = New System.Windows.Forms.RadioButton()
        Me.rdbChild = New System.Windows.Forms.RadioButton()
        Me.rdbStandardAdult = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbxPersonalTrainer = New System.Windows.Forms.CheckBox()
        Me.cbxKarate = New System.Windows.Forms.CheckBox()
        Me.cbxYoga = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtBoxMonths = New System.Windows.Forms.TextBox()
        Me.lblEnterMonths = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblMonthlyFee = New System.Windows.Forms.Label()
        Me.txtBoxMonthlyFee = New System.Windows.Forms.TextBox()
        Me.txtBoxTotal = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbSenior)
        Me.GroupBox1.Controls.Add(Me.rdbStudent)
        Me.GroupBox1.Controls.Add(Me.rdbChild)
        Me.GroupBox1.Controls.Add(Me.rdbStandardAdult)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(211, 154)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type of Membership"
        '
        'rdbSenior
        '
        Me.rdbSenior.AutoSize = True
        Me.rdbSenior.Location = New System.Drawing.Point(28, 109)
        Me.rdbSenior.Name = "rdbSenior"
        Me.rdbSenior.Size = New System.Drawing.Size(89, 17)
        Me.rdbSenior.TabIndex = 3
        Me.rdbSenior.TabStop = True
        Me.rdbSenior.Text = "Senior Citizen"
        Me.rdbSenior.UseVisualStyleBackColor = True
        '
        'rdbStudent
        '
        Me.rdbStudent.AutoSize = True
        Me.rdbStudent.Location = New System.Drawing.Point(28, 86)
        Me.rdbStudent.Name = "rdbStudent"
        Me.rdbStudent.Size = New System.Drawing.Size(68, 17)
        Me.rdbStudent.TabIndex = 2
        Me.rdbStudent.TabStop = True
        Me.rdbStudent.Text = "Stundent"
        Me.rdbStudent.UseVisualStyleBackColor = True
        '
        'rdbChild
        '
        Me.rdbChild.AutoSize = True
        Me.rdbChild.Location = New System.Drawing.Point(28, 63)
        Me.rdbChild.Name = "rdbChild"
        Me.rdbChild.Size = New System.Drawing.Size(120, 17)
        Me.rdbChild.TabIndex = 1
        Me.rdbChild.TabStop = True
        Me.rdbChild.Text = "Child (12 and under)"
        Me.rdbChild.UseVisualStyleBackColor = True
        '
        'rdbStandardAdult
        '
        Me.rdbStandardAdult.AutoSize = True
        Me.rdbStandardAdult.Location = New System.Drawing.Point(28, 40)
        Me.rdbStandardAdult.Name = "rdbStandardAdult"
        Me.rdbStandardAdult.Size = New System.Drawing.Size(95, 17)
        Me.rdbStandardAdult.TabIndex = 0
        Me.rdbStandardAdult.TabStop = True
        Me.rdbStandardAdult.Text = "Standard Adult"
        Me.rdbStandardAdult.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbxPersonalTrainer)
        Me.GroupBox2.Controls.Add(Me.cbxKarate)
        Me.GroupBox2.Controls.Add(Me.cbxYoga)
        Me.GroupBox2.Location = New System.Drawing.Point(247, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(211, 154)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options"
        '
        'cbxPersonalTrainer
        '
        Me.cbxPersonalTrainer.AutoSize = True
        Me.cbxPersonalTrainer.Location = New System.Drawing.Point(27, 87)
        Me.cbxPersonalTrainer.Name = "cbxPersonalTrainer"
        Me.cbxPersonalTrainer.Size = New System.Drawing.Size(103, 17)
        Me.cbxPersonalTrainer.TabIndex = 2
        Me.cbxPersonalTrainer.Text = "Personal Trainer"
        Me.cbxPersonalTrainer.UseVisualStyleBackColor = True
        '
        'cbxKarate
        '
        Me.cbxKarate.AutoSize = True
        Me.cbxKarate.Location = New System.Drawing.Point(27, 64)
        Me.cbxKarate.Name = "cbxKarate"
        Me.cbxKarate.Size = New System.Drawing.Size(57, 17)
        Me.cbxKarate.TabIndex = 1
        Me.cbxKarate.Text = "Karate"
        Me.cbxKarate.UseVisualStyleBackColor = True
        '
        'cbxYoga
        '
        Me.cbxYoga.AutoSize = True
        Me.cbxYoga.Location = New System.Drawing.Point(27, 40)
        Me.cbxYoga.Name = "cbxYoga"
        Me.cbxYoga.Size = New System.Drawing.Size(51, 17)
        Me.cbxYoga.TabIndex = 0
        Me.cbxYoga.Text = "Yoga"
        Me.cbxYoga.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtBoxMonths)
        Me.GroupBox3.Controls.Add(Me.lblEnterMonths)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 182)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(211, 145)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Membership Length"
        '
        'txtBoxMonths
        '
        Me.txtBoxMonths.Location = New System.Drawing.Point(48, 89)
        Me.txtBoxMonths.Name = "txtBoxMonths"
        Me.txtBoxMonths.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxMonths.TabIndex = 1
        '
        'lblEnterMonths
        '
        Me.lblEnterMonths.AutoSize = True
        Me.lblEnterMonths.Location = New System.Drawing.Point(25, 58)
        Me.lblEnterMonths.Name = "lblEnterMonths"
        Me.lblEnterMonths.Size = New System.Drawing.Size(140, 13)
        Me.lblEnterMonths.TabIndex = 0
        Me.lblEnterMonths.Text = "Enter the Number of Months"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblTotal)
        Me.GroupBox4.Controls.Add(Me.lblMonthlyFee)
        Me.GroupBox4.Controls.Add(Me.txtBoxMonthlyFee)
        Me.GroupBox4.Controls.Add(Me.txtBoxTotal)
        Me.GroupBox4.Location = New System.Drawing.Point(245, 182)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(211, 145)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Membership Fee"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(46, 96)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total:"
        '
        'lblMonthlyFee
        '
        Me.lblMonthlyFee.AutoSize = True
        Me.lblMonthlyFee.Location = New System.Drawing.Point(17, 58)
        Me.lblMonthlyFee.Name = "lblMonthlyFee"
        Me.lblMonthlyFee.Size = New System.Drawing.Size(68, 13)
        Me.lblMonthlyFee.TabIndex = 2
        Me.lblMonthlyFee.Text = "Monthly Fee:"
        '
        'txtBoxMonthlyFee
        '
        Me.txtBoxMonthlyFee.Location = New System.Drawing.Point(88, 51)
        Me.txtBoxMonthlyFee.Name = "txtBoxMonthlyFee"
        Me.txtBoxMonthlyFee.ReadOnly = True
        Me.txtBoxMonthlyFee.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxMonthlyFee.TabIndex = 2
        '
        'txtBoxTotal
        '
        Me.txtBoxTotal.Location = New System.Drawing.Point(88, 89)
        Me.txtBoxTotal.Name = "txtBoxTotal"
        Me.txtBoxTotal.ReadOnly = True
        Me.txtBoxTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxTotal.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(102, 364)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(195, 364)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(285, 364)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblStatusStrip
        '
        Me.lblStatusStrip.Location = New System.Drawing.Point(0, 430)
        Me.lblStatusStrip.Name = "lblStatusStrip"
        Me.lblStatusStrip.Size = New System.Drawing.Size(468, 22)
        Me.lblStatusStrip.TabIndex = 6
        Me.lblStatusStrip.Text = "StatusStrip1"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 452)
        Me.Controls.Add(Me.lblStatusStrip)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MainForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Membership Fee Calculator "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbSenior As System.Windows.Forms.RadioButton
    Friend WithEvents rdbStudent As System.Windows.Forms.RadioButton
    Friend WithEvents rdbChild As System.Windows.Forms.RadioButton
    Friend WithEvents rdbStandardAdult As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxPersonalTrainer As System.Windows.Forms.CheckBox
    Friend WithEvents cbxKarate As System.Windows.Forms.CheckBox
    Friend WithEvents cbxYoga As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBoxMonths As System.Windows.Forms.TextBox
    Friend WithEvents lblEnterMonths As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblMonthlyFee As System.Windows.Forms.Label
    Friend WithEvents txtBoxMonthlyFee As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblStatusStrip As System.Windows.Forms.StatusStrip

End Class
