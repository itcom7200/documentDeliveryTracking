Imports System.Web.Script.Serialization
Imports System.Web.Script.Services
Imports System.Data
Imports Newtonsoft.Json
Imports documentDeliveryTracking.Class1

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

    Function JsonResult() As ActionResult
        Dim myService As New localhost.WebService1
        Dim strJSON = myService.GetBook()

        ViewData("test") = strJSON

        ViewData("Message") = "Testing Jqury Ajax"

        Return View()
    End Function





End Class
