<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHelloTest
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnHello = New MaterialSkin.Controls.MaterialButton()
        Me.tbFirstName = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbLastName = New MaterialSkin.Controls.MaterialTextBox()
        Me.SuspendLayout()
        '
        'btnHello
        '
        Me.btnHello.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHello.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnHello.Depth = 0
        Me.btnHello.HighEmphasis = True
        Me.btnHello.Icon = Nothing
        Me.btnHello.Location = New System.Drawing.Point(292, 146)
        Me.btnHello.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnHello.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnHello.Name = "btnHello"
        Me.btnHello.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnHello.Size = New System.Drawing.Size(98, 36)
        Me.btnHello.TabIndex = 0
        Me.btnHello.Text = "Say Hello"
        Me.btnHello.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnHello.UseAccentColor = False
        Me.btnHello.UseVisualStyleBackColor = True
        '
        'tbFirstName
        '
        Me.tbFirstName.AnimateReadOnly = False
        Me.tbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbFirstName.Depth = 0
        Me.tbFirstName.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tbFirstName.LeadingIcon = Nothing
        Me.tbFirstName.Location = New System.Drawing.Point(102, 76)
        Me.tbFirstName.MaxLength = 50
        Me.tbFirstName.MouseState = MaterialSkin.MouseState.OUT
        Me.tbFirstName.Multiline = False
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(165, 50)
        Me.tbFirstName.TabIndex = 1
        Me.tbFirstName.Text = ""
        Me.tbFirstName.TrailingIcon = Nothing
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(14, 78)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(82, 19)
        Me.MaterialLabel1.TabIndex = 2
        Me.MaterialLabel1.Text = "First Name:"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.Location = New System.Drawing.Point(14, 134)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(82, 19)
        Me.MaterialLabel2.TabIndex = 4
        Me.MaterialLabel2.Text = "Last Name:"
        '
        'tbLastName
        '
        Me.tbLastName.AnimateReadOnly = False
        Me.tbLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbLastName.Depth = 0
        Me.tbLastName.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.tbLastName.LeadingIcon = Nothing
        Me.tbLastName.Location = New System.Drawing.Point(102, 132)
        Me.tbLastName.MaxLength = 50
        Me.tbLastName.MouseState = MaterialSkin.MouseState.OUT
        Me.tbLastName.Multiline = False
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(165, 50)
        Me.tbLastName.TabIndex = 3
        Me.tbLastName.Text = ""
        Me.tbLastName.TrailingIcon = Nothing
        '
        'frmHelloTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 200)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.tbLastName)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.tbFirstName)
        Me.Controls.Add(Me.btnHello)
        Me.Name = "frmHelloTest"
        Me.Text = "Material Hello Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHello As MaterialSkin.Controls.MaterialButton
    Friend WithEvents tbFirstName As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbLastName As MaterialSkin.Controls.MaterialTextBox
End Class
