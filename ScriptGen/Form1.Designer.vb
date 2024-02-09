<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GotifyServerTextBox = New System.Windows.Forms.TextBox()
        Me.GotifyPortTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.AppTokenTextBox = New System.Windows.Forms.TextBox()
        Me.PrimaryTokenTextBox = New System.Windows.Forms.TextBox()
        Me.GenerateScriptButton = New System.Windows.Forms.Button()
        Me.SaveScriptButton = New System.Windows.Forms.Button()
        Me.LoadScriptButton = New System.Windows.Forms.Button()
        Me.ScriptContentRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SaveValuesButton = New System.Windows.Forms.Button()
        Me.LoadValuesButton = New System.Windows.Forms.Button()
        Me.TimeDifferenceTextBox = New System.Windows.Forms.TextBox()
        Me.AppTokenCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GithubLabel = New System.Windows.Forms.LinkLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GotifyServerTextBox
        '
        Me.GotifyServerTextBox.Location = New System.Drawing.Point(103, 12)
        Me.GotifyServerTextBox.Name = "GotifyServerTextBox"
        Me.GotifyServerTextBox.Size = New System.Drawing.Size(190, 20)
        Me.GotifyServerTextBox.TabIndex = 0
        Me.GotifyServerTextBox.Text = "http://"
        '
        'GotifyPortTextBox
        '
        Me.GotifyPortTextBox.Location = New System.Drawing.Point(103, 38)
        Me.GotifyPortTextBox.Name = "GotifyPortTextBox"
        Me.GotifyPortTextBox.Size = New System.Drawing.Size(190, 20)
        Me.GotifyPortTextBox.TabIndex = 1
        Me.GotifyPortTextBox.Text = "80"
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(103, 64)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(190, 20)
        Me.CustomerNameTextBox.TabIndex = 2
        '
        'AppTokenTextBox
        '
        Me.AppTokenTextBox.Enabled = False
        Me.AppTokenTextBox.Location = New System.Drawing.Point(103, 116)
        Me.AppTokenTextBox.Name = "AppTokenTextBox"
        Me.AppTokenTextBox.Size = New System.Drawing.Size(190, 20)
        Me.AppTokenTextBox.TabIndex = 3
        '
        'PrimaryTokenTextBox
        '
        Me.PrimaryTokenTextBox.Location = New System.Drawing.Point(103, 90)
        Me.PrimaryTokenTextBox.Name = "PrimaryTokenTextBox"
        Me.PrimaryTokenTextBox.Size = New System.Drawing.Size(190, 20)
        Me.PrimaryTokenTextBox.TabIndex = 4
        '
        'GenerateScriptButton
        '
        Me.GenerateScriptButton.Enabled = False
        Me.GenerateScriptButton.Location = New System.Drawing.Point(201, 168)
        Me.GenerateScriptButton.Name = "GenerateScriptButton"
        Me.GenerateScriptButton.Size = New System.Drawing.Size(92, 23)
        Me.GenerateScriptButton.TabIndex = 5
        Me.GenerateScriptButton.Text = "GENERATE"
        Me.GenerateScriptButton.UseVisualStyleBackColor = True
        '
        'SaveScriptButton
        '
        Me.SaveScriptButton.Enabled = False
        Me.SaveScriptButton.Location = New System.Drawing.Point(102, 197)
        Me.SaveScriptButton.Name = "SaveScriptButton"
        Me.SaveScriptButton.Size = New System.Drawing.Size(191, 23)
        Me.SaveScriptButton.TabIndex = 7
        Me.SaveScriptButton.Text = "SAVE SCRIPT"
        Me.SaveScriptButton.UseVisualStyleBackColor = True
        '
        'LoadScriptButton
        '
        Me.LoadScriptButton.Location = New System.Drawing.Point(103, 168)
        Me.LoadScriptButton.Name = "LoadScriptButton"
        Me.LoadScriptButton.Size = New System.Drawing.Size(92, 23)
        Me.LoadScriptButton.TabIndex = 8
        Me.LoadScriptButton.Text = "LOAD SCRIPT"
        Me.LoadScriptButton.UseVisualStyleBackColor = True
        '
        'ScriptContentRichTextBox
        '
        Me.ScriptContentRichTextBox.Location = New System.Drawing.Point(299, 12)
        Me.ScriptContentRichTextBox.Name = "ScriptContentRichTextBox"
        Me.ScriptContentRichTextBox.ReadOnly = True
        Me.ScriptContentRichTextBox.Size = New System.Drawing.Size(659, 426)
        Me.ScriptContentRichTextBox.TabIndex = 9
        Me.ScriptContentRichTextBox.Text = "Please load script..."
        '
        'SaveValuesButton
        '
        Me.SaveValuesButton.Location = New System.Drawing.Point(201, 249)
        Me.SaveValuesButton.Name = "SaveValuesButton"
        Me.SaveValuesButton.Size = New System.Drawing.Size(92, 23)
        Me.SaveValuesButton.TabIndex = 10
        Me.SaveValuesButton.Text = "SAVE CONFIG"
        Me.SaveValuesButton.UseVisualStyleBackColor = True
        '
        'LoadValuesButton
        '
        Me.LoadValuesButton.Location = New System.Drawing.Point(103, 249)
        Me.LoadValuesButton.Name = "LoadValuesButton"
        Me.LoadValuesButton.Size = New System.Drawing.Size(92, 23)
        Me.LoadValuesButton.TabIndex = 11
        Me.LoadValuesButton.Text = "LOAD CONFIG"
        Me.LoadValuesButton.UseVisualStyleBackColor = True
        '
        'TimeDifferenceTextBox
        '
        Me.TimeDifferenceTextBox.Location = New System.Drawing.Point(103, 142)
        Me.TimeDifferenceTextBox.Name = "TimeDifferenceTextBox"
        Me.TimeDifferenceTextBox.Size = New System.Drawing.Size(190, 20)
        Me.TimeDifferenceTextBox.TabIndex = 12
        Me.TimeDifferenceTextBox.Text = "10"
        '
        'AppTokenCheckBox
        '
        Me.AppTokenCheckBox.AutoSize = True
        Me.AppTokenCheckBox.Location = New System.Drawing.Point(136, 226)
        Me.AppTokenCheckBox.Name = "AppTokenCheckBox"
        Me.AppTokenCheckBox.Size = New System.Drawing.Size(127, 17)
        Me.AppTokenCheckBox.TabIndex = 13
        Me.AppTokenCheckBox.Text = "Error/Warning Token"
        Me.AppTokenCheckBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "SERVER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "PORT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "TITLE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "ERROR TOKEN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "TOKEN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "LOG AGE CHECK"
        '
        'Logo
        '
        Me.Logo.BackgroundImage = Global.ScriptGen.My.Resources.Resources.lepre
        Me.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Logo.InitialImage = Nothing
        Me.Logo.Location = New System.Drawing.Point(6, 23)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(115, 114)
        Me.Logo.TabIndex = 20
        Me.Logo.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GithubLabel)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Logo)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 295)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(279, 143)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "About"
        '
        'GithubLabel
        '
        Me.GithubLabel.ActiveLinkColor = System.Drawing.Color.LightGreen
        Me.GithubLabel.AutoSize = True
        Me.GithubLabel.Cursor = System.Windows.Forms.Cursors.Default
        Me.GithubLabel.LinkColor = System.Drawing.Color.Green
        Me.GithubLabel.Location = New System.Drawing.Point(146, 62)
        Me.GithubLabel.Name = "GithubLabel"
        Me.GithubLabel.Size = New System.Drawing.Size(105, 13)
        Me.GithubLabel.TabIndex = 23
        Me.GithubLabel.TabStop = True
        Me.GithubLabel.Text = "github.com/Leproide"
        Me.GithubLabel.VisitedLinkColor = System.Drawing.Color.Green
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(137, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Released under GPL v.2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(127, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Veeam Gotify script generator"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AppTokenCheckBox)
        Me.Controls.Add(Me.TimeDifferenceTextBox)
        Me.Controls.Add(Me.LoadValuesButton)
        Me.Controls.Add(Me.SaveValuesButton)
        Me.Controls.Add(Me.ScriptContentRichTextBox)
        Me.Controls.Add(Me.LoadScriptButton)
        Me.Controls.Add(Me.SaveScriptButton)
        Me.Controls.Add(Me.GenerateScriptButton)
        Me.Controls.Add(Me.PrimaryTokenTextBox)
        Me.Controls.Add(Me.AppTokenTextBox)
        Me.Controls.Add(Me.CustomerNameTextBox)
        Me.Controls.Add(Me.GotifyPortTextBox)
        Me.Controls.Add(Me.GotifyServerTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Veeam Gotify script generator"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GotifyServerTextBox As TextBox
    Friend WithEvents GotifyPortTextBox As TextBox
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents AppTokenTextBox As TextBox
    Friend WithEvents PrimaryTokenTextBox As TextBox
    Friend WithEvents GenerateScriptButton As Button
    Friend WithEvents SaveScriptButton As Button
    Friend WithEvents LoadScriptButton As Button
    Friend WithEvents ScriptContentRichTextBox As RichTextBox
    Friend WithEvents SaveValuesButton As Button
    Friend WithEvents LoadValuesButton As Button
    Friend WithEvents TimeDifferenceTextBox As TextBox
    Friend WithEvents AppTokenCheckBox As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Logo As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GithubLabel As LinkLabel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
