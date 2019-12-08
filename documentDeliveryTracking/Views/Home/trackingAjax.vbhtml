@Code
    ViewData("Title") = "trackingAjax"
End Code

<h2>@ViewData("Message")</h2>
<div class="row">
    <div class="col-md-4">
        <h2>Contact </h2>
        <p>Use this area to provide additional information.</p>
        <address>
            ID : 59121293<br />
            Name : สันติภาพ ตันประมวล<br />
            Default point : ตึกนวัตกรรม <br>

        </address>

        <address>
            <strong>E-mail:</strong>   <a href="mailto:suntiparb.tu@mail.wu.ac.th">suntiparb.tu@mail.wu.ac.th</a><br />

        </address>

        <button class="btn" onclick="getTest()">Get Json</button>

        <p class="test"></p>





    </div>
    <div class="col-md-8">
        <h2>Document Delivery Tracking </h2>
        <div class="col-xs-12">
        </div>
        <div class="btn-group btn-toggle" data-toggle="buttons">
            <label class="btn btn-primary active">
                <input name="options" value="option1" type="radio"> ALL(4)
            </label>
            <label class="btn btn-primary">
                <input name="options" value="option2" type="radio"> Current(2)
            </label>
            <label class="btn btn-primary">
                <input name="options" value="option3" type="radio"> Reject(1)
            </label>
            <label class="btn btn-primary">
                <input name="options" value="option3" type="radio"> Complete(1)
            </label>
        </div>





        <div class="container-fluid">

            <hr class="hr-set-margin" />


            <div class="row">
                <div class="col-xs-5 col-sm-3 col-lg-3">
                    <img class="cloverBook img-clover-book img-thumbnail" src="~/Content/Image/bookRichdad.jpg">
                    <br><br>
                </div>
                <div class="col-sm-8 col-lg-7">
                    <div class="col-xs-7 col-sm-12">
                        <div class="row">
                            <b>Title:</b> <a class="text-info title" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682"
                                             target="_blank"></a><br>
                            <b>Barcode:</b> B59121210<br>
                            <b>Request Date:</b> 12/08/2528<br><br />
                            @*<b>Price:</b> 150 บาท <br>*@
                            <img class="img-thumbnail" src="~/Content/Icon/iconCar.png"> &nbsp; &nbsp;: เรียนรวม5
                            <br><br>
                        </div>
                    </div>
                    <div class="col-xs-12">
                        <div class="row">
                            <div class="col-xs-8 col-sm-6">
                                <div class="row">
                                    <!-- Button -->
                                    <button type="button" class="btn btn-warning" data-toggle="modal" data-target="#exampleModalScrollable3">
                                        สถานะ: กำลังร้องขอรายการ
                                    </button>
                                    <!-- Modal -->
                                    <div class="modal fade" id="exampleModalScrollable3" tabindex="-1" role="dialog" aria-labelledby="exampleModalScrollableTitle" aria-hidden="true">
                                        <div class="modal-dialog modal-dialog-scrollable" role="document">
                                            <div class="modal-content">
                                                <div class="modal-header">
                                                    <h2 class="modal-title text-green-opac" id="exampleModalScrollableTitle">Track & Trace</h2>
                                                    <h5 class="text-header-track-and-trace font-track-round">รอบที่จัดส่ง: 11/11/2019 เวลา: 15:30 น.</h5>
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

                            <div class="col-xs-4">
                                <div class="row">
                                    <!-- Button trigger modal (Edit model)  -->
                                    <button type="button" class="btn-xs btn btn-primary" data-toggle="modal" data-target="#exampleModalEdit1">
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
                                    <button type="button" class="btn-xs btn btn-danger" data-toggle="modal" data-target="#exampleModalReject1">
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
                    <img class="img-qrcode-maxsize" src="~/Content/Image/lineQR.JPG">
                </div>


            </div>


            <hr class="hr-set-margin" />



        </div>




    </div>

</div>


<script>
    function getTest() {
        $.ajax({
            type: "POST",
            url: "http://localhost:62597/WebService1.asmx/GetBook",
            // data: "id=" + idCompany,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: SuccessGetMeta,
            error: ErrorGetMeta
        });

    }


    function SuccessGetMeta(data) {
        resultSearch = $.parseJSON(data.d);
        $.each(resultSearch, function (i, item) {    //.each คือคำสั่ง loop
            var m = document.createElement('meta');
            m.cloverBook = resultSearch[i].cloverBook;
            m.title = resultSearch[i].title;
            m.barcode = resultSearch[i].barcode;
            m.requestDate = resultSearch[i].requestDate;
            m.ddType = resultSearch[i].ddType;
            m.ddPoint = resultSearch[i].ddPoint;
            m.status = resultSearch[i].status;
            m.deliveryDate = resultSearch[i].deliveryDate;
            m.deliveryTime = resultSearch[i].deliveryTime;
            $(".test").html("Hello <b>world</b>!<br>");
            $(".title").html(m.title);
        });
    }
    function ErrorGetMeta(request, status, error) {

        alert("Error webservice");
        //var m = document.createElement('meta');
        //m.name = 'og:image';
        //m.content = '../Images/NoImageBook.jpg';
        //document.head.appendChild(m);
    }

</script>



