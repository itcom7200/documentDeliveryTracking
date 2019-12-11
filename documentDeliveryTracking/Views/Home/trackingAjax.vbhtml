﻿@Code
    ViewData("Title") = "trackingAjax"
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
            <strong>E-mail:</strong>   <a href="mailto:suntiparb.tu@mail.wu.ac.th">suntiparb.tu@mail.wu.ac.th</a><br />
        </address>

        <button onclick="testLoop()">1</button>
        <div id="main">

        </div>









    </div>
    <div class="col-md-8">
        <h2>DD Tracking </h2>
        <div class="btn-group">
            <button class="btn btn-primary active" onclick="getTest()">ALL</button>
            <button class="btn btn-primary">Current</button>
            <button class="btn btn-primary">Reject</button>
            <button class="btn btn-primary">Complete</button>
        </div>





        <div class="container-fluid nopadding">

            <hr class="hr-set-margin" />

            <div class="row">
                <div class="col-xs-5 col-sm-3 col-lg-3">
                    <div class="cloverBook">

                    </div>
                    <br />
                </div>
                <div class="col-sm-8 col-lg-7">
                    <div class="col-xs-7 col-sm-12">
                        <div class="row">
                            <div class="title"></div>
                            <div class="barcode"></div>
                            <div class="requestDate"></div>


                            @*<b>Price:</b> 150 บาท <br>*@
                            <div class="ddType">

                            </div>

                        </div>
                    </div>
                    <div class="col-xs-12">
                        <div class="row">
                            <div class="col-xs-8 col-sm-6">
                                <div class="row">
                                    <!-- Button -->
                                    <div class="buttonStatus">

                                    </div>
                                    <!-- Modal -->
                                    <div class="modal fade" id="exampleModalScrollable3" tabindex="-1" role="dialog" aria-labelledby="exampleModalScrollableTitle" aria-hidden="true">
                                        <div class="modal-dialog modal-dialog-scrollable" role="document">
                                            <div class="modal-content">
                                                <div class="modal-header">
                                                    <h2 class="modal-title text-green-opac" id="exampleModalScrollableTitle">Track & Trace</h2>
                                                    <h5 class="deliveryRound text-header-track-and-trace font-track-round"></h5>
                                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                                        <span aria-hidden="true">&times;</span>
                                                    </button>
                                                </div>
                                                <div class="modal-body">
                                                    <!-- start body textbox -->
                                                    <div class="row">
                                                        <div class="col-xs-3 col-sm-2 col-md-2 nopadding">
                                                            <div class="icon-noline">
                                                                <img class="img-iconfix" src="~/Content/Icon/iconTime.png">
                                                                <br><br>
                                                            </div>
                                                        </div>
                                                        <div class="col-xs-8">
                                                            <b class="lead text-green-opac">รับคำร้องขอ</b><br>
                                                            <div class="libBranch"></div>
                                                            <div class="requestTime"></div>
                                                            @*วันที่: 11/11/2019 เวลา: 10:56 น.*@
                                                        </div>
                                                    </div>

                                                </div> <!-- modal-body -->

                                            </div>
                                        </div>
                                    </div>
                                    <!-- Button&Model -->
                                </div>

                            </div>

                            <div class="col-xs-4">
                                <div class="row">
                                    <!-- Button trigger modal (Edit model)  -->
                                    <button type="button" class="buttonEdit btn-xs btn btn-primary" data-toggle="modal" data-target="#exampleModalEdit1">
                                        <img src="~/Content/Icon/IconEdit.png">
                                    </button>

                                    <!-- Modal -->
                                    <div class="modal fade" id="exampleModalEdit1" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                                        <div class="modal-dialog" role="document">
                                            <div class="modal-content">
                                                <div class="modal-header">
                                                    <h5 class="modal-title" id="exampleModalLabel">Edit your Request</h5>
                                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                                        <span aria-hidden="true">&times;</span>
                                                    </button>
                                                </div>
                                                <div class="modal-body">
                                                    <div class="form-group">
                                                        <label for="test1">Text:</label>
                                                        <input type="text" class="form-control" id="usr">
                                                    </div>
                                                    <div class="form-group">
                                                        <label for="test2">Text:</label>
                                                        <input type="text" class="form-control" id="pwd">
                                                    </div>
                                                </div>

                                                <div class="modal-footer">
                                                    <button type="button" class="btn btn-success" data-dismiss="modal">Save</button>
                                                    <button type="button" class="btn " data-dismiss="modal">Cancle</button>
                                                </div>
                                            </div>
                                        </div>
                                    </div><!-- div close modal-->
                                    <!-- Button trigger modal (Reject model)  -->
                                    <button type="button" class="buttonReject btn-xs btn btn-danger" data-toggle="modal" data-target="#exampleModalReject1">
                                        <img src="~/Content/Icon/IconReject.png">
                                    </button>

                                    <!-- Modal -->
                                    <div class="modal fade" id="exampleModalReject1" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                                        <div class="modal-dialog" role="document">
                                            <div class="modal-content">
                                                <div class="modal-header">
                                                    <h5 class="modal-title" id="exampleModalLabel">Reject Confirms</h5>
                                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                                        <span aria-hidden="true">&times;</span>
                                                    </button>
                                                </div>
                                                <div class="modal-body">
                                                    Are you sure you want to do this !
                                                </div>
                                                <div class="modal-footer">
                                                    <button type="button" class="btn btn-danger" data-dismiss="modal">Reject</button>
                                                    <button type="button" class="btn " data-dismiss="modal">Cancle</button>
                                                </div>
                                            </div>
                                        </div>
                                    </div><!-- div close modal-->

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="visible-lg col-lg-2">
                    <img id="QRcode" class="img-qrcode-maxsize" src="~/Content/Image/lineQR.JPG">
                </div>


            </div>









        </div>




    </div>

</div>




<script>
    $('.btn-group').on('click', '.btn', function () {
        $(this).addClass('active').siblings().removeClass('active');
    });

    $(".buttonEdit").hide();
    $(".buttonReject").hide();
    $("#QRcode").hide();

    $.ajax({
        type: "POST",
        url: "http://localhost:62597/WebService1.asmx/GetBook",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: getTitle,
        error: failTitle
    });

    function getTest() {
        $.ajax({
            type: "POST",
            url: "http://localhost:62597/WebService1.asmx/GetBook",
            // data: "id=" + idCompany,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: SuccessGetMeta,
            //success: testLoop,
            error: ErrorGetMeta
        });


    }


    //function SuccessGetMeta(data) {
    //    resultSearch = $.parseJSON(data.d);
    //    console.log(resultSearch);
    //    $.each(resultSearch, function (i, item) {
    //        console.log(i);
    //        var m = document.createElement('meta');
    //        m.cloverBook = resultSearch[i].cloverBook;
    //        m.title = resultSearch[i].title;
    //        m.barcode = resultSearch[i].barcode;
    //        m.requestDate = resultSearch[i].requestDate;
    //        m.ddType = resultSearch[i].ddType;
    //        m.ddPoint = resultSearch[i].ddPoint;
    //        m.status = resultSearch[i].status;
    //        m.waitingDate = resultSearch[i].waitingDate;
    //        m.waitingTime = resultSearch[i].waitingTime;
    //        m.requestStep = resultSearch[i].requestStep;
    //        m.libBranch = resultSearch[i].libBranch;
    //        m.requestTime = resultSearch[i].requestTime;

    //        var cloverBookPath = '<img class="img-clover-book img-thumbnail" src="/' + m.cloverBook + '">';
    //        var ddTypePath = '<img class="img-thumbnail" src="/' + m.ddType + '"> &nbsp; &nbsp;: ' + m.ddPoint + ' <br><br>';
    //        $(".cloverBook").html(cloverBookPath);
    //        $(".title").html('<b>Title:</b> <a class="text-info" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682" target = "_blank" >' + m.title + '</a > <br>')
    //        $(".barcode").html('<b>Barcode:</b> ' + m.barcode + '<br>');
    //        $(".requestDate").html('<b>Request Date:</b>' + m.requestDate + '<br><br />');
    //        $(".ddType").html(ddTypePath);
    //        $(".buttonStatus").html('<button type="button" class="btn btn-warning" data-toggle="modal" data-target="#exampleModalScrollable3">สถานะ: ' + m.status + '</button >');
    //        $(".deliveryRound").html('รอบที่จัดส่ง: ' + m.waitingDate + ' เวลา: ' + m.waitingTime + ' น.');
    //        $(".libBranch").html('<b>สาขา: </b>' + m.libBranch);
    //        $(".requestTime").html('<b>วันที่: </b>' + m.requestDate + '<b> เวลา: </b>' + m.requestTime + ' น.');


    //        $(".buttonEdit").show();
    //        $(".buttonReject").show();
    //        $("#QRcode").show();
    //    });
    //}
    function ErrorGetMeta(request, status, error) {
        alert("Error webservice");
    }

    function testLoop() {
        $.ajax({
            type: "POST",
            url: "http://localhost:62597/WebService1.asmx/GetBook",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: getTitle,
            error: failTitle
        });
    }
    function getTitle(title) {
        resultTitle = $.parseJSON(title.d);
        $.each(resultTitle, function (i, item) {
            var s = "<p>" + resultTitle[i].title + "</p><br>";
            //var m = document.createElement('meta');
            //m.cloverBook = resultTitle[i].cloverBook;
            $("#main").append(s);
        });
    }


    
    function failTitle(request, status, error) {
        alert("failTitle");
    }


</script>