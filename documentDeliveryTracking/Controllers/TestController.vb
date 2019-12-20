Imports System.Web.Mvc

Namespace Controllers
    Public Class TestController
        Inherits Controller

        ' GET: Test
        Function Test() As ActionResult

            Return View()
        End Function

        Function viewAll() As ActionResult
            Dim myService As New localhost.WebService1
            Dim responceTracking = myService.GetBook()

            Dim responce() = Newtonsoft.Json.JsonConvert.DeserializeObject(Of trackingBook())(responceTracking)
            Dim dt As New DataTable
            dt.Columns.Add("cloverBook")
            dt.Columns.Add("title")
            dt.Columns.Add("barcode")
            dt.Columns.Add("ddType")
            dt.Columns.Add("ddPoint")
            dt.Columns.Add("status")
            dt.Columns.Add("requestStep")
            dt.Columns.Add("libBranch")
            dt.Columns.Add("requestDate")
            dt.Columns.Add("requestTime")
            dt.Columns.Add("processStep")
            dt.Columns.Add("staffLib")
            dt.Columns.Add("processDate")
            dt.Columns.Add("processTime")
            dt.Columns.Add("waitingStep")
            dt.Columns.Add("staffDelivery")
            dt.Columns.Add("waitingDate")
            dt.Columns.Add("waitingTime")
            dt.Columns.Add("deliverStep")
            dt.Columns.Add("userName")
            dt.Columns.Add("deliverDate")
            dt.Columns.Add("deliverTime")

            Dim statusIcon As String
            Dim divLocation As String

            For Each tracking As trackingBook In responce

                Select Case tracking.ddType
                    Case "File"
                        statusIcon = "Content/Icon/iconDoc.png"
                        divLocation = "<img class=""img-thumbnail"" src=""~/Content/Icon/iconDoc.png""> &nbsp; &nbsp;: เรียนรวม5"
                    Case "Docs"
                        statusIcon = "Content/Icon/iconCar.png"
                        divLocation = "<img class='img-thumbnail' src='~/Content/Icon/iconCar.png'> &nbsp; &nbsp;: Download"
                End Select


                dt.Rows.Add(tracking.cloverBook, tracking.title, tracking.barcode, statusIcon,
                            tracking.ddPoint, tracking.status, tracking.requestStep, tracking.libBranch,
                            tracking.requestDate, tracking.requestTime, tracking.processStep, tracking.staffLib,
                            tracking.processDate, tracking.processTime, tracking.waitingStep, tracking.staffDelivery,
                            tracking.waitingDate, tracking.waitingTime, tracking.deliverStep, tracking.userName,
                            tracking.deliverDate, tracking.deliverTime)
            Next

            'ViewData("cloverBook") = cloverBook
            'ViewData("title") = title
            ViewData.Model = dt.AsEnumerable
            Return View()
        End Function

    End Class
End Namespace