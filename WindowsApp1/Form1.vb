Imports System.Text
Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim city As String = TextBox_City.Text

        Try
            Dim queryAddress As New StringBuilder
            queryAddress.Append("https://maps.google.com/maps?q=")

            If TextBox_City.Text <> String.Empty Then
                queryAddress.Append(city + "," & "+")
            End If

            WebBrowser1.Navigate(queryAddress.ToString)
        Catch ex As Exception
            MessageBox.Show("Unable to connect")
        End Try


    End Sub

End Class
