Namespace DynamicComponents
    Public Class ReturnKeyEnable
        Public Shared Internal_Registration_Key As String = "0000-000-000-000-0000"
        Private Col_ControlName As New Collection()
        Private Col_ControlIndex As New Collection()
        Private MyForm As New System.Windows.Forms.Form()
        Private MyUserControl As New System.Windows.Forms.UserControl()
        Dim currentDomain As AppDomain = AppDomain.CurrentDomain
        Private Sub MYExnHandler(ByVal sender As Object, ByVal e As UnhandledExceptionEventArgs)
            Dim EX As Exception
            'EX = e.ExceptionObject
            'Dim str_error As String = "http://www.egy1st.com/notify.php?error=" + EX.StackTrace
            'Dim result_error As String = GetPageHTML(str_error)
        End Sub
        Private Sub MYThreadHandler(ByVal sender As Object, ByVal e As Threading.ThreadExceptionEventArgs)
            'Dim str_error As String = "http://www.egy1st.com/notify.php?error=" + e.Exception.StackTrace
            'Dim result_error As String = GetPageHTML(str_error)
        End Sub
        Public Sub EnableReturnKey(ByVal dm_Form As System.Windows.Forms.Form, ByVal Mode As Boolean)
            Dim _ProductId As String
            Dim _CompanyId As String
            Dim _CompanyInfo As String
            Dim _ProductVersion As String
            Dim _buynow_URL As String

            _CompanyId = "EgyFirst Software"
            _ProductId = "ReturnkeyEnable"
            _ProductVersion = "V. 4.0"

            _CompanyInfo = "Return Key Enable V. 4.0" + vbCrLf
            _CompanyInfo += "Powered by EgyFirst Software, Inc." + vbCrLf
            _CompanyInfo += "Free 30 Days Trial Version"

            _buynow_URL = "http://egy1st.com/returnkey-enabled/"

            
            Dim TxtCtrl As New Control()
            Dim X As Byte


            MyForm = dm_Form

            X = 0
            For Each TxtCtrl In dm_Form.Controls
                If TypeName(TxtCtrl) = "TextBox" Then
                    Col_ControlName.Add(TxtCtrl)
                    Col_ControlIndex.Add(X)
                End If
                X += 1
            Next TxtCtrl


            Dim MyControl As System.Windows.Forms.Control

            If Mode = True Then
                For Each MyControl In MyForm.Controls
                    AddHandler MyControl.KeyPress, AddressOf EnableTab_KeyPress
                Next MyControl
            End If

        End Sub

        Public Sub EnableReturnKey(ByVal dm_Form As System.Windows.Forms.UserControl, ByVal Mode As Boolean)
            
            ' Define a handler for unhandled exceptions.
            AddHandler currentDomain.UnhandledException, AddressOf MYExnHandler

            ' Define a handler for unhandled exceptions for threads behind forms.
            AddHandler Application.ThreadException, AddressOf MYThreadHandler

            Dim TxtCtrl As New Control()
            Dim X As Byte

            MyUserControl = dm_Form

            X = 0
            For Each TxtCtrl In dm_Form.Controls
                If TypeName(TxtCtrl) = "TextBox" Then
                    Col_ControlName.Add(TxtCtrl)
                    Col_ControlIndex.Add(X)
                End If
                X += 1
            Next TxtCtrl



            Dim MyControl As System.Windows.Forms.Control

            If Mode = True Then
                For Each MyControl In MyUserControl.Controls
                    AddHandler MyControl.KeyPress, AddressOf EnableTab_KeyPress
                Next MyControl
            End If

        End Sub


        Private Sub EnableTab_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
            If e.KeyChar = Chr(13) Then
                System.Windows.Forms.SendKeys.Send("{Tab}")
            End If
        End Sub

        Public Sub setRegistrationKey(ByVal myKey As String)
            Internal_Registration_Key = myKey
        End Sub

        Private Function GetPageHTML(ByVal URL As String) As String
            Dim objWC As New System.Net.WebClient()
            Return New System.Text.UTF8Encoding().GetString(objWC.DownloadData(URL))
        End Function
    End Class
End Namespace