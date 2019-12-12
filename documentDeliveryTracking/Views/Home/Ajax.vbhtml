@Code
    ViewData("Title") = "Ajax"
End Code

<div class="row">
    <div class="col-md-4">
        <h2>Contact </h2>
        <address>
            ID : 59121293<br />
            Name : สันติภาพ ตันประมวล<br />
            Default point : ตึกนวัตกรรม <br>
        </address>

        <address>
            <strong>E-mail:</strong>   @*<a href="mailto:suntiparb.tu@mail.wu.ac.th">*@suntiparb.tu@mail.wu.ac.th</a><br />
        </address>
    </div>

    <div class="col-md-8">
        <h2>Document Delivery Tracking</h2>
        <div class="btn-group">
            <button class="btn btn-primary active">ALL</button>
            <button class="btn btn-primary">Current</button>
            <button class="btn btn-primary">Reject</button>
            <button class="btn btn-primary">Complete</button>
        </div>

        <div class="container-fluid nopadding">

            <hr class="hr-set-margin" />

            <div id="main">
                

                



            </div>


        </div>

    </div>
</div>

<script type="text/javascript">
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
                        barcode = '<b>????: </b>' + resultSearch[i].barcode;
                        iconType = '/Content/Icon/iconDoc.png';
                        locationDelivery = '<a href="'+ resultSearch[i].ddPoint +'" target="_blank">Download</a>';
                }

                switch (resultSearch[i].status) {
                    case "จัดส่งเรียบร้อยแล้ว":
                        buttonEdit = '';
                        buttonReject = '';
                        colorStatus = 'btn-success';
                        break;
                    case "จัดส่งไม่สำเร็จ":
                        buttonEdit = '';
                        buttonReject = '';
                        colorStatus = 'btn-danger';
                        break;
                    case "กำลังร้องขอรายการ":
                        buttonEdit = '<button type="button" class="buttonEdit btn-xs btn btn-primary" data-toggle="modal" data-target="#exampleModalEdit'+i+'"><img src="/Content/Icon/IconEdit.png"></button>';
                        buttonReject = '<button type="button" class="buttonReject btn-xs btn btn-danger" data-toggle="modal" data-target="#exampleModalReject' + i +'"><img src="/Content/Icon/IconReject.png"></button>';
                        colorStatus = 'btn-warning';
                        break;
                    case "Document รอนำส่ง":
                        buttonEdit = '';
                        buttonReject = '';
                        colorStatus = 'btn-warning';
                }

                var model1 = '<div class="modal fade" id="exampleModalScrollable'+i+'" tabindex="-1" role="dialog" aria-labelledby="exampleModalScrollableTitle" aria-hidden="true"><div class="modal-dialog modal-dialog-scrollable" role="document"><div class="modal-content"><div class="modal-header">';
                var model2 = '<h2 class="modal-title text-green-opac" id="exampleModalScrollableTitle">Track & Trace</h2><h5 class="text-header-track-and-trace font-track-round">รอบที่จัดส่ง: 11/11/2019 เวลา: 15:30 น.</h5>';
                var model3 = '<button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button></div><div class="modal-body">555555</div></div></div></div>';


                var content1 = '<div class="row"><div class="col-xs-5 col-sm-3 col-lg-3"><img class="img-clover-book img-thumbnail" src="/'+ cloverBookCheck +'"><br><br></div>';
                var content2 = '<div class="col-sm-8 col-lg-7"><div class="col-xs-7 col-sm-12"><div class="row"><b>Title:</b> <a class="text-info" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682" target="_blank">' + resultSearch[i].title +'</a><br>';
                var content3 =  barcode +'<br><b>Request Date:</b> '+ resultSearch[i].requestDate +'<br /><br><img class="img-thumbnail" src="'+ iconType +'"> &nbsp; &nbsp;: '+locationDelivery+'<br><br></div></div>';
                var content4 = '<div class="col-xs-12"><div class="row"><div class="col-xs-8 col-sm-6"><div class="row"><button type="button" class="btn '+colorStatus+'" data-toggle="modal" data-target="#exampleModalScrollable'+i+'">สถานะ: '+ resultSearch[i].status +'</button>'+model1+model2+model3+'</div></div>';
                var content5 = '<div class="col-xs-4"><div class="row">'+ buttonEdit +' &nbsp;';
                var content6 =  buttonReject+'</div></div></div></div></div>';
                var content7 = '<div class="visible-lg col-lg-2 nopadding"><img class="img-qrcode-maxsize" src="/Content/Image/lineQR.JPG"></div></div> <hr class="hr-set-margin" />';
                var content = content1 + content2 + content3 + content4 + content5 + content6 +content7 ;

                $("#main").append(content);

            });
        }

        function failGetContent() {
            alert("web service error");
        }
    });
</script>



