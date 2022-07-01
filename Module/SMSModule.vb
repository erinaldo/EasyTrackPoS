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
    Public Sub payment(ByVal smskey As String, ByVal from As String, ByVal recipient As String, ByVal body As String)
        '   ' WebRequest - POST

        '' Declare url
        'Dim url = $"https://jsonplaceholder.typicode.com/users"

        '' Optional: Specify request options
        'Dim options = New Utils.WebRequest.Options With {
        '    .UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:82.0) Gecko/20100101 Firefox/82.0",
        '    .ContentType = Utils.WebRequest.ContentType.ApplicationJson,
        '    .Headers = New System.Net.WebHeaderCollection From {
        '        {"key", "value"}
        '    }
        '}

        '' Serialize object to Json to create a new employee
        'Dim payload = "
        '    {
        '      ""id"": 0,
        '      ""name"": ""Kenneth Perkins"",
        '      ""username"": null,
        '      ""email"": null,
        '      ""address"": null,
        '      ""phone"": null,
        '      ""website"": null,
        '      ""company"": null
        '    }
        '"

        '' Execute a post request at the following url
        'Dim response = Await Utils.WebRequest.PostAsync(url, payload, options)

        '' Display the status code and response body
        'Debug.Print($"
        '    Status: {CInt(response.Result.StatusCode)} - {response.Result.StatusDescription}
        '    Bytes Received: {response.Bytes.Length}
        '    Body: {response.Body}
        '")

        '' .... Do something with response.Body like deserialize it to an object

        '' expected output:
        ''   Status: 201 - Created
        ''   Bytes Received: 154
        ''   Body: {
        ''       "id": 11,
        ''       "name": "Kenneth Perkins",
        ''       "username": null,
        ''       "email": null,
        ''       "address": null,
        ''       "phone": null,
        ''       "website": null,
        ''       "company": null
        ''   }
    End Sub
End Module
