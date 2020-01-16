@Code
    ViewData("Title") = "Index"
End Code

</div>

<div class="background-fullscreen">
    <div class="container">
        <div class="row">
            <div class="col-xs-12 col-sm-7 col-md-8">
                <h1 class="text">Walai DD Tracking</h1>
                <p class="font-discription">ติดตามหนังสือของคุณได้ทุกเวลา</p>
                <br />
                <div class="search-container">
                    <form class="form-group row">
                        <div class="col-xs-9 col-sm-9 col-md-8" style="padding-right: 00px;">
                            <input type="text" id="inputId" name="trackingId" class="form-control input-lg" placeholder="Enter Your Tracking Number" value="@ViewData("Message")">
                        </div>
                        <div class="col-xs-3 col-sm-3" style="padding-left: 0px;">
                            <center><button type="submit" id="Enter" class="btn btn-green-opac btn-lg">Go</button></center>
                        </div>
                    </form>
                </div>
                <br />
                <br />
                <br />
            </div>
            <div class="col-sm-4 col-md-3 visible-sm visible-md visible-lg">
                <img class="img-banner" src="~/Content/Image/DeliveryMan.png">
            </div>
        </div>

    </div>
</div>
<div class="container">
    <div class="container">
        <div class="row">
            <div id="main">
                <div class="col-sm-7 col-md-6">
                    <div class="row">
                        <div class="col-xs-2 col-md-2 nopadding"></div>
                        <div class="col-xs-9"><h2>Track & Trace</h2><br></div>
                    </div>
                    <div class="row">
                        <div class="col-xs-3 col-md-3 nopadding">
                            <div class="icon-noline">
                                <img class="img-iconfix" src="/Content/Icon/iconTime.png">
                                <br><br>
                            </div>
                        </div>
                        <div class="col-xs-9">
                            <b class="lead text-green-opac">รับคำร้องขอ</b><br>
                            สาขา: ห้องสมุดแพทย์<br>
                            วันที่: 11/11/2019 เวลา: 11:30 น.
                        </div>

                    </div>
                </div>
                <div class="col-sm-4 col-md-3">
                    <hr class="visible-xs hr-set-margin">
                    <h2>Contact</h2>
                    <p>หากมีข้อสงสัย กรุณาติดต่อ</p>
                    <address>
                        Staff: สันติภาพ 1<br>
                        Line id: lineman@wu1<br>
                        Tel: 1111111111 <br>
                        <b>DD Point: เรียนรวม5</b>
                    </address>
                    <p></p>
                    <div id="QRcode" class="img-qrcode-maxsize hidden-xs"></div>
                </div>
            </div>
        </div>


    </div>
</div>

<script>
    $(document).ready(function () {



        genQRcode();

        function genQRcode() {
            var GenQRcode = `https://www.facebook.com/`;
            console.log(GenQRcode);
            if (GenQRcode !== "") {
                new QRCode(document.getElementById('QRcode'), {
                    text: GenQRcode,
                    width: 110,
                    height: 110
                });
            }
        }

    });



</script>
<div class="container">