﻿@Code
    ViewData("Title") = "Tracking"
End Code
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
                    <img class="img-clover-book img-thumbnail" src="~/Content/Image/bookRichdad.jpg">
                    <br><br>
                </div>
                <div class="col-sm-8 col-lg-7">
                    <div class="col-xs-7 col-sm-12">
                        <div class="row">
                            <b>Title:</b> <a class="text-info" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682"
                                             target="_blank">พ่อรวยสอนลูก : เงินสี่ด้าน / คิโยซากิ, โรเบิร์ต ที</a><br>
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

            <div class="row">
                <div class="col-xs-5 col-sm-3 col-lg-3">
                    <img class="img-clover-book img-thumbnail" src="~/Content/Image/116014-fc-a.jpg">
                    <br><br>
                </div>
                <div class="col-sm-8 col-lg-7">
                    <div class="col-xs-7 col-sm-12">
                        <div class="row">
                            <b>Title:</b> <a class="text-info" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682"
                                             target="_blank">คิดมุมกลับ ปรับชีวิตให้เป็นบวก = Flip it /เฮปเพลล์, ไมเคิล</a><br>
                            <b>Barcode:</b> B59121210<br>
                            <b>Request Date:</b> 12/08/2528<br><br>
                            <img class="img-thumbnail" src="~/Content/Icon/iconCar.png"> &nbsp; &nbsp;: เรียนรวม5
                            <br><br>
                        </div>
                    </div>
                    <div class="col-xs-12">
                        <div class="row">
                            <div class="col-xs-7 col-sm-6">
                                <div class="row">
                                    <!-- Button -->
                                    <button type="button" class="btn btn-warning" data-toggle="modal" data-target="#exampleModalScrollable2">
                                        สถานะ : Document รอนำส่ง
                                    </button>
                                    <!-- Modal -->
                                    <div class="modal fade" id="exampleModalScrollable2" tabindex="-1" role="dialog" aria-labelledby="exampleModalScrollableTitle" aria-hidden="true">
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
                                                                <img class="img-iconfix" src="~/Content/Icon/iconPlane.png">
                                                                <br><br>
                                                            </div>
                                                        </div>
                                                        <div class="col-xs-8">
                                                            <b class="lead text-green-opac">Document รอนำส่ง</b><br>
                                                            เจ้าหน้าที่: WU lineman <br>
                                                            วันที่: 11/11/2019 เวลา: 15:30 น.
                                                        </div>
                                                    </div>
                                                    <div class="row">
                                                        <div class="col-xs-3 col-sm-2 col-md-2 nopadding">
                                                            <div class="icon">
                                                                <img class="img-iconfix" src="~/Content/Icon/iconTime.png">
                                                                <br><br>
                                                            </div>
                                                        </div>
                                                        <div class="col-xs-8">
                                                            <b class="lead text-green-opac">ทำรายการเรียบร้อย</b><br>
                                                            เจ้าหน้าที่: staff WU   <br>
                                                            วันที่: 11/11/2019 เวลา: 11:56 น.
                                                        </div>
                                                    </div>
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

                            <div class="col-xs-5">

                            </div>
                        </div>
                    </div>
                </div>
                <div class="visible-lg col-lg-2">
                    <img class="img-qrcode-maxsize" src="~/Content/Image/lineQR.JPG">
                </div>
                <hr />

            </div>

            <hr class="hr-set-margin" />

            <div class="row">
                <div class="col-xs-5 col-sm-3 col-lg-3">
                    <img class="img-clover-book img-thumbnail" src="~/Content/Image/71817-fc-a.jpg">
                    <br><br>
                </div>
                <div class="col-sm-8 col-lg-7">
                    <div class="col-xs-7 col-sm-12">
                        <div class="row">
                            <b>Title:</b> <a class="text-info" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682"
                                             target="_blank">พ่อรวยสอนลูก : เงินสี่ด้าน / คิโยซากิ, โรเบิร์ต ที</a><br>
                            <b>Barcode:</b> B59121210<br>
                            <b>Request Date:</b> 12/08/2528<br><br>
                            <img class="img-thumbnail" src="~/Content/Icon/iconCar.png"> &nbsp; &nbsp;: เรียนรวม5
                            <br><br>
                        </div>
                    </div>
                    <div class="col-xs-12">
                        <div class="row">
                            <div class="col-xs-7 col-sm-6">
                                <div class="row">
                                    <!-- Button -->
                                    <button type="button" class="btn btn-success" data-toggle="modal" data-target="#exampleModalScrollable">
                                        สถานะ: จัดส่งเรียบร้อยแล้ว
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
                                                                <img class="img-iconfix" src="~/Content/Icon/iconSuccess.png">
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
                                                                <img class="img-iconfix" src="~/Content/Icon/iconTime.png">
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
                                                                <img class="img-iconfix" src="~/Content/Icon/iconTime.png">
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

                            <div class="col-xs-5">

                            </div>
                        </div>
                    </div>
                </div>
                <div class="visible-lg col-lg-2">
                    <img class="img-qrcode-maxsize" src="~/Content/Image/lineQR.JPG">
                </div>
                <hr />

            </div>

            <hr class="hr-set-margin" />

            <div class="row">
                <div class="col-xs-5 col-sm-3 col-lg-3">
                    <img class="img-clover-book img-thumbnail" src="~/Content/Image/116014-fc-a.jpg">
                    <br><br>
                </div>
                <div class="col-sm-8 col-lg-7">
                    <div class="col-xs-7 col-sm-12">
                        <div class="row">
                            <b>Title:</b> <a class="text-info" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682"
                                             target="_blank">พ่อรวยสอนลูก : เงินสี่ด้าน / คิโยซากิ, โรเบิร์ต ที</a><br>
                            <b>Barcode:</b> B59121210<br>
                            <b>Request Date:</b> 12/08/2528<br><br>
                            <img class="img-thumbnail" src="~/Content/Icon/iconCar.png"> &nbsp; &nbsp;: เรียนรวม5
                            <br><br>
                        </div>
                    </div>
                    <div class="col-xs-12">
                        <div class="row">
                            <div class="col-xs-7 col-sm-6">
                                <div class="row">
                                    <!-- Button -->
                                    <button type="button" class="btn btn-danger" data-toggle="modal" data-target="#exampleModalScrollable1">
                                        สถานะ: จัดส่งไม่สำเร็จ
                                    </button>
                                    <!-- Modal -->
                                    <div class="modal fade" id="exampleModalScrollable1" tabindex="-1" role="dialog" aria-labelledby="exampleModalScrollableTitle" aria-hidden="true">
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
                                                                <img class="img-iconfix" src="~/Content/Icon/iconFail.png">
                                                                <br><br>
                                                            </div>
                                                        </div>
                                                        <div class="col-xs-8">
                                                            <b class="lead text-danger">จัดส่งไม่สำเร็จ</b><br>
                                                            สาเหตุ: ไม่มีผู้รับ Document<br>
                                                            วันที่: 11/11/2019 เวลา: 16:00 น.
                                                        </div>
                                                    </div>
                                                    <div class="row">
                                                        <div class="col-xs-3 col-sm-2 col-md-2 nopadding">
                                                            <div class="icon">
                                                                <img class="img-iconfix" src="~/Content/Icon/iconTime.png">
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
                                                                <img class="img-iconfix" src="~/Content/Icon/iconTime.png">
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

                            <div class="col-xs-5">

                            </div>
                        </div>
                    </div>
                </div>
                <div class="visible-lg col-lg-2">
                    <img class="img-qrcode-maxsize" src="~/Content/Image/lineQR.JPG">
                </div>
                <hr />

            </div>

            <hr class="hr-set-margin" />

            <div class="row">
                <div class="col-xs-5 col-sm-3 col-lg-3">
                    <img class="img-clover-book img-thumbnail" src="~/Content/Image/71817-fc-a.jpg">
                    <br><br>
                </div>
                <div class="col-sm-8 col-lg-7">
                    <div class="col-xs-7 col-sm-12">
                        <div class="row">
                            <b>Title:</b> <a class="text-info" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682"
                                             target="_blank">พ่อรวยสอนลูก : เงินสี่ด้าน / คิโยซากิ, โรเบิร์ต ที</a><br>
                            <b>Barcode:</b> B59121210<br>
                            <b>Request Date:</b> 12/08/2528<br><br>
                            <img class="img-thumbnail" src="~/Content/Icon/iconDoc.png"> &nbsp; &nbsp;:
                            <a href="https://www.youtube.com/" target="_blank">Download</a>

                            <br><br>
                        </div>
                    </div>
                    <div class="col-xs-12">
                        <div class="row">
                            <div class="col-xs-7 col-sm-6">
                                <div class="row">
                                    <!-- Button -->
                                    <button type="button" class="btn btn-success" data-toggle="modal" data-target="#exampleModalScrollable9">
                                        สถานะ: จัดส่งเรียบร้อยแล้ว
                                    </button>
                                    <!-- Modal -->
                                    <div class="modal fade" id="exampleModalScrollable9" tabindex="-1" role="dialog" aria-labelledby="exampleModalScrollableTitle" aria-hidden="true">
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
                                                                <img class="img-iconfix" src="~/Content/Icon/iconSuccess.png">
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
                                                                <img class="img-iconfix" src="~/Content/Icon/iconTime.png">
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

                            <div class="col-xs-5">

                            </div>
                        </div>
                    </div>
                </div>
                <div class="visible-lg col-lg-2">
                    <img class="img-qrcode-maxsize" src="~/Content/Image/lineQR.JPG">
                </div>
            </div>

            <!-- page paginations -->
            @*<div class="row">
                    <div class="col-xs-8 col-xs-push-4 col-sm-push-6 col-md-push-6 col-lg-push-10">
                        <ul class="pagination">
                            <li><a href="#"><<</a></li>
                            <li><a href="#">1</a></li>
                            <li class="active"><a href="#">2</a></li>
                            <li><a href="#">3</a></li>
                            <li><a href="#">>></a></li>
                        </ul>
                    </div>
                </div>*@

        </div>




    </div>

</div>
<button class="btn" onclick="getTest('18')">Get Json</button>

<p class="test"></p>

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
            m.title = resultSearch[i].title;
            m.barcode = resultSearch[i].barcode;
            m.requestDate = resultSearch[i].requestDate;
            m.ddPoint = resultSearch[i].ddPoint;
            m.status = resultSearch[i].status;
            console.log(m.title + "" + m.barcode)
            $(".test").html("Hello <b>world</b>!");
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



@*<button id="baconButton">give me bacon</button><br /><br />

    <div id="baconIpsumOutput" class="container-border"></div>



    <div class="btn-group btn-toggle">
        <label class="btn btn-primary"><input type="radio" id="btnAll" onclick="loadPage('all')">ALL(5)</label>
        <label class="btn btn-primary"><input type="radio" onclick="loadPage('current')">Current(2)</label>
        <label class="btn btn-primary"><input type="radio" onclick="loadPage('reject')">Reject(1)</label>
        <label class="btn btn-primary"><input type="radio" onclick="loadPage('complete')">Complete(2)</label>
    </div>


    <div id="showcontent"></div>


    <script type="text/javascript">

        function loadPage(page) {
            var x = new XMLHttpRequest();
            x.open("get", page);
            x.onreadystatechange = function () {
                var content = document.getElementById("showcontent");
                content.innerHTML = x.responseText;
            }
            x.send(null);
        }
    </script>*@

@*<script type="text/javascript">
        $(document).ready(function () {
            $("#baconButton").click(function () {
                $.getJSON('https://baconipsum.com/api/?callback=?',
                    { 'type': 'meat-and-filler', 'start-with-lorem': '1', 'paras': '3' },
                    function (baconGoodness) {
                        if (baconGoodness && baconGoodness.length > 0) {
                            $("#baconIpsumOutput").html('');
                            for (var i = 0; i < baconGoodness.length; i++)
                                $("#baconIpsumOutput").append('<p>' + baconGoodness[i] + '</p><br />');
                            $("#baconIpsumOutput").show();
                        }
                    });
            });
        });

    </script>*@