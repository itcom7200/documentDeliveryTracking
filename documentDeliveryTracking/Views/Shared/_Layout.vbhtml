<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/Content/qrcode.js")
    @*@Scripts.Render("~/Content/fontawesome.js")*@
</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("Document Delivery Tracking", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("Home", "Index", "Home")</li>
                    <li>@Html.ActionLink("About", "About", "Home")</li>
                    <!--
    <li>@Html.ActionLink("Contact", "Contact", "Home")</li>
    <li>@Html.ActionLink("Content", "Content", "Home")</li>
    -->
                    @*<li>@Html.ActionLink("Tracking", "Ajax", "Home")</li>*@  @* tracking เดิม *@
                    <!--<li>@Html.ActionLink("new", "Newtracking", "Home")</li>-->
                    @*<li>@Html.ActionLink("Search", "testAPI", "Home")</li>*@ @* search เดิม*@
                    <!--<li>@Html.ActionLink("AJAX", "Ajax", "Home")</li>-->
                    @*<li>@Html.ActionLink("Test Ajax page", "Test", "Test")</li>*@

                    <li>@Html.ActionLink("Tracking", "wait", "Test")</li>
                    <li>@Html.ActionLink("Search", "requestcode", "Test")</li>
                </ul>
            </div>
        </div>
    </div>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <script type="text/javascript">

            $.ajax({
                //data: `requestcode=${id}`,
                "url": "https://wulibdemoapi.walaiautolib.com/wulib/api/NDDLibraryContact",
                "method": "GET",
                "timeout": 0,
                "success": function (data) {
                    var totalContact = "";
                    var contact = "";
                    var result = data.split(";");
                    //console.log(result);
                    $.each(result, function (i) {
                        //console.log(result[i]);
                        contact = `${result[i]} <br>`;
                        totalContact += contact;
                    })
                    $("#contact").html(totalContact);
                },
                "error": function () {
                    console.log("Web service Error");
                }
            });
            

        </script>
        <footer>
            <p id="contact"></p>
                @*<p>&copy; @DateTime.Now.Year - My ASP.NET Application</p>*@
                <!--<p> © 2019 Developer by Suntiparb Tunparmuan
                    Digital Information Management(DIM)
                    walailak University </p>-->
        </footer>
    </div>


    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>