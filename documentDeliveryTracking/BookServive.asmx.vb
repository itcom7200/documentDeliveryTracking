Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Web.Script.Serialization
Imports System.Web.Script.Services
Imports System.Data

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
<System.Web.Script.Services.ScriptService()>
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class BookServive
    Inherits System.Web.Services.WebService

    <WebMethod()>
    Public Function Hello() As String
        Dim dt As New DataTable
        dt.Columns.Add("bibID")
        dt.Columns.Add("title")
        dt.Columns.Add("auther")
        dt.Rows.Add("B001", "Test", "Auther")
        dt.Rows.Add("B002", "Test12", "Auther12")
        Return GetJson(dt)
    End Function


    Public Function GetJson(ByVal dt As DataTable) As String
        Return New JavaScriptSerializer().Serialize(From dr As DataRow In dt.Rows Select dt.Columns.Cast(Of DataColumn)().ToDictionary(Function(col) col.ColumnName, Function(col) dr(col)))
    End Function

End Class