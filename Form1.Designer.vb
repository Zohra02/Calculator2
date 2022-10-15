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
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnMOD = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(46, 380)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(90, 47)
        Me.btnadd.TabIndex = 0
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Location = New System.Drawing.Point(159, 380)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(90, 47)
        Me.btnSubtract.TabIndex = 1
        Me.btnSubtract.Text = "Subtract"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(276, 380)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(90, 47)
        Me.btnMultiply.TabIndex = 2
        Me.btnMultiply.Text = "Multiply"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(389, 380)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(90, 47)
        Me.btnDivide.TabIndex = 3
        Me.btnDivide.Text = "Divide"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnMOD
        '
        Me.btnMOD.Location = New System.Drawing.Point(509, 380)
        Me.btnMOD.Name = "btnMOD"
        Me.btnMOD.Size = New System.Drawing.Size(90, 47)
        Me.btnMOD.TabIndex = 4
        Me.btnMOD.Text = "MOD"
        Me.btnMOD.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Coral
        Me.Label1.Location = New System.Drawing.Point(59, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter First Number :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Coral
        Me.Label2.Location = New System.Drawing.Point(59, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter Second Number :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Coral
        Me.Label3.Location = New System.Drawing.Point(59, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "TOTAL :"
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(310, 87)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(202, 20)
        Me.txtNum1.TabIndex = 8
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(310, 154)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(202, 20)
        Me.txtNum2.TabIndex = 9
        '
        'txtResult
        '
        Me.txtResult.Enabled = False
        Me.txtResult.Location = New System.Drawing.Point(214, 225)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(298, 20)
        Me.txtResult.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMOD)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnadd)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnadd As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnMOD As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents txtResult As TextBox
End Class
