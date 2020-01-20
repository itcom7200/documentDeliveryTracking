﻿Imports System.Web.Mvc

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

        Function Font() As ActionResult

            ViewData("Message") = "Testing FontAwesome"

            Return View()
        End Function




    End Class
End Namespace