<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.convertBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.mTOcm = New System.Windows.Forms.RadioButton()
        Me.cmTOm = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'convertBtn
        '
        Me.convertBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.convertBtn.Location = New System.Drawing.Point(348, 325)
        Me.convertBtn.Name = "convertBtn"
        Me.convertBtn.Size = New System.Drawing.Size(85, 58)
        Me.convertBtn.TabIndex = 0
        Me.convertBtn.Text = "Convert"
        Me.convertBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(123, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "value"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "result"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(158, 170)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(158, 272)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(146, 20)
        Me.TextBox2.TabIndex = 4
        '
        'mTOcm
        '
        Me.mTOcm.AutoSize = True
        Me.mTOcm.Location = New System.Drawing.Point(448, 210)
        Me.mTOcm.Name = "mTOcm"
        Me.mTOcm.Size = New System.Drawing.Size(120, 17)
        Me.mTOcm.TabIndex = 5
        Me.mTOcm.TabStop = True
        Me.mTOcm.Text = "meter to centimeter"
        Me.mTOcm.UseVisualStyleBackColor = True
        '
        'cmTOm
        '
        Me.cmTOm.AutoSize = True
        Me.cmTOm.Location = New System.Drawing.Point(448, 234)
        Me.cmTOm.Name = "cmTOm"
        Me.cmTOm.Size = New System.Drawing.Size(120, 17)
        Me.cmTOm.TabIndex = 6
        Me.cmTOm.TabStop = True
        Me.cmTOm.Text = "centimeter to meter"
        Me.cmTOm.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmTOm)
        Me.Controls.Add(Me.mTOcm)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.convertBtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents convertBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents mTOcm As RadioButton
    Friend WithEvents cmTOm As RadioButton
End Class
