Namespace DynamicComponents
    Public Class ReturnKeyEnable
        Public Shared Internal_Registration_Key As String = "0000-000-000-000-0000"
        Private Col_ControlName As New Collection()
        Private Col_ControlIndex As New Collection()
        Private MyForm As New System.Windows.Forms.Form()
        Private MyUserControl As New System.Windows.Forms.UserControl()

        Public Sub EnableReturnKey(ByVal dm_Form As System.Windows.Forms.Form, ByVal Mode As Boolean)
            Dim MyProtect As New MyProtection()
            Dim _ProductId As String
            Dim _CompanyId As String
            Dim _CompanyInfo As String
            Dim _ProductVersion As String
            Dim _buynow_URL As String

            _CompanyId = "EgyFirst Software"
            _ProductId = "ReturnkeyEnable"
            _ProductVersion = "V. 3.5"

            _CompanyInfo = "Return Key Enable V. 3.5" + vbCrLf
            _CompanyInfo += "Powered by EgyFirst Software, Inc." + vbCrLf
            _CompanyInfo += "Free 30 Days Trial Version"

            _buynow_URL = "http://www.mygoldensoft.com/ordernow.htm"

            MyProtect.SetProductKeys(_CompanyId, _ProductId, _ProductVersion)
            MyProtect.SetAlgorithms(1971, 22, 35)
            MyProtect.SetInformation(_buynow_URL, _CompanyInfo)
            MyProtect.SetLicense(30)
            MyProtect.ShowAuthor()
            If MyProtect.NotLicensed Then
                Exit Sub
            End If

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
            Dim MyProtect As New MyProtection()
            Dim _ProductId As String
            Dim _CompanyId As String
            Dim _CompanyInfo As String
            Dim _ProductVersion As String
            Dim _buynow_URL As String

            _CompanyId = "EgyFirst Software"
            _ProductId = "ReturnkeyEnable"
            _ProductVersion = "V. 3.5"

            _CompanyInfo = "Return Key Enable V. 3.5" + vbCrLf
            _CompanyInfo += "Powered by EgyFirst Software, Inc." + vbCrLf
            _CompanyInfo += "Free 30 Days Trial Version"

            _buynow_URL = "http://www.mygoldensoft.com/ordernow.htm"

            MyProtect.SetProductKeys(_CompanyId, _ProductId, _ProductVersion)
            MyProtect.SetAlgorithms(1971, 22, 35)
            MyProtect.SetInformation(_buynow_URL, _CompanyInfo)
            MyProtect.SetLicense(30)
            MyProtect.ShowAuthor()
            If MyProtect.NotLicensed Then
                Exit Sub
            End If

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

    End Class

End Namespace