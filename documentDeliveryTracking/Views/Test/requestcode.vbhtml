@Code
    ViewData("Title") = "requestcode"
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
                            <input type="text" id="inputId" name="trackingId" class="form-control input-lg" placeholder="Enter Your Tracking Number" value="@ViewData("trackingID")">
                        </div>
                        <div class="col-xs-3 col-sm-3" style="padding-left: 10px;">
                            <button type="submit" id="Enter" class="btn btn-green-opac btn-lg">Go</button>
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
                @*<div class="col-sm-7 col-md-6">
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
                    </div>*@
            </div>
        </div>


    </div>
</div>

<script type="text/javascript">
    $(document).ready(function () {
        var inputId = $("#inputId").val();

        if (inputId !== "") {
            ajax(inputId);
        }

        function ajax(id) {
            $.ajax({
                data: `requestcode=${id}`,
                "url": "https://wulibdemoapi.walaiautolib.com/wulib/api/NDDTrackinginfo",
                "method": "GET",
                "timeout": 0,
                "success": getContent,
                "error": failGetContent
            });
        }

        function getContent(data) {

            var resultRow = "";
            var icon, line, requestCode = "";
            
            //console.log();


            if (!$.trim(data)) {  // render nulldata
                layout = `<div class="col-sm-12">
                            <div class="row">
                                 <div class="col-xs-12 text-center"></br><h2>Data Not Found!</h2><br><br><br></div>
                            </div>
                     </div>`;

                $("#main").append(layout);


            }
            else { // not blank
                $.each(data.ddrequest, function (i) {
                    var { REQUESTCODE } = data.ddrequest[i];
                    requestCode = REQUESTCODE;
                })




                $.each(data.tracking, function (i) {

                    var { DDHISDATE, DDHISTIME, USERFLAG, ACTPERSONID, DDACTDETAIL, ICONFLAG, ACTPERSON } = data.tracking[i];

                    //console.log(ICONFLAG);

                    switch (ICONFLAG) {
                        case 0:
                            icon = "iconTime.png";
                            break;
                        case 1:
                            icon = "iconFail.png";
                            break;
                        case 2:
                            icon = "iconCancle.png";
                            break;
                        case 3:
                            icon = "iconInfo.png";
                            break;
                        case 4:
                            icon = "iconPlane.png";
                            break;
                    }

                    switch (DDACTDETAIL) {
                        case "Waiting for Accept":
                            line = "icon-noline";
                            break;
                        default:
                            line = "icon";
                    }

                    let hisYear = DDHISDATE.substring(0, 4);
                    let hisMonth = DDHISDATE.substring(4, 6);
                    let hisDate = DDHISDATE.substring(6, 8);

                    let hisTime = DDHISTIME.substring(0, 2);
                    let hisMin = DDHISTIME.substring(2, 4);

                    var row = `<div class="row">
                            <div class="col-xs-3 col-md-3 nopadding">
                                <div class="${line}">
                                    <img class="img-iconfix" src="/Content/Icon/${icon}">
                                    <br><br>
                                </div>
                            </div>
                            <div class="col-xs-9">
                                <b class="lead text-green-opac">${DDACTDETAIL}</b><br>
                                By ${ACTPERSON} <br>
                                Date ${hisDate}/${hisMonth}/${hisYear} Time ${hisTime}:${hisMin} น. 
                                
                            </div>

                        </div>`;

                    resultRow += row;

                });

                var layout = `<div class="col-sm-7 col-md-6">
                        <div class="row">
                            <div class="col-xs-2 col-md-2 nopadding"></div>
                            <div class="col-xs-9"><h2>Track & Trace</h2><br></div>
                        </div>
                        ${resultRow}
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
                    </div>`;
                //console.log(layout);    
                $("#main").append(layout);
                //callback;
                genQR(requestCode);

            }

            

        }

        function genQR(inputId) {

            //console.log(`inputId ${inputId}`);

            var GenQRcode = `https://www.facebook.com/${inputId}`;
            if (GenQRcode !== "") {
                new QRCode(document.getElementById('QRcode'), {
                    text: GenQRcode,
                    width: 110,
                    height: 110
                });
            }
        }

        function failGetContent() {
            console.log("Error webservice");
        }



    });
    
</script>

<div class="container">
