Imports System.Web.Script.Serialization
Imports System.Web.Script.Services
Imports System.Data
Imports Newtonsoft.Json
Imports documentDeliveryTracking.trackingBook
Imports System.Web.Http

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
        Dim responceTracking = myService.GetBook()

        Dim responce() = Newtonsoft.Json.JsonConvert.DeserializeObject(Of trackingBook())(responceTracking)
        Dim dt As New DataTable
        dt.Columns.Add("id")
        dt.Columns.Add("cloverBook")
        dt.Columns.Add("title")


        Dim i As Integer = 0

        For Each tracking As trackingBook In responce
            'Dim cloverBook = tracking.cloverBook
            dt.Rows.Add(i, tracking.cloverBook, tracking.title)
        Next

        'ViewData("cloverBook") = cloverBook
        'ViewData("title") = title
        ViewData.Model = dt.AsEnumerable
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

    Function testAPI() As ActionResult

        Return View()
    End Function
    Function newSearch(trackingId As String) As ActionResult

        If trackingId IsNot Nothing Then
            Dim myservice As New localhost.WebService1
            Dim serviceGetValue = myservice.getValue(trackingId)

            Dim responceGetValue() = Newtonsoft.Json.JsonConvert.DeserializeObject(Of getValue())(serviceGetValue)

            For Each value As getValue In responceGetValue

                ViewData("id") = value.id
                ViewData("staffName") = value.staffName
                ViewData("staffTel") = value.staffTel
                ViewData("staffLine") = value.staffLine
                ViewData("ddType") = value.ddType
                ViewData("ddPoint") = value.ddPoint
                ViewData("status") = value.status
                ViewData("requestStep") = value.requestStep
                ViewData("libBranch") = value.libBranch
                ViewData("requestDate") = value.requestDate
                ViewData("requestTime") = value.requestTime
                ViewData("processStep") = value.processStep
                ViewData("staffLib") = value.staffLib
                ViewData("processDate") = value.processDate
                ViewData("processTime") = value.processTime
                ViewData("waitingStep") = value.waitingStep
                ViewData("staffDelivery") = value.staffDelivery
                ViewData("waitingDate") = value.waitingDate
                ViewData("waitingTime") = value.waitingTime
                ViewData("deliverStep") = value.deliverStep
                ViewData("userName") = value.userName
                ViewData("deliverDate") = value.deliverDate
                ViewData("deliverTime") = value.deliverTime

            Next

            Return View()
        Else

            Return View()

        End If

    End Function



End Class
