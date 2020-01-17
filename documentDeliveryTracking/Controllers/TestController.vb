Imports System.Web.Mvc

Namespace Controllers
    Public Class TestController
        Inherits Controller

        Function Index(trackingId As String) As ActionResult

            ViewData("Message") = trackingId

            Return View()
        End Function

        Function Php() As ActionResult

            ViewData("Message") = "Hello world!"

            Return View()
        End Function




    End Class
End Namespace