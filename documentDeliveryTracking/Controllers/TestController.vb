Imports System.Web.Mvc

Namespace Controllers
    Public Class TestController
        Inherits Controller

        Function Index(trackingId As String) As ActionResult

            ViewData("Message") = trackingId

            Return View()
        End Function

        Function Search(trackingId As String) As ActionResult

            ViewData("trackingID") = trackingId

            Return View()
        End Function

        Function testSearch(trackingId As String) As ActionResult

            ViewData("trackingID") = trackingId

            Return View()
        End Function

        Function Font() As ActionResult

            ViewData("Message") = "Testing FontAwesome"

            Return View()
        End Function

        Function rqTracking() As ActionResult

            ViewData("Message") = "NDDRequest"

            Return View()
        End Function

        Function requesttracking() As ActionResult

            ViewData("Message") = "NDDRequest"

            Return View()
        End Function

        Function wait() As ActionResult

            ViewData("Message") = "NDDRequest"

            Return View()
        End Function

        Function requestcode(trackingId As String) As ActionResult

            ViewData("trackingID") = trackingId

            Return View()
        End Function



    End Class
End Namespace