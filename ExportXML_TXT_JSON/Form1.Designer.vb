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
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.ageLabel = New System.Windows.Forms.Label()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.ageBox = New System.Windows.Forms.TextBox()
        Me.addressBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.displayBox = New System.Windows.Forms.TextBox()
        Me.display = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(41, 52)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(69, 25)
        Me.nameLabel.TabIndex = 0
        Me.nameLabel.Text = "Name:"
        '
        'ageLabel
        '
        Me.ageLabel.AutoSize = True
        Me.ageLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ageLabel.Location = New System.Drawing.Point(58, 108)
        Me.ageLabel.Name = "ageLabel"
        Me.ageLabel.Size = New System.Drawing.Size(52, 25)
        Me.ageLabel.TabIndex = 1
        Me.ageLabel.Text = "Age:"
        '
        'addressLabel
        '
        Me.addressLabel.AutoSize = True
        Me.addressLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressLabel.Location = New System.Drawing.Point(24, 158)
        Me.addressLabel.Name = "addressLabel"
        Me.addressLabel.Size = New System.Drawing.Size(88, 25)
        Me.addressLabel.TabIndex = 2
        Me.addressLabel.Text = "Address:"
        '
        'nameBox
        '
        Me.nameBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameBox.Location = New System.Drawing.Point(113, 48)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(299, 29)
        Me.nameBox.TabIndex = 3
        '
        'ageBox
        '
        Me.ageBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ageBox.Location = New System.Drawing.Point(113, 100)
        Me.ageBox.Name = "ageBox"
        Me.ageBox.Size = New System.Drawing.Size(299, 29)
        Me.ageBox.TabIndex = 4
        '
        'addressBox
        '
        Me.addressBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressBox.Location = New System.Drawing.Point(113, 154)
        Me.addressBox.Name = "addressBox"
        Me.addressBox.Size = New System.Drawing.Size(299, 29)
        Me.addressBox.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(76, 204)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 42)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Text"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(185, 204)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 42)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "XML"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(294, 204)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 42)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "JSON"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'displayBox
        '
        Me.displayBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayBox.Location = New System.Drawing.Point(418, 48)
        Me.displayBox.Multiline = True
        Me.displayBox.Name = "displayBox"
        Me.displayBox.ReadOnly = True
        Me.displayBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.displayBox.Size = New System.Drawing.Size(280, 135)
        Me.displayBox.TabIndex = 9
        '
        'display
        '
        Me.display.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.display.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.display.Location = New System.Drawing.Point(452, 204)
        Me.display.Name = "display"
        Me.display.Size = New System.Drawing.Size(129, 42)
        Me.display.TabIndex = 10
        Me.display.Text = "Display Text"
        Me.display.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(710, 335)
        Me.Controls.Add(Me.display)
        Me.Controls.Add(Me.displayBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.addressBox)
        Me.Controls.Add(Me.ageBox)
        Me.Controls.Add(Me.nameBox)
        Me.Controls.Add(Me.addressLabel)
        Me.Controls.Add(Me.ageLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Homework 3"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nameLabel As Label
    Friend WithEvents ageLabel As Label
    Friend WithEvents addressLabel As Label
    Friend WithEvents nameBox As TextBox
    Friend WithEvents ageBox As TextBox
    Friend WithEvents addressBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents displayBox As TextBox
    Friend WithEvents display As Button
End Class
