Public Class GraphBanner

#Region "Properties"

    Private tempUpdateRate As Integer = 25000

    ''' <summary>
    ''' Rate of the advertisement update
    ''' </summary>
    ''' <returns></returns>
    Public Property UpdateRate() As Integer
        Get
            Return tempUpdateRate
        End Get
        Set(ByVal value As Integer)
            tempUpdateRate = value
            GraphUpdater.Interval = value
        End Set
    End Property

    Private tempdeveloperid As Integer

    ''' <summary>
    ''' Ninponix ID of the developer
    ''' </summary>
    ''' <returns></returns>
    Public Property DeveloperID() As Integer
        Get
            Return tempdeveloperid
        End Get
        Set(ByVal value As Integer)
            tempdeveloperid = value
        End Set
    End Property
#End Region

    Private nas_server_URL As String = "http://www.ninponix.net/nas" + DeveloperID.ToString() + "/graph_banner_link.nas"
    Private temp_nas_storage As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\graph_banner_link.nas"
    Private WithEvents wc As New Net.WebClient()

    Private Sub GraphBanner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Download the advertisement if internet connection is available
        Try
            wc.DownloadFileAsync(New Uri(nas_server_URL), temp_nas_storage)
        Catch ex As Exception

        End Try
    End Sub

    Private link_content As String = ""

    Private Sub WC_DownloadFileCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs)
        'Download has been completed
        Try
            Dim sr As New IO.StreamReader(temp_nas_storage)
            Using (sr)
                link_content = sr.ReadToEnd()
                sr.Close()
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private current_advertisement_index As Integer = -1
    Private LinkURL As String = ""

    Public Sub UpdateAdvertisement()
        Try
            'Change the adverisement index
            If (current_advertisement_index = link_content.Split(vbCrLf).Length) Then
                current_advertisement_index = 0
            Else
                current_advertisement_index += 1
            End If

            'Render the advertisement
            Dim current_line As String = link_content.Split(vbCrLf).GetValue(current_advertisement_index)
            Dim imageURL As String = current_line.Split(";").GetValue(0)
            Dim nextURL As String = current_line.Split(";").GetValue(1)

            LinkURL = nextURL
            graph_view.ImageLocation = imageURL
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GraphUpdater_Tick(sender As Object, e As EventArgs) Handles GraphUpdater.Tick
        UpdateAdvertisement()
    End Sub

    Private Sub graph_view_click(sender As Object, e As EventArgs) Handles graph_view.Click
        Process.Start(LinkURL)
    End Sub

End Class
