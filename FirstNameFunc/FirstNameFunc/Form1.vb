Option Strict On

Public Class Form1

    Private Sub btnDetermine_Click(sender As System.Object, e As System.EventArgs) Handles btnDetermine.Click
        Dim name As String
        name = txtFullName.Text
        txtFirstName.Text = FirstName(name)
    End Sub

    Function FirstName(ByVal name As String) As String
        name = Trim(name)
        Dim endFirst As Integer = name.IndexOf(" ")
        Dim fname As String = name.Substring(0, endFirst)

        Return fname
    End Function

End Class
