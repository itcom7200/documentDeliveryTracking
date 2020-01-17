@Code
    ViewData("Title") = "Contact"
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
                    <div class="row"></div>
                </div>

            </div>
        </div>


    </div>
</div>




<script type="text/javascript">
    $(document).ready(function () {

        myObj = {
            "tracking": {
                "id": "53aa7b5c415a670000000021",
                "created_at": "2016-09-26T07:33:48+00:00",
                "updated_at": "2016-09-27T10:45:00+00:00",
                "tracking_number": "98234627343",
                "slug": "kerry-logistics",
                "active": true,
                "expected_delivery": "2016-09-30",
                "tag": "InTransit",
                "checkpoints": [
                    {
                        "slug": "kerry-logistics",
                        "location": "US",
                        "message": "Order Processed: Ready for deliver",
                        "country_iso3": "USA",
                        "tag": "InfoReceived",
                        "checkpoint_time": "2016-09-26T19:40:00",
                        "state": null
                    },
                    {
                        "slug": "kerry-logistics",
                        "location": "US",
                        "message": "Departure Scan",
                        "country_iso3": "USA",
                        "tag": "InTransit",
                        "checkpoint_time": "2016-09-27T10:13:13",
                        "state": "QC"
                    }
                ]
            }


        }


        testJson = {
            "tracking": [
                {
                    "id": "59121293",
                    "staff": "สันติภาพ",
                    "lineStaff": "itcom7200",
                    "telStaff": "0808841358",
                    "ddPoint": "เรียนรวม 5",
                    "checkpoints": [
                        {
                            "icon": "iconSuccess.png",
                            "color": "text-green-opac",
                            "head": "จัดส่งเรียบร้อยแล้ว",
                            "text": "ผู้รับ",
                            "message": "Freddy Merquery",
                            "date": "11/11/2019",
                            "time": "13:30"
                        },
                        {
                            "icon": "iconTime.png",
                            "color": "text-green-opac",
                            "head": "Documentรอนำส่ง",
                            "text": "เจ้าหน้าที่",
                            "message": "WULineman",
                            "date": "11/11/2019",
                            "time": "13:30"
                        },
                        {
                            "icon": "iconTime.png",
                            "color": "text-green-opac",
                            "head": "ทำรายการเรียบร้อยแล้ว",
                            "text": "เจ้าหน้าที่",
                            "message": "Suntiparb",
                            "date": "11/11/2019",
                            "time": "12:00"
                        },
                        {
                            "icon": "iconTime.png",
                            "color": "text-green-opac",
                            "head": "รับคำร้องขอ",
                            "text": "สาขา",
                            "message": "หอสมุดกลาง",
                            "date": "11/11/2019",
                            "time": "10:56"
                        }
                    ]
                }

            ]


        }
        
        

        var showIcon = "";
        let { tracking } = testJson;
        
        $.each(tracking, function (i) {

            $.each(tracking[i].checkpoints, function (x) {

                var checkline = tracking[i].checkpoints[x].head;
                //console.log(tracking[i].checkpoints.length); เช็คความยาวของตัว obj

                
                //console.log(checkline);

                var line = "";

                switch (checkline) {
                    case "รับคำร้องขอ":
                        line = "icon-noline";
                        break;
                    default:
                        line = "icon";
                }

                let HTML = `<div class="row">
                                <div class="col-xs-3 col-md-3 nopadding">
                                    <div class="${line}">
                                        <img class="img-iconfix" src="/Content/Icon/${tracking[i].checkpoints[x].icon}">
                                        <br><br>
                                    </div>
                                </div>
                                <div class="col-xs-9">
                                    <b class="lead ${tracking[i].checkpoints[x].color}">${tracking[i].checkpoints[x].head}</b><br>
                                    ${tracking[i].checkpoints[x].text}: ${tracking[i].checkpoints[x].message}<br>
                                    วันที่: ${tracking[i].checkpoints[x].date} เวลา: ${tracking[i].checkpoints[x].time} น.
                                </div>
                            </div>`;

                showIcon += HTML;
            });
        });


        var QRcode = '<div><div id="QRcode" class="img-qrcode-maxsize hidden-xs"></div></div>';



        let contact1 = '<div class="col-sm-4 col-md-3"><hr class="visible-xs hr-set-margin" /><h2>Contact</h2><p>หากมีข้อสงสัย กรุณาติดต่อ</p>';
        let contact2 = '<address>Staff: ' + tracking[0].staff + '<br />Line id: ' + tracking[0].lineStaff;
        let contact3 = '<br>Tel: ' + tracking[0].telStaff + ' <br><b>DD Point: ' + tracking[0].ddPoint + '</b></address>' + QRcode + '</div >';
        let contact = contact1 + contact2 + contact3;

        let trackAndTrace = '<div class="row"><div class="col-xs-2 col-md-2 nopadding"></div><div class="col-xs-9"><h2>Track & Trace</h2><br></div></div>';

        let track = '<div class="col-sm-7 col-md-6">' + trackAndTrace + showIcon + '</div>';

        let result = track + contact;

        //genQRcode();

        $("#main").html(result);

        genQRcode();

        function genQRcode() {
            var GenQRcode = `https://www.facebook.com/`;
            //console.log(GenQRcode);
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