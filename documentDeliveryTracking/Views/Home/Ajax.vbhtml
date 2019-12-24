@Code
    ViewData("Title") = "Ajax"
End Code

<div class="row">
    <div class="col-md-4">
        <h2>Contact </h2>
        <address>
            <b>ID : </b>59121293<br />
            <b>Name : </b>สันติภาพ ตันประมวล<br />
            <b>Default point : </b>ตึกนวัตกรรม <br>
            @*<b>ที่อยู่ในการจัดส่ง</b> :*@
        </address>

        <address>
            <strong>E-mail:</strong>   @*<a href="mailto:suntiparb.tu@mail.wu.ac.th">*@suntiparb.tu@mail.wu.ac.th</a><br />
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
        $.get("viewAll", function (data) {
            $("#main").html(data);

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

        $("#getAll").click(function () {
            $.get("viewAll", function (data) {
                $("#main").html(data);
            });
        });

        $("#getCurrent").click(function () {
            $.get("viewCurrent", function (data) {
                $("#main").html(data);
            });
        });

        $("#getReject").click(function () {
            $.get("viewReject", function (data) {
                $("#main").html(data);
            });
        });

        $("#getComplete").click(function () {
            $.get("viewComplete", function (data) {
                $("#main").html(data);
            });
        });

    });
</script>



@*<script type="text/javascript">
        $(document).ready(function () {
            $('.btn-group').on('click', '.btn', function () {
                $(this).addClass('active').siblings().removeClass('active');
            });

            $.ajax({
                type: "POST",
                url: "http://localhost:62597/WebService1.asmx/GetBook",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: getContent,
                error: failGetContent
            });

            function getContent(data) {
                resultSearch = $.parseJSON(data.d);
                $.each(resultSearch, function (i, item) {

                    switch (resultSearch[i].cloverBook) {
                        case null:
                        case "":
                            cloverBookCheck = 'Content/Image/defult.jpg';
                            break;
                        default:
                            cloverBookCheck = resultSearch[i].cloverBook;
                    }

                    switch (resultSearch[i].ddType) {
                        case "Docs":
                            barcode = '<b>Barcode: </b>' + resultSearch[i].barcode;
                            iconType = '/Content/Icon/iconCar.png';
                            locationDelivery = resultSearch[i].ddPoint;
                            break;
                        case "File":
                            barcode = '<b>eISBN: </b>' + resultSearch[i].barcode;
                            iconType = '/Content/Icon/iconDoc.png';
                            locationDelivery = '<a href="'+ resultSearch[i].ddPoint +'" target="_blank">Download</a>';
                    }

                    switch (resultSearch[i].status) {
                        case "0": // startRequest
                            var row1 = '<div class="row"><div class="col-xs-3 col-md-3 nopadding">';
                            var row2 = '<div class="icon-noline"><img class="img-iconfix" src="/Content/Icon/iconTime.png">';
                            var row3 = '<br><br></div></div><div class="col-xs-9">';
                            var row4 = '<b class="lead text-green-opac">' + resultSearch[i].requestStep + '</b><br> สาขา: ' + resultSearch[i].libBranch + '<br>วันที่: ' + resultSearch[i].requestDate + ' เวลา: ' + resultSearch[i].requestTime + ' น.</div></div>';
                            var resultRow = row1 + row2 + row3 + row4;

                            var buttonEdit = '<button type="button" class="buttonEdit btn-xs btn btn-primary" data-toggle="modal" data-target="#exampleModalEdit' + i + '"><img src="/Content/Icon/IconEdit.png"></button>';
                            var buttonReject = '<button type="button" class="buttonReject btn-xs btn btn-danger" data-toggle="modal" data-target="#exampleModalReject' + i + '"><img src="/Content/Icon/IconReject.png"></button>';
                            var colorStatus = 'btn-warning';
                            var deliverStatus = 'กำลังร้องขอรายการ';

                            break;

                        case "1": // rejectRequest
                            var row1 = '<div class="row"><div class="col-xs-3 col-md-3 nopadding">';
                            var row2 = '<div class="icon-noline"><img class="img-iconfix" src="/Content/Icon/iconCancle.png">';
                            var row3 = '<br><br></div></div><div class="col-xs-9">';
                            var row4 = '<b class="lead text-danger">' + resultSearch[i].requestStep + '</b><br> หมายเหตุ: ' + resultSearch[i].libBranch + '<br>วันที่: ' + resultSearch[i].requestDate + ' เวลา: ' + resultSearch[i].requestTime + ' น.</div></div>';
                            var resultRow = row1 + row2 + row3 + row4;
                            var buttonEdit = '';
                            var buttonReject = '';
                            var colorStatus = 'btn-danger';
                            var deliverStatus = 'ยกเลิกคำขอโดยผู้ใช้';
                            
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

                            var buttonEdit = '';
                            var buttonReject = '';
                            var colorStatus = 'btn-warning';
                            var deliverStatus = 'Document รอนำส่ง';


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
                            var buttonEdit = '';
                            var buttonReject = '';
                            var colorStatus = 'btn-danger';
                            var deliverStatus = 'ไม่สามารถให้บริการได้';

                            break;
                        case "4": //deliveryComplete
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
                            var buttonEdit = '';
                            var buttonReject = '';
                            var colorStatus = 'btn-success';
                            var deliverStatus = 'จัดส่งเรียบร้อยแล้ว';

                            var resultRow = row1 + row2 + row3 + row4 + row5 + row6 + row7 + row8 + row9 + row10 + row11 + row12 + row13 + row14 + row15 + row16;
                            if (resultSearch[i].ddType === "File") {
                                var row4 = '<b class="lead text-green-opac">' + resultSearch[i].deliverStep + '</b><br> email: ' + resultSearch[i].userName + '<br>วันที่: ' + resultSearch[i].deliverDate + ' เวลา: ' + resultSearch[i].deliverTime + ' น.</div></div>';

                                var resultRow = row1 + row2 + row3 + row4 + row9 + row10 + row11 + row12 + row13 + row14 + row15 + row16;
                            }

                            break;
                        case "5": //deliveryNotComplete
                            var row1 = '<div class="row"><div class="col-xs-3 col-md-3 nopadding">';
                            var row2 = '<div class="icon"><img class="img-iconfix" src="/Content/Icon/iconFail.png">';
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
                            var buttonEdit = '';
                            var buttonReject = '';
                            var colorStatus = 'btn-danger';
                            var deliverStatus = 'จัดส่งไม่สำเร็จ';

                            var resultRow = row1 + row2 + row3 + row4 + row5 + row6 + row7 + row8 + row9 + row10 + row11 + row12 + row13 + row14 + row15 + row16;

                    }





                    var contentModel = resultRow;

                    var model1 = '<div class="modal fade" id="exampleModalScrollable'+i+'" tabindex="-1" role="dialog" aria-labelledby="exampleModalScrollableTitle" aria-hidden="true"><div class="modal-dialog modal-dialog-scrollable" role="document"><div class="modal-content"><div class="modal-header">';
                    var model2 = '<h2 class="modal-title text-green-opac" id="exampleModalScrollableTitle">Track & Trace</h2><h5 class="text-header-track-and-trace font-track-round">รอบที่จัดส่ง: 11/11/2019 เวลา: 15:30 น.</h5>';
                    var model3 = '<button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button></div><div class="modal-body">'+contentModel+'</div></div></div></div>';
                    var model = model1 + model2 + model3;

                    var content1 = '<hr class="hr-set-margin" /> <div class="row"><div class="col-xs-5 col-sm-3 col-lg-3"><img class="img-clover-book img-thumbnail" src="/'+ cloverBookCheck +'"><br><br></div>';
                    var content2 = '<div class="col-sm-8 col-lg-7"><div class="col-xs-7 col-sm-12"><div class="row"><b>Title:</b> <a class="text-info" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682" target="_blank">' + resultSearch[i].title +'</a><br>';
                    var content3 =  barcode +'<br><b>Request Date:</b> '+ resultSearch[i].requestDate +'<br /><br><img class="img-thumbnail" src="'+ iconType +'"> &nbsp; &nbsp;: '+locationDelivery+'<br><br></div></div>';
                    var content4 = '<div class="col-xs-12"><div class="row"><div class="col-xs-8 col-sm-6"><div class="row"><button type="button" class="btn '+colorStatus+'" data-toggle="modal" data-target="#exampleModalScrollable'+i+'">สถานะ: '+ deliverStatus +'</button>'+ model +'</div></div>';
                    var content5 = '<div class="col-xs-4"><div class="row">'+ buttonEdit +'<!-- ใส่modalEdit --> &nbsp;';
                    var content6 =  buttonReject+'</div></div></div></div></div>';
                    var content7 = '<div class="visible-lg col-lg-2 nopadding"><img class="img-qrcode-maxsize" src="/Content/Image/lineQR.JPG"></div></div> ';
                    var content = content1 + content2 + content3 + content4 + content5 + content6 +content7 ;

                    $("#main").append(content);

                });
            }

            function failGetContent() {
                alert("web service error");
            }
        });
    </script>*@
