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
    Function Content() As ActionResult
        ViewData("Message") = "Test content Page."

        Return View()
    End Function

    Function Tracking() As ActionResult
        ViewData("Message") = "Document Delivery Tracking"

        Return View()
    End Function

    Function Search() As ActionResult
        ViewData("Message") = "Search Document Delivery Tracking"

        Return View()
    End Function
    Function Newtracking() As ActionResult
        ViewData("Message") = "Document Delivery Tracking"

        Return View()
    End Function

    Function Ajax() As ActionResult
        ViewData("Message") = "Testing Jqury Ajax"

        Return View()
    End Function

    Function Content2() As ActionResult
        ViewData("Message") = "Testing Jqury Ajax"

        Return View()
    End Function

End Class
