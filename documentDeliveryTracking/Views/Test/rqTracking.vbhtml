@Code
    ViewData("Title") = "rqTracking"
End Code
<div class="row">
    <div class="col-md-4">
        <h2>Contact </h2>
        <address>
            <b>ID : </b>59121293<br />
            <b>Name : </b>สันติภาพ ตันประมวล<br />
            <b>Default point : </b>ตึกนวัตกรรม <br>
        </address>

        <address>
            <strong>E-mail: </strong>@*<a href="mailto:suntiparb.tu@mail.wu.ac.th">*@suntiparb.tu@mail.wu.ac.th</a><br />
        </address>
    </div>

    <div class="col-md-8">
        <h2>Document Delivery Tracking</h2>
        <div class="btn-group">
            <button id="getAll" class="btn btn-primary active">ALL</button>
            <button id="getCurrent" class="btn btn-primary">Current</button>
            <button id="getReject" class="btn btn-primary">Reject</button>
            <button id="getComplete" class="btn btn-primary">Complete</button>
        </div>

        <div class="container-fluid nopadding">

            <div id="main">

            </div>

        </div>

    </div>
</div>

<script type="text/javascript">
    $(document).ready(function () {

        $.ajax({
            "url": "https://wulibdemoapi.walaiautolib.com/wulib/api/NDDRequest/59121293",
            "method": "GET",
            "success": ajaxSuccess1,
            "error": ajaxError
        });

        $('.btn-group').on('click', '.btn', function () {

            $(this).addClass('active').siblings().removeClass('active');


            switch (this.id) {
                case "getAll":
                    var getId = "getAll";
                    break;
                case "getCurrent":
                    var getId = "getCurrent";
                    break;
                case "getReject":
                    var getId = "getReject";
                    break;
                case "getComplete":
                    var getId = "getComplete";
                    break;
            }
            //console.log(getId);

        });

        function ajaxSuccess1(data) {
            console.log(data);

            var rowHTML, resultRow = "";
            
            $.each(data, function (i) {
                var { TITLE, BARCODE, DDRECSTATUS, REQUESTDATE, REQUESTTIME, DDSENDPOINTNAME, DDADDRESS,
                    DDDISTRICTNAME, DDPROVINCENAME, DDPOSTCODE, EDITFLAG, DELETEFLAG, DDCURRENTPROCESS, URL } = data[i];

                //var msec = Date.parse(REQUESTDATE);
                //var d = new Date(msec);

                var location, iconType, btnColor = "";


                switch (DDRECSTATUS) {
                    case "0": // Reject
                        btnColor = "btn-danger";
                        break;
                    case "1": // Active
                        btnColor = "btn-warning";
                        break;
                    case "2": // Close
                        btnColor = "btn-success";
                        break;

                }


                switch (DDSENDPOINTNAME) {
                    case null: // Point to Home
                        location = `${DDADDRESS} ${DDDISTRICTNAME}`;
                        //location = `${DDADDRESS} ${DDDISTRICTNAME} ${DDPROVINCENAME} ${DDPOSTCODE}`;
                        iconType = "iconHome.png";
                        break;
                    default: // Point to Point
                        location = DDSENDPOINTNAME;
                        iconType = "iconCar.png";
                        
                }

                console.log(location);

                rowHTML = `<hr class="hr-set-margin" />

<div class="row">
    <div class="col-xs-5 col-sm-3 col-lg-3">
        <img class="img-clover-book img-thumbnail" src="${URL}">
        <br><br>
    </div>
    <div class="col-sm-8 col-lg-7">
        <div class="col-xs-7 col-sm-12">
            <div class="row">
                <b>Title:</b> <a class="text-info" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682"
                                 target="_blank">${TITLE}</a><br>
                <b>Barcode:</b>${BARCODE}<br>
                <b>Request Date:</b> ${REQUESTDATE}<br><br>
                <img class="img-thumbnail" src="/Content/Icon/${iconType}"> &nbsp; &nbsp;: ${location}
                <br><br>
            </div>
        </div>
        <div class="col-xs-12">
            <div class="row">
                <div class="col-xs-7 col-sm-6">
                    <div class="row">
                        <!-- Button -->
                        <button type="button" class="btn ${btnColor}" data-toggle="modal" data-target="#exampleModalScrollable">
                            ${DDCURRENTPROCESS}
                        </button>
                        <!-- Modal -->
                        <div class="modal fade" id="exampleModalScrollable" tabindex="-1" role="dialog" aria-labelledby="exampleModalScrollableTitle" aria-hidden="true">
                            <div class="modal-dialog modal-dialog-scrollable" role="document">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <h2 class="modal-title text-green-opac" id="exampleModalScrollableTitle">Track & Trace</h2>
                                        <h4 class="text-header-track-and-trace">รอบที่จัดส่ง: 11/11/2019 เวลา: 15:30 น.</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>
                                    <div class="modal-body">
                                        <!-- start body textbox -->
                                        <div class="row">
                                            <div class="col-xs-3 col-sm-2 col-md-2 nopadding">
                                                <div class="icon">
                                                    <img class="img-iconfix" src="/Content/Icon/iconSuccess.png">
                                                    <br><br>
                                                </div>
                                            </div>
                                            <div class="col-xs-8">
                                                <b class="lead text-green-opac">จัดส่งเรียบร้อยแล้ว</b><br>
                                                ผู้รับ: คุณ สวัสดี วันจันทร์<br>
                                                วันที่: 11/11/2019 เวลา: 16:00 น.
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-xs-3 col-sm-2 col-md-2 nopadding">
                                                <div class="icon">
                                                    <img class="img-iconfix" src="/Content/Icon/iconTime.png">
                                                    <br><br>
                                                </div>
                                            </div>
                                            <div class="col-xs-8">
                                                <b class="lead text-green-opac">Document รอนำส่ง</b><br>
                                                เจ้าหน้าที่: WU lineman<br>
                                                วันที่: 11/11/2019 เวลา: 15:30 น.
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-xs-3 col-sm-2 col-md-2 nopadding">
                                                <div class="icon">
                                                    <img class="img-iconfix" src="/Content/Icon/iconTime.png">
                                                    <br><br>
                                                </div>
                                            </div>
                                            <div class="col-xs-8">
                                                <b class="lead text-green-opac">ทำรายการเรียบร้อย</b><br>
                                                เจ้าหน้าที่: staff wu <br>
                                                วันที่: 11/11/2019 เวลา: 11:56 น.
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-xs-3 col-sm-2 col-md-2 nopadding">
                                                <div class="icon-noline">
                                                    <img class="img-iconfix" src="/Content/Icon/iconTime.png">
                                                    <br><br>
                                                </div>
                                            </div>
                                            <div class="col-xs-8">
                                                <b class="lead text-green-opac">รับคำร้องขอ</b><br>
                                                สาขา: หอสมุดกลาง<br>
                                                วันที่: 11/11/2019 เวลา: 10:56 น.
                                            </div>
                                        </div>

                                    </div> <!-- modal-body -->

                                </div>
                            </div>
                        </div>
                        <!-- Button&Model -->
                    </div>

                </div>

                <div class="col-xs-5">

                </div>
            </div>
        </div>
    </div>
    <div id="QRcode" class="visible-lg col-lg-2 nopadding">
        
    </div>
    <hr />

</div>
`;

                resultRow += rowHTML;


            })

            //console.log(resultRow);

            $("#main").append(resultRow);

            genQRcode();
        }

        function ajaxError() {
            console.log("Can't connect webservice");

        }

        function genQRcode() {
            var GenQRcode = "http://localhost:49777/Home/testAPI";
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

