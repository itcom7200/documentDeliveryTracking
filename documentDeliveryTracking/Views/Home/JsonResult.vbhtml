@Code
    Layout = Nothing
    ViewData("Title") = "JsonResult"
End Code


@*<div class="container">
        <h2>Test ViewData</h2>

        @For Each item In ViewData.Model
            @<div>@item("cloverBook")</div>
            @<div>@item("title")</div>
        Next

        <p>

        </p>
    </div>*@

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
    </div>

    <div class="col-md-8">
        <h2>DD Tracking </h2>
        <div class="btn-group">
            <button class="btn btn-primary active">ALL</button>
            <button class="btn btn-primary">Current</button>
            <button class="btn btn-primary">Reject</button>
            <button class="btn btn-primary">Complete</button>
        </div>

        <div class="container-fluid nopadding">

            <hr class="hr-set-margin" />

            <div id="main">
                @For Each item In ViewData.Model
                    @<div class="row">
                        <div Class="col-xs-5 col-sm-3 col-lg-3">
                            <img Class="img-clover-book img-thumbnail" src="~/@item("cloverBook")">
                            <br> <br>
                        </div>
                        <div Class="col-sm-8 col-lg-7">
                            <div Class="col-xs-7 col-sm-12">
                                <div Class="row">
                                    <b> Title :    </b> <a class="text-info" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682"
                                                           target="_blank">@item("title")</a><br>
                                    <b> Barcode :    </b> B59121210<br>
                                    <b> Request Date:</b> 12/08/2528<br><br />
                                    <b> Price :    </b> 150 บาท <br>
                                    @*@select Case item("cloverBook")
                                        Case

                                    End Select*@    

                                    <img Class="img-thumbnail" src="~/Content/Icon/iconCar.png"> &nbsp; &nbsp;: เรียนรวม5
                                    <br> <br>
                                </div>
                            </div>
                        </div>

                    </div>

                Next
                @*<div Class="row">
                        <div Class="col-xs-5 col-sm-3 col-lg-3">
                            <img Class="img-clover-book img-thumbnail" src="~/Content/Image/bookRichdad.jpg">
                            <br> <br>
                        </div>
                        <div Class="col-sm-8 col-lg-7">
                            <div Class="col-xs-7 col-sm-12">
                                <div Class="row">
                                    <b> Title :    </b> <a class="text-info" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682"
                                                     target="_blank">พ่อรวยสอนลูก : เงินสี่ด้าน / คิโยซากิ, โรเบิร์ต ที</a><br>
                                    <b> Barcode :    </b> B59121210<br>
                                    <b> Request Date:</b> 12/08/2528<br><br />
                                    <b> Price :    </b> 150 บาท <br>
                                    <img Class="img-thumbnail" src="~/Content/Icon/iconCar.png"> &nbsp; &nbsp;: เรียนรวม5
                                    <br> <br>
                                </div>
                            </div>
                            <div Class="col-xs-12">
                                <div Class="row">
                                    <div Class="col-xs-8 col-sm-6">
                                        <div Class="row">
                                            <!-- Button -->
                                            <Button type = "button" Class="btn btn-warning" data-toggle="modal" data-target="#exampleModalScrollable3">
                                                สถานะ: กำลังร้องขอรายการ
                                            </button>
                                            <!-- Modal -->
                                            <div Class="modal fade" id="exampleModalScrollable3" tabindex="-1" role="dialog" aria-labelledby="exampleModalScrollableTitle" aria-hidden="true">
                                                <div Class="modal-dialog modal-dialog-scrollable" role="document">
                                                    <div Class="modal-content">
                                                        <div Class="modal-header">
                                                            <h2 Class="modal-title text-green-opac" id="exampleModalScrollableTitle">Track & Trace</h2>
                                                            <h5 Class="text-header-track-and-trace font-track-round">รอบที่จัดส่ง: 11/11/2019 เวลา: 15:30 น.</h5>
                                                            <Button type = "button" Class="close" data-dismiss="modal" aria-label="Close">
                                                                <span aria-hidden="true">&times;</span>
                                                            </button>
                                                        </div>
                                                        <div Class="modal-body">
                                                            <!-- start body textbox -->
                                                            <div Class="row">
                                                                <div Class="col-xs-3 col-sm-2 col-md-2 nopadding">
                                                                    <div Class="icon-noline">
                                                                        <img Class="img-iconfix" src="~/Content/Icon/iconTime.png">
                                                                        <br> <br>
                                                                    </div>
                                                                </div>
                                                                <div Class="col-xs-8">
                                                                    <b Class="lead text-green-opac">รับคำร้องขอ</b><br>
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

                                    <div Class="col-xs-4">
                                        <div Class="row">
                                            <!-- Button trigger modal (Edit model)  -->
                                            <Button type = "button" Class="btn-xs btn btn-primary" data-toggle="modal" data-target="#exampleModalEdit1">
                                                <img src = "~/Content/Icon/IconEdit.png" >
                                            </button>

                                            <!-- Modal -->
                                            <div Class="modal fade" id="exampleModalEdit1" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                                                <div Class="modal-dialog" role="document">
                                                    <div Class="modal-content">
                                                        <div Class="modal-header">
                                                            <h5 Class="modal-title" id="exampleModalLabel">Edit your Request</h5>
                                                            <Button type = "button" Class="close" data-dismiss="modal" aria-label="Close">
                                                                <span aria-hidden="true">&times;</span>
                                                            </button>
                                                        </div>
                                                        <div Class="modal-body">
                                                            <div Class="form-group">
                                                                <Label for="test1">Text:</label>
                                                                <input type = "text" Class="form-control" id="usr">
                                                            </div>
                                                            <div Class="form-group">
                                                                <Label for="test2">Text:</label>
                                                                <input type = "text" Class="form-control" id="pwd">
                                                            </div>
                                                        </div>

                                                        <div Class="modal-footer">
                                                            <Button type = "button" Class="btn btn-success" data-dismiss="modal">Save</button>
                                                            <Button type = "button" Class="btn " data-dismiss="modal">Cancle</button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div><!-- div close modal-->
                                            <!-- Button trigger modal (Reject model)  -->
                                            <Button type = "button" Class="btn-xs btn btn-danger" data-toggle="modal" data-target="#exampleModalReject1">
                                                <img src = "~/Content/Icon/IconReject.png" >
                                            </button>

                                            <!-- Modal -->
                                            <div Class="modal fade" id="exampleModalReject1" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                                                <div Class="modal-dialog" role="document">
                                                    <div Class="modal-content">
                                                        <div Class="modal-header">
                                                            <h5 Class="modal-title" id="exampleModalLabel">Reject Confirms</h5>
                                                            <Button type = "button" Class="close" data-dismiss="modal" aria-label="Close">
                                                                <span aria-hidden="true">&times;</span>
                                                            </button>
                                                        </div>
                                                        <div Class="modal-body">
                                                            Are you sure you want To Do this !
                                                        </div>
                                                        <div Class="modal-footer">
                                                            <Button type = "button" Class="btn btn-danger" data-dismiss="modal">Reject</button>
                                                            <Button type = "button" Class="btn " data-dismiss="modal">Cancle</button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div><!-- div close modal-->
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div Class="visible-lg col-lg-2">
                            <img Class="img-qrcode-maxsize" src="~/Content/Image/lineQR.JPG">
                        </div>


                    </div>*@

                <hr Class="hr-set-margin" />



            </div>


        </div>

    </div>
</div>


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
                    let row = '<div class="row">';
                    let closeRow = '</div>';
                    let colCloverBook = '<div class="col-xs-5 col-sm-3 col-lg-3"><img class="img-clover-book img-thumbnail" src="/'+resultSearch[i].cloverBook+'"><br><br></div>';
                    let colTracking = '<div class="col-sm-8 col-lg-7">';
                    let colInfo = '<div class="col-xs-7 col-sm-12">';
                    let title = '<b>Title:</b> <a class="text-info" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682" target="_blank">'+ resultSearch[i].title+ '</a><br>';
                    let barcode = '<b>Barcode:</b> '+resultSearch[i].barcode+'<br><b>Request Date:</b> 12/08/2528<br><br />';
                    let iconType = '<img class="img-thumbnail" src="/Content/Icon/iconCar.png"> &nbsp; &nbsp;: เรียนรวม5<br><br>';
                    let colStatus = '<div class="col-xs-12">';
                    let colButton = '<div class="col-xs-8 col-sm-6">';
                    let ButtonStatus = '<button type="button" class="btn btn-warning" data-toggle="modal" data-target="#exampleModalScrollable'+i+'">สถานะ: กำลังร้องขอรายการ</button >';
                    let divModel = '<div class="modal fade" id="exampleModalScrollable'+i+'" tabindex="-1" role="dialog" aria-labelledby="exampleModalScrollableTitle" aria-hidden="true"><div class="modal-dialog modal-dialog-scrollable" role="document">';
                    let divModelContent = '<div class="modal-content"><div class="modal-header"><h2 class="modal-title text-green-opac" id="exampleModalScrollableTitle">Track & Trace</h2>';
                    let closeModel = '<h5 class="text-header-track-and-trace font-track-round">รอบที่จัดส่ง: 11/11/2019 เวลา: 15:30 น.</h5><button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button></div>';
                    let modelBody = '<div class="modal-body"><div class="row"><div class="col-xs-3 col-sm-2 col-md-2 nopadding"><div class="icon-noline">';
                    let imgIcon = '<img class="img-iconfix" src="/Content/Icon/iconTime.png"><br><br></div></div><div class="col-xs-8">';
                    let infoTracking = '<b class="lead text-green-opac">รับคำร้องขอ</b><br> สาขา: หอสมุดกลาง<br> วันที่: 11/11/2019 เวลา: 10:56 น.</div></div></div></div></div></div></div></div>';
                    let hrSet = '<hr class="hr-set-margin" />';
                    let contentStatus = colStatus + row + colButton + row + ButtonStatus + divModel + divModelContent + closeModel + modelBody + imgIcon + infoTracking + closeRow + closeRow + closeRow;
                    let contentTracking = colTracking + colInfo + row + title + barcode + iconType + closeRow + closeRow + contentStatus + closeRow;
                    let content = row + colCloverBook + contentTracking + closeRow + hrSet;
                    $("#main").append(content);

                    console.log(content);
                });
            }
            function failGetContent(request, status, error) {
                alert("web service error");
            }


        });

    </script>*@

