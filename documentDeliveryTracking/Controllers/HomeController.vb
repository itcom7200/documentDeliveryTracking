Imports System.Web.Script.Serialization
Imports System.Web.Script.Services
Imports System.Data
Imports Newtonsoft.Json

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function

    Function Tracking() As ActionResult
        ViewData("Message") = "Document Delivery Tracking"

        Return View()
    End Function

    Function trackingAjax() As ActionResult
        ViewData("Message") = "DD Ajax test"

        Return View()
    End Function

    Function Search() As ActionResult
        ViewData("Message") = "Search Document Delivery Tracking"

        Return View()
    End Function

    Function Ajax() As ActionResult
        ViewData("Message") = "Testing Jqury Ajax"

        Return View()
    End Function

    Public Class Container
        Public cloverBook As String
        Public title As String
    End Class

    Function JsonResult() As ActionResult
        Dim myService As New localhost.WebService1
        Dim strJSON = myService.GetBook()

        ViewData("test") = strJSON

        Dim clover1 As String
        Dim title1 As String


        Dim resultSearch() = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Container())(strJSON)
        For Each result As Container In resultSearch
            If result IsNot Nothing Then
                clover1 = result.cloverBook
                title1 = result.title


            End If
        Next

        ViewData("Message") = "Testing Jqury Ajax"

        Return View()
    End Function

    Function viewAll() As ActionResult

        Return View()
    End Function
    Function viewCurrent() As ActionResult

        Return View()
    End Function
    Function viewReject() As ActionResult

        Return View()
    End Function
    Function viewComplete() As ActionResult

        Return View()
    End Function

    Function viewTrackingSearch() As ActionResult

        Return View()
    End Function



End Class
