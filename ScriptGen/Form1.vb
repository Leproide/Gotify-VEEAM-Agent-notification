Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Text.RegularExpressions

Public Class Form1

    Private scriptEncoding As Encoding ' Encoding del file dello script caricato

    Private Sub LoadScriptButton_Click(sender As Object, e As EventArgs) Handles LoadScriptButton.Click
        Try
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "File di script PowerShell (*.ps1)|*.ps1"
            openFileDialog.Title = "Seleziona lo script PowerShell"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Leggi il contenuto dello script dal file selezionato
                Dim scriptPath As String = openFileDialog.FileName
                scriptEncoding = GetFileEncoding(scriptPath)
                Dim scriptContent As String = File.ReadAllText(scriptPath, scriptEncoding)

                ' Visualizza lo script caricato nella RichTextBox
                ScriptContentRichTextBox.Text = scriptContent

                ' Abilita il pulsante di generazione solo se il contenuto non contiene "Please load script..."
                GenerateScriptButton.Enabled = Not ScriptContentRichTextBox.Text.Contains("Please load script...")
            End If
        Catch ex As Exception
            MessageBox.Show("Si è verificato un errore durante il caricamento dello script:" & ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GenerateScriptButton_Click(sender As Object, e As EventArgs) Handles GenerateScriptButton.Click
        Try
            ' Ottieni i valori inseriti dall'utente
            Dim gotifyServer As String = GotifyServerTextBox.Text
            Dim gotifyPort As String = GotifyPortTextBox.Text
            Dim customerName As String = CustomerNameTextBox.Text
            Dim appToken As String = If(AppTokenCheckBox.Checked, AppTokenTextBox.Text, "APP TOKEN FOR FAILED AND WARNING")
            Dim primaryToken As String = PrimaryTokenTextBox.Text
            Dim timeDifference As String = TimeDifferenceTextBox.Text

            ' Ottieni lo script caricato dalla RichTextBox
            Dim scriptContent As String = ScriptContentRichTextBox.Text

            ' Sostituisci i valori nel file dello script con quelli inseriti dall'utente
            scriptContent = Regex.Replace(scriptContent, "(?<=\$GotifyServer = "").*?(?="")", gotifyServer)
            scriptContent = Regex.Replace(scriptContent, "(?<=\$GotifyPort = "").*?(?="")", gotifyPort)
            scriptContent = Regex.Replace(scriptContent, "(?<=title = "").*?(?="")", customerName)
            scriptContent = Regex.Replace(scriptContent, "(?<=Send-Gotify -Message \$MessageToSend -Token "").*?(?="")", primaryToken)
            scriptContent = Regex.Replace(scriptContent, "(?<=Send-Gotify -Message ""\$CustomString`r`n\$EventTimeString`r`n\$Message"" -Token "").*?(?="")", appToken)
            scriptContent = Regex.Replace(scriptContent, "(?<=\$TimeDifference.TotalMinutes -gt )\d+", timeDifference)

            ' Visualizza lo script generato nella RichTextBox
            ScriptContentRichTextBox.Text = scriptContent

            ' Disabilita la casella di testo del token se la casella di controllo non è selezionata
            AppTokenTextBox.Enabled = AppTokenCheckBox.Checked

            ' Abilita il pulsante di salvataggio dello script
            SaveScriptButton.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Si è verificato un errore durante la generazione dello script:" & ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadValuesButton_Click(sender As Object, e As EventArgs) Handles LoadValuesButton.Click
        Try
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "File XML (*.xml)|*.xml"
            openFileDialog.Title = "Carica la configurazione"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = openFileDialog.FileName
                Dim xmlDoc As New XmlDocument()
                xmlDoc.Load(filePath)

                GotifyServerTextBox.Text = GetNodeValue(xmlDoc, "GotifyServer")
                GotifyPortTextBox.Text = GetNodeValue(xmlDoc, "GotifyPort")
                CustomerNameTextBox.Text = GetNodeValue(xmlDoc, "CustomerName")
                AppTokenTextBox.Text = GetNodeValue(xmlDoc, "AppToken")
                PrimaryTokenTextBox.Text = GetNodeValue(xmlDoc, "PrimaryToken")
                TimeDifferenceTextBox.Text = GetNodeValue(xmlDoc, "TimeDifference")

                MessageBox.Show("I valori sono stati caricati correttamente.", "Caricamento completato", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Si è verificato un errore durante il caricamento dei valori:" & ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SaveValuesButton_Click(sender As Object, e As EventArgs) Handles SaveValuesButton.Click
        Try
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "File XML (*.xml)|*.xml"
            saveFileDialog.Title = "Salva la configurazione"
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = saveFileDialog.FileName
                Dim xmlDoc As New XmlDocument()
                Dim xmlDeclaration As XmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", Nothing)
                xmlDoc.AppendChild(xmlDeclaration)

                Dim rootNode As XmlNode = xmlDoc.CreateElement("Config")
                xmlDoc.AppendChild(rootNode)

                AddNode(xmlDoc, rootNode, "GotifyServer", GotifyServerTextBox.Text)
                AddNode(xmlDoc, rootNode, "GotifyPort", GotifyPortTextBox.Text)
                AddNode(xmlDoc, rootNode, "CustomerName", CustomerNameTextBox.Text)
                AddNode(xmlDoc, rootNode, "AppToken", AppTokenTextBox.Text)
                AddNode(xmlDoc, rootNode, "PrimaryToken", PrimaryTokenTextBox.Text)
                AddNode(xmlDoc, rootNode, "TimeDifference", TimeDifferenceTextBox.Text)

                xmlDoc.Save(filePath)
                MessageBox.Show("I valori sono stati salvati correttamente.", "Salvataggio completato", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Si è verificato un errore durante il salvataggio dei valori:" & ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetNodeValue(xmlDoc As XmlDocument, nodeName As String) As String
        Dim node As XmlNode = xmlDoc.SelectSingleNode($"//Config/{nodeName}")
        If node IsNot Nothing Then
            Return node.InnerText
        End If
        Return ""
    End Function

    Private Sub AddNode(xmlDoc As XmlDocument, parentNode As XmlNode, nodeName As String, nodeValue As String)
        Dim node As XmlNode = xmlDoc.CreateElement(nodeName)
        node.InnerText = nodeValue
        parentNode.AppendChild(node)
    End Sub


    Private Sub AppTokenCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles AppTokenCheckBox.CheckedChanged
        ' Abilita/disabilita la casella di testo del token in base allo stato della casella di controllo
        AppTokenTextBox.Enabled = AppTokenCheckBox.Checked
    End Sub

    Private Sub SaveScriptButton_Click(sender As Object, e As EventArgs) Handles SaveScriptButton.Click
        Try
            ' Salva lo script in un file con lo stesso encoding del file caricato
            Using saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "File di script PowerShell (*.ps1)|*.ps1"
                saveFileDialog.Title = "Salva lo script PowerShell"
                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    Dim filePath As String = saveFileDialog.FileName
                    File.WriteAllText(filePath, ScriptContentRichTextBox.Text, scriptEncoding)
                    MessageBox.Show("Lo script è stato salvato correttamente.", "Salvataggio completato", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Si è verificato un errore durante il salvataggio dello script:" & ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetFileEncoding(filePath As String) As Encoding
        Using reader As New StreamReader(filePath, True)
            reader.Peek() ' Legge un carattere per determinare l'encoding
            Return reader.CurrentEncoding
        End Using
    End Function

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GithubLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GithubLabel.LinkClicked
        Process.Start("https://github.com/Leproide")
    End Sub

    Private Sub AppTokenTextBox_TextChanged(sender As Object, e As EventArgs) Handles AppTokenTextBox.TextChanged
        AppTokenCheckBox.Checked = True
    End Sub
End Class
