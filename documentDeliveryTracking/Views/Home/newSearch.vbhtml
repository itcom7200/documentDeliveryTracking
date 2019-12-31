@Code
    ViewData("Title") = "newSearch"
End Code
</div>

<div class="background-fullscreen">
    <div class="container">
        <div class="row">
            <div class="col-xs-12 col-sm-7 col-md-8">
                <h1 class="text">Document Delivery</h1>
                <p class="font-discription">ติดตามหนังสือของคุณได้ทุกเวลา</p>
                <br />
                <form class="form-group row" action="" method="get">
                    <div class="col-xs-12 col-sm-7 col-md-8">
                        <input id="trackingID"
                               type="text" class="form-control input-lg"
                               placeholder="Enter Your Tracking Number"
                               name="trackingID">
                    </div>
                    <div class="col-xs-12 col-sm-2" style="padding-left: 0px;">
                        <div class="visible-xs">
                            <br />
                        </div>
                        <center><button id="Enter" class="btn btn-green-opac btn-lg" type="submit">Enter</button></center>
                    </div>
                </form>
                <br />
                <br />
                <br />
            </div>
            <div class="col-sm-4 col-md-3 visible-sm visible-md visible-lg">
                <img class="img-banner" src="/Content/Image/DeliveryMan.png">
            </div>
        </div>

    </div>
</div>

@if ViewData("id") = "0" Then
    ViewData("name") = "If name"
    Select Case ViewData("name")
        Case "If name"
            ViewData("hidden") = "hidden"
    End Select


Else
    ViewData("name") = ViewData("staffName")

End If

<div id="@ViewData("hidden")" class="container">
    <div class="container">
        <div class="row">
            <div id="main">
                <div class="col-sm-4 col-md-4">
                    <h2>Contact</h2>
                    <p>หากมีข้อสงสัย กรุณาติดต่อ</p>
                    <address>
                        <b>Staff : </b>@ViewData("name")<br />
                        <b>IDline: </b>@ViewData("staffLine")<br />
                        <b>Tel: </b>@ViewData("staffTel")<br />
                        <b>DDpoint: </b>@ViewData("staffName")<br />

                    </address>
                </div>
                <div Class="col-sm-7 col-md-4">
                    <br>
                    <div Class="row">
                        <div Class="col-xs-3 col-md-3 nopadding">
                            <div Class="icon">
                                <img Class="img-iconfix" src="/Content/Icon/iconSuccess.png"><br><br>
                            </div>
                        </div><div class="col-xs-9">
                            <b Class="lead text-green-opac">จัดส่งเรียบร้อยแล้ว</b><br>
                            ผู้รับ: Freddy Merquery<br>
                            วันที่: 11/11/2019 เวลา: 16:00 น.
                        </div>
                    </div>
                    <div class="row">
                        <div Class="col-xs-3 col-md-3 nopadding">
                            <div Class="icon">
                                <img Class="img-iconfix" src="/Content/Icon/iconTime.png"><br><br>
                            </div>
                        </div>
                        <div class="col-xs-9">
                            <b Class="lead text-green-opac">Document รอนำส่ง</b><br>
                            เจ้าหน้าที่: WU Lineman<br>
                            วันที่: 11/11/2019 เวลา: 15:30 น.
                        </div>
                    </div>
                    <div Class="row">
                        <div Class="col-xs-3 col-md-3 nopadding">
                            <div Class="icon">
                                <img Class="img-iconfix" src="/Content/Icon/iconTime.png"><br><br>
                            </div>
                        </div>
                        <div Class="col-xs-9">
                            <b Class="lead text-green-opac">ทำการเรียบร้อยแล้ว</b><br>
                            เจ้าหน้าที่: Joseph Joestar<br>
                            วันที่: 11/11/2019 เวลา: 12:00 น.
                        </div>
                    </div>
                    <div Class="row">
                        <div class="col-xs-3 col-md-3 nopadding">
                            <div class="icon-noline">
                                <img class="img-iconfix" src="/Content/Icon/iconTime.png"><br><br>
                            </div>
                        </div>
                        <div class="col-xs-9">
                            <b class="lead text-green-opac">รับคำร้องขอ</b><br>
                            สาขา: ห้องสมุดแพทย์<br>
                            วันที่: 11/11/2019 เวลา: 11:50 น.
                        </div>
                    </div>
                </div>
                <div Class="visible-lg col-md-4">
                    <br>
                    <div Class="row">
                        <div Class="col-xs-6">
                            <p Class="text-center">Keep Tracking</p>
                            <img Class="img-qrcode-maxsize" src="/Content/Image/lineQR.JPG">
                        </div>
                    </div>
                </div>
            </div>



        </div>
    </div>

    <script type="text/javascript">
        $(document).ready(function () {
            $("#hidden").hide();
        });
    </script>

    <div Class="container">
