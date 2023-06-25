Imports System.Net
Imports System.IO
Imports Newtonsoft.Json.Linq

Public Class Form1
    Dim apiUrl As String

    Private Sub btnCek_Click(sender As Object, e As EventArgs) Handles btnCek.Click
        Dim userId = txtUser.Text
        Dim zoneId = txtZone.Text
        Dim server = cmbServer.Text

        If cmbGame.Text = "MOBILE LEGENDS" Then
            apiUrl = "https://api.vocagame.com/v1/order/prepare/MOBILE_LEGENDS?userId=" & userId & "&zoneId=" & zoneId

        ElseIf cmbGame.Text = "FREE FIRE" Then
            apiUrl = "https://api.vocagame.com/v1/order/prepare/FREEFIRE?userId=" & userId

        ElseIf cmbGame.Text = "PUBG MOBILE" Then
            apiUrl = "https://api.vocagame.com/v1/order/prepare/PUBG_ID?userId=" & userId

        ElseIf cmbGame.Text = "SAUSAGE MAN" Then
            apiUrl = "https://api.vocagame.com/v1/order/prepare/SAUSAGE_MAN?userId=" & userId

        ElseIf cmbGame.Text = "GENSHIN IMPACT" Then
            apiUrl = "https://api.vocagame.com/v1/order/prepare/GENSHIN_IMPACT?userId=" & userId & "&zoneId=" & server

        ElseIf cmbGame.Text = "POINT BLANK" Then
            apiUrl = "https://api.vocagame.com/v1/order/prepare/POINT_BLANK?userId=" & userId

        End If
        Try
            Dim request As WebRequest = WebRequest.Create(apiUrl)
            Dim response As WebResponse = request.GetResponse()

            Using reader As New StreamReader(response.GetResponseStream())
                Dim jsonResponse As String = reader.ReadToEnd()
                Dim data As JObject = JObject.Parse(jsonResponse)

                Dim message As String = data("message").ToString()
                Dim username As String = data("data").ToString()

                MessageBox.Show("Response Message: " & message & vbCrLf & "Username: " & username)
            End Using
        Catch ex As Exception
            MessageBox.Show("User Id atau Zone Id Salah, Mohon periksa kembali. .")
        End Try
    End Sub

    Private Sub cmbGame_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGame.SelectedIndexChanged
        If cmbGame.Text = "MOBILE LEGENDS" Then
            txtUser.Visible = True
            txtZone.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label4.Visible = False
            cmbServer.Visible = False
        ElseIf cmbGame.Text = "FREE FIRE" Then
            txtUser.Visible = True
            txtZone.Visible = False
            Label1.Visible = True
            Label2.Visible = False
            Label4.Visible = False
            cmbServer.Visible = False
        ElseIf cmbGame.Text = "PUBG MOBILE" Then
            txtUser.Visible = True
            txtZone.Visible = False
            Label1.Visible = True
            Label2.Visible = False
            Label4.Visible = False
            cmbServer.Visible = False
        ElseIf cmbGame.Text = "SAUSAGE MAN" Then
            txtUser.Visible = True
            txtZone.Visible = False
            Label1.Visible = True
            Label2.Visible = False
            Label4.Visible = False
            cmbServer.Visible = False
        ElseIf cmbGame.Text = "GENSHIN IMPACT" Then
            txtUser.Visible = True
            txtZone.Visible = False
            Label1.Visible = True
            Label2.Visible = False
            Label4.Visible = True
            cmbServer.Visible = True
        ElseIf cmbGame.Text = "POINT BLANK" Then
            txtUser.Visible = True
            txtZone.Visible = False
            Label1.Visible = True
            Label2.Visible = False
            Label4.Visible = False
            cmbServer.Visible = False
        End If

    End Sub

    Private Sub cmbServer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServer.SelectedIndexChanged

    End Sub
End Class
