@Code
    ViewData("Title") = "testAPI"
End Code
</div>

<div class="background-fullscreen">
    <div class="container">
        <div class="row">
            <div class="col-xs-12 col-sm-7 col-md-8">
                <h1 class="text">Document Delivery</h1>
                <p class="font-discription">ติดตามหนังสือของคุณได้ทุกเวลา</p>
                <br />
                <div class="form-group row">
                    <div class="col-xs-12 col-sm-7 col-md-8">
                        <input id="inputId" type="text" class="form-control input-lg"
                               placeholder="Enter Your Tracking Number"
                               value="1">
                    </div>
                    <div class="col-xs-12 col-sm-2" style="padding-left: 0px;">
                        <div class="visible-xs">
                            <br />
                        </div>
                        <center><button id="Enter" class="btn btn-green-opac btn-lg">Enter</button></center>
                    </div>
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

        $("#Enter").click(function () {
            var inputId = $("#inputId").val();

            $.ajax({
                type: "POST",
                url: "http://localhost:62597/WebService1.asmx/getValue",
                data: "{id: '" + inputId + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: getContent,
                error: failGetContent
            });
            
        });


        function getContent(data) {
            resultSearch = $.parseJSON(data.d);
            $.each(resultSearch, function (i, item) {
                let contact1 = '<div class="col-sm-4 col-md-4"><h2>Contact</h2><p>หากมีข้อสงสัย กรุณาติดต่อ</p>';
                let contact2 = '<address>Staff: ' + resultSearch[i].staffName + '<br />Line id: ' + resultSearch[i].staffLine;
                let contact3 = '<br>Tel: ' + resultSearch[i].staffTel + ' <br><b>Point: ' + resultSearch[i].ddPoint + '</b><br></address></div >';
                let contact = contact1 + contact2 + contact3;

                console.log(resultSearch[i].status)

                switch (resultSearch[i].status) {
                    case "0": // startRequest
                        var row1 = '<div class="row"><div class="col-xs-3 col-md-3 nopadding">';
                        var row2 = '<div class="icon-noline"><img class="img-iconfix" src="/Content/Icon/iconTime.png">';
                        var row3 = '<br><br></div></div><div class="col-xs-9">';
                        var row4 = '<b class="lead text-green-opac">' + resultSearch[i].requestStep + '</b><br> สาขา: ' + resultSearch[i].libBranch + '<br>วันที่: ' + resultSearch[i].requestDate + ' เวลา: ' + resultSearch[i].requestTime + ' น.</div></div>';
                        var resultRow = row1 + row2 + row3 + row4;
                        break;

                    case "1": // rejectRequest
                        var row1 = '<div class="row"><div class="col-xs-3 col-md-3 nopadding">';
                        var row2 = '<div class="icon-noline"><img class="img-iconfix" src="/Content/Icon/iconFail.png">';
                        var row3 = '<br><br></div></div><div class="col-xs-9">';
                        var row4 = '<b class="lead text-danger">' + resultSearch[i].requestStep + '</b><br> หมายเหตุ: ' + resultSearch[i].libBranch + '<br>วันที่: ' + resultSearch[i].requestDate + ' เวลา: ' + resultSearch[i].requestTime + ' น.</div></div>';
                        var resultRow = row1 + row2 + row3 + row4;
                        break;
                    case "2": // requestSuccess
                        var row1 = '<div class="row"><div class="col-xs-3 col-md-3 nopadding">';
                        var row2 = '<div class="icon"><img class="img-iconfix" src="/Content/Icon/iconPlane.png">';
                        var row3 = '<br><br></div></div><div class="col-xs-9">';
                        var row4 = '<b class="lead text-green-opac">' + resultSearch[i].processStep + '</b><br> เจ้าหน้าที่: ' + resultSearch[i].staffDelivery + '<br>วันที่: ' + resultSearch[i].waitingDate + ' เวลา: ' + resultSearch[i].waitingTime + ' น.</div></div>';
                        var row5 = '<div class="row"><div class="col-xs-3 col-md-3 nopadding">';
                        var row6 = '<div class="icon"><img class="img-iconfix" src="/Content/Icon/iconTime.png">';
                        var row7 = '<br><br></div></div><div class="col-xs-9">';
                        var row8 = '<b class="lead text-green-opac">' + resultSearch[i].processStep + '</b><br> เจ้าหน้าที่: ' + resultSearch[i].staffLib + '<br>วันที่: ' + resultSearch[i].processDate + ' เวลา: ' + resultSearch[i].processTime + ' น.</div></div>';
                        var row9 = '<div class="row"><div class="col-xs-3 col-md-3 nopadding">';
                        var row10 = '<div class="icon-noline"><img class="img-iconfix" src="/Content/Icon/iconTime.png">';
                        var row11 = '<br><br></div></div><div class="col-xs-9">';
                        var row12 = '<b class="lead text-green-opac">' + resultSearch[i].requestStep + '</b><br> สาขา: ' + resultSearch[i].libBranch + '<br>วันที่: ' + resultSearch[i].requestDate + ' เวลา: ' + resultSearch[i].requestTime + ' น.</div></div>';

                        var resultRow = row1 + row2 + row3 + row4 + row5 + row6 + row7 + row8 + row9 + row10 + row11 + row12;

                        break;
                    case "3": //requestNotComplete
                        var row1 = '<div class="row"><div class="col-xs-3 col-md-3 nopadding">';
                        var row2 = '<div class="icon"><img class="img-iconfix" src="/Content/Icon/iconCancle.png">';
                        var row3 = '<br><br></div></div><div class="col-xs-9">';
                        var row4 = '<b class="lead text-danger">' + resultSearch[i].processStep + '</b><br> สาเหตุ: ' + resultSearch[i].staffLib + '<br>วันที่: ' + resultSearch[i].processDate + ' เวลา: ' + resultSearch[i].processTime + ' น.</div></div>';
                        var row5 = '<div class="row"><div class="col-xs-3 col-md-3 nopadding">';
                        var row6 = '<div class="icon-noline"><img class="img-iconfix" src="/Content/Icon/iconTime.png">';
                        var row7 = '<br><br></div></div><div class="col-xs-9">';
                        var row8 = '<b class="lead text-green-opac">' + resultSearch[i].requestStep + '</b><br> สาขา: ' + resultSearch[i].libBranch + '<br>วันที่: ' + resultSearch[i].requestDate + ' เวลา: ' + resultSearch[i].requestTime + ' น.</div></div>';

                        var resultRow = row1 + row2 + row3 + row4 + row5 + row6 + row7 + row8;

                        break;
                    case "4":
                        var row1 = '<div class="row"><div class="col-xs-3 col-md-3 nopadding">';
                        var row2 = '<div class="icon"><img class="img-iconfix" src="/Content/Icon/iconSuccess.png">';
                        var row3 = '<br><br></div></div><div class="col-xs-9">';
                        var row4 = '<b class="lead text-green-opac">' + resultSearch[i].deliverStep + '</b><br> ผู้รับ: ' + resultSearch[i].userName + '<br>วันที่: ' + resultSearch[i].deliverDate + ' เวลา: ' + resultSearch[i].deliverTime + ' น.</div></div>';
                        var row5 = '<div class="row"><div class="col-xs-3 col-md-3 nopadding">';
                        var row6 = '<div class="icon"><img class="img-iconfix" src="/Content/Icon/iconTime.png">';
                        var row7 = '<br><br></div></div><div class="col-xs-9">';
                        var row8 = '<b class="lead text-green-opac">' + resultSearch[i].waitingStep + '</b><br> เจ้าหน้าที่: ' + resultSearch[i].staffDelivery + '<br>วันที่: ' + resultSearch[i].waitingDate + ' เวลา: ' + resultSearch[i].waitingTime + ' น.</div></div>';
                        var row9 = '<div class="row"><div class="col-xs-3 col-md-3 nopadding">';
                        var row10 = '<div class="icon"><img class="img-iconfix" src="/Content/Icon/iconTime.png">';
                        var row11 = '<br><br></div></div><div class="col-xs-9">';
                        var row12 = '<b class="lead text-green-opac">' + resultSearch[i].processStep + '</b><br> เจ้าหน้าที่: ' + resultSearch[i].staffLib + '<br>วันที่: ' + resultSearch[i].processDate + ' เวลา: ' + resultSearch[i].processTime + ' น.</div></div>';
                        var row13 = '<div class="row"><div class="col-xs-3 col-md-3 nopadding">';
                        var row14 = '<div class="icon-noline"><img class="img-iconfix" src="/Content/Icon/iconTime.png">';
                        var row15 = '<br><br></div></div><div class="col-xs-9">';
                        var row16 = '<b class="lead text-green-opac">' + resultSearch[i].requestStep + '</b><br> สาขา: ' + resultSearch[i].libBranch + '<br>วันที่: ' + resultSearch[i].requestDate + ' เวลา: ' + resultSearch[i].requestTime + ' น.</div></div>';

                        var resultRow = row1 + row2 + row3 + row4 + row5 + row6 + row7 + row8 + row9 + row10 + row11 + row12 + row13 + row14 + row15 + row16;
                        break;
                    case "5":
                        var row1 = '<div class="row"><div class="col-xs-3 col-md-3 nopadding">';
                        var row2 = '<div class="icon"><img class="img-iconfix" src="/Content/Icon/iconCancle.png">';
                        var row3 = '<br><br></div></div><div class="col-xs-9">';
                        var row4 = '<b class="lead text-danger">' + resultSearch[i].deliverStep + '</b><br> สาเหตุ: ' + resultSearch[i].userName + '<br>วันที่: ' + resultSearch[i].deliverDate + ' เวลา: ' + resultSearch[i].deliverTime + ' น.</div></div>';
                        var row5 = '<div class="row"><div class="col-xs-3 col-md-3 nopadding">';
                        var row6 = '<div class="icon"><img class="img-iconfix" src="/Content/Icon/iconTime.png">';
                        var row7 = '<br><br></div></div><div class="col-xs-9">';
                        var row8 = '<b class="lead text-green-opac">' + resultSearch[i].waitingStep + '</b><br> เจ้าหน้าที่: ' + resultSearch[i].staffDelivery + '<br>วันที่: ' + resultSearch[i].waitingDate + ' เวลา: ' + resultSearch[i].waitingTime + ' น.</div></div>';
                        var row9 = '<div class="row"><div class="col-xs-3 col-md-3 nopadding">';
                        var row10 = '<div class="icon"><img class="img-iconfix" src="/Content/Icon/iconTime.png">';
                        var row11 = '<br><br></div></div><div class="col-xs-9">';
                        var row12 = '<b class="lead text-green-opac">' + resultSearch[i].processStep + '</b><br> เจ้าหน้าที่: ' + resultSearch[i].staffLib + '<br>วันที่: ' + resultSearch[i].processDate + ' เวลา: ' + resultSearch[i].processTime + ' น.</div></div>';
                        var row13 = '<div class="row"><div class="col-xs-3 col-md-3 nopadding">';
                        var row14 = '<div class="icon-noline"><img class="img-iconfix" src="/Content/Icon/iconTime.png">';
                        var row15 = '<br><br></div></div><div class="col-xs-9">';
                        var row16 = '<b class="lead text-green-opac">' + resultSearch[i].requestStep + '</b><br> สาขา: ' + resultSearch[i].libBranch + '<br>วันที่: ' + resultSearch[i].requestDate + ' เวลา: ' + resultSearch[i].requestTime + ' น.</div></div>';

                        var resultRow = row1 + row2 + row3 + row4 + row5 + row6 + row7 + row8 + row9 + row10 + row11 + row12 + row13 + row14 + row15 + row16;

                }

                let track = '<div class="col-sm-7 col-md-4"><br />' + resultRow + '</div>';

                let QRcode1 = '<div class="visible-lg col-md-4"><br /><div class="row"><div class="col-xs-6"><p class="text-center">Keep Tracking</p>';
                let QRcode2 = '<img class="img-qrcode-maxsize" src="/Content/Image/lineQR.JPG"></div></div></div>';
                let QRcode = QRcode1 + QRcode2;


                let content = contact + track + QRcode;


                $("#main").html(content);
            });

        }

        function failGetContent() {
            alert("web service error");
            //console.log("error");
        }

    });

</script>


<div class="container">