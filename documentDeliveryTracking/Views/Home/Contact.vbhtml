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


            </div>
        </div>


    </div>
</div>




<script type="text/javascript">
    $(document).ready(function () {
        var myObj, i, j, x = "";

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
                    "staff": "สันติภาพ ตันประมวล",
                    "lineStaff": "itcom7200",
                    "telStaff": "0808841358",
                    "ddPoint": "เรียนรวม 5",
                    "checkpoints": [
                        {
                            "icon":"iconTime.png",
                            "color": "text-green-opac",
                            "head": "รับคำร้องขอ",
                            "text": "สาขา",
                            "message": "หอสมุดกลาง",
                            "date": "11/11/2019",
                            "time": "10:56"
                        },
                        {
                            "icon": "iconSuccess.png",
                            "color": "text-green-opac",
                            "head": "ทำรายการเรียบร้อยแล้ว",
                            "text": "เจ้าหน้าที่",
                            "message": "Suntiparb Tunparmuan",
                            "date": "11/11/2019",
                            "time": "12:00"
                        }
                    ]
                }

            ]


        }


        let { tracking } = testJson;
        $.each(tracking, function (i) {
            //console.log(`รายการที่ ${i+1}`);
            
            $.each(tracking[i].checkpoints, function (x) {
                
                console.log(`icon: ${tracking[i].checkpoints[x].icon}`);

            });
        });


        



    });
</script>

<div class="container">