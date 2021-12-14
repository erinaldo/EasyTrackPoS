Imports System.Net
Imports System.Web
Imports System.Collections.Specialized
Imports System.IO
Imports System.Text
Module SMSModule

    Public Sub Sendsms(ByVal smskey As String, ByVal from As String, ByVal recipient As String, ByVal body As String)
        Dim apikey = smskey
        Dim message = body
        Dim numbers = recipient
        Dim strGet As String
        Dim sender = from
        Dim url As String = "https://sms.arkesel.com/sms/api?action=send-sms"
        strGet = url + "&api_key=" + apikey + "&to=" + numbers + "&from=" + sender + "&sms=" + WebUtility.UrlEncode(message)
        Dim webclient As New System.Net.WebClient
        Dim result As String = webclient.DownloadString(strGet)
        MessageBox.Show(result)
    End Sub
End Module
