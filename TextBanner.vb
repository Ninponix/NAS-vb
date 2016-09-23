'TEXT BANNER TUTORIAL
'====================
'
'TEXT BANNER Is A BANNER ADVERTISEMENT THAT REPRESENTS ONLY 2 TEXT ELEMENTS, THE ADVERTISEMENT TITLE And THE 
'ADVERTISEMENT DESCRIPTION.
'
'1. Drag And Drop TextBanner Control from your project's toolbox. (If it does not appear try building the project).
'2. Arrange it where you want And anchor it to the position you need it to be. (Automatic anchoring has been
'disabled due To protection levels).
'3. In the first form Or the form where you start monetising (previwing ads) your application, put this code
'in the Form's Load function. 

'TextBanner.DeveloperID = 0;

'Make sure you replace the 0 With your Ninponix Developer ID (New constitution, according To 2016 Sept).

'4. Change the BannerTitle And BannerDescription And the LinkURL to adjust the default content which Is shown 
'when there Is no internet connection available for users.
'5. Good luck

Imports System.Drawing

Public Class TextBanner

    ''' <summary>
    ''' Initialize Text Banner for usage
    ''' </summary>
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        UpdateBanner()
        BannerChanger.Interval = AdUpdateRate
    End Sub

#Region "Methods"
    ''' <summary>
    ''' Update the banner location, docking and the size using the properties specified by the developer
    ''' </summary>
    Public Sub UpdateBanner()
        Try
            'Change the size of the advertisement
            Select Case BannerSizeFormat
                Case BannerSize.Normal
                    Width = 300
                    Height = 75
                Case BannerSize.Wide
                    Width = 500
                    Height = 75
            End Select

            bannerTitleLabel.Text = BannerTitle
            bannerDescriptionLabel.Text = BannerDescription

            bannerTitleLabel.Font = Font
            bannerDescriptionLabel.Font = BannerDescriptionFont

        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Properties"
    Private templinkurl As String = ""

    ''' <summary>
    ''' Link of the current offline advertisement
    ''' </summary>
    ''' <returns></returns>
    Public Property LinkURL() As String
        Get
            Return templinkurl
        End Get
        Set(ByVal value As String)
            templinkurl = value
        End Set
    End Property

    Private tempDeveloperID As Integer

    ''' <summary>
    ''' Developer ID used to track downloads from a certain user
    ''' </summary>
    ''' <returns></returns>
    Public Property DeveloperID() As Integer
        Get
            Return tempDeveloperID
        End Get
        Set(ByVal value As Integer)
            tempDeveloperID = value
        End Set
    End Property

    Private tempUpdateRate As Integer = 25000

    ''' <summary>
    ''' The rate of changing the advertisement. Default is 25000 (25 seconds)
    ''' </summary>
    ''' <returns></returns>
    Public Property AdUpdateRate() As Integer
        Get
            Return tempUpdateRate
        End Get
        Set(ByVal value As Integer)
            tempUpdateRate = value
            BannerChanger.Interval = value
        End Set
    End Property

    Private tempBannerDescriptionFont As Font = New Font("Segoe UI Semilight", 12)

    ''' <summary>
    ''' The font of the description of the banner advertisement.
    ''' </summary>
    ''' <returns></returns>
    Public Property BannerDescriptionFont() As Font
        Get
            Return tempBannerDescriptionFont
        End Get
        Set(ByVal value As Font)
            tempBannerDescriptionFont = value
            UpdateBanner()
        End Set
    End Property

    Private tempsize As BannerSize

    ''' <summary>
    ''' Size of the banner. 300x100 is default (normal).
    ''' </summary>
    ''' <returns></returns>
    Public Property BannerSizeFormat() As BannerSize
        Get
            Return tempsize
        End Get
        Set(ByVal value As BannerSize)
            tempsize = value
            UpdateBanner()
        End Set
    End Property

    Private TempBannerText As String = "Banner Text"

    ''' <summary>
    ''' Title of the banner advertisement
    ''' </summary>
    ''' <returns></returns>
    Public Property BannerTitle() As String
        Get
            Return TempBannerText
        End Get
        Set(ByVal value As String)
            TempBannerText = value
            UpdateBanner()
        End Set
    End Property

    Private tempBannerDescription As String = "Banner Description"

    ''' <summary>
    ''' Description of the banner advertisement.
    ''' </summary>
    ''' <returns></returns>
    Public Property BannerDescription() As String
        Get
            Return tempBannerDescription
        End Get
        Set(ByVal value As String)
            tempBannerDescription = value
            UpdateBanner()
        End Set
    End Property
#End Region

#Region "Enumerations"
    ''' <summary>
    ''' Size of the banner. 300x100 is default (normal)
    ''' </summary>
    Public Enum BannerSize
        Normal
        Wide
    End Enum
#End Region

    Private nas_server = "http://www.ninponix.net/nas" + DeveloperID.ToString() + "/banner.nas"
    Private temp_nas_storage = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\nasbanner.nas"

    Private WithEvents wc As Net.WebClient = New Net.WebClient()

    ''' <summary>
    ''' Occurs when the banner loads
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TextBanner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateBanner()

        'Update the text from internet
        Try
            wc.DownloadFileAsync(New Uri(nas_server), temp_nas_storage)
        Catch ex As Exception
            Console.WriteLine("There is no internet connection available. Input the details yourself.")
        End Try
    End Sub

    Private ad_content As String = ""
    Private downloaded As Boolean = False

    Private Sub wc_DownloadCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles wc.DownloadFileCompleted
        Try
            downloaded = True

            'Banner information successfully retrieved
            Dim sr As New IO.StreamReader(temp_nas_storage.ToString())

            Using (sr)
                ad_content = sr.ReadToEnd()
                sr.Close()
            End Using

            'Represent the advertisement
            UpdateAdvertisement()
        Catch ex As Exception

        End Try
    End Sub

    Private current_advertisement As Integer = -1

    Private Sub UpdateAdvertisement()
        Try
            If (downloaded = True) Then
                If (current_advertisement = ad_content.Split(vbCrLf).Length) Then
                    current_advertisement = 0
                Else
                    current_advertisement += 1
                End If

                Dim _line_content As String = ad_content.Split(vbCrLf).GetValue(current_advertisement)

                Dim _adTitle As String = _line_content.Split(";").GetValue(0)
                Dim _adDescription As String = _line_content.Split(";").GetValue(1)
                Dim _adURL As String = _line_content.Split(";").GetValue(2)

                BannerTitle = _adTitle
                BannerDescription = _adDescription
                LinkURL = _adURL
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBannerLabel_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Process.Start(LinkURL)
    End Sub

    Private Sub bannerTitleLabel_Click(sender As Object, e As EventArgs) Handles bannerTitleLabel.Click
        Process.Start(LinkURL)
    End Sub

    Private Sub bannerDescriptionLabel_Click(sender As Object, e As EventArgs) Handles bannerDescriptionLabel.Click
        Process.Start(LinkURL)
    End Sub

    Private Sub bannerChanger_Tick(sender As Object, e As EventArgs) Handles BannerChanger.Tick
        UpdateAdvertisement()
    End Sub

End Class
