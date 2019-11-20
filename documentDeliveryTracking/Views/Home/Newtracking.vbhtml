@Code
    ViewData("Title") = "Newtracking"
End Code



<div class="container">
    <div class="row">

        <h2>Document Delivery Tracking</h2>

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
            <label class="btn btn-primary hidden-ss">
                <input name="options" value="option3" type="radio"> Complete(1)
            </label>
        </div>
        <hr />


        <div class="row">
            <div class="col-xs-5 col-sm-3 col-md-2">
                <img class="img-clover-book img-responsive" src="~/Content/Image/bookRichdad.jpg">
            </div>
            <div class="col-sm-9 col-md-5">
                <div class="col-xs-7 col-sm-12">
                    <div class="row">
                        <b>Title:</b> <a class="text-info" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682"
                                          target="_blank">พ่อรวยสอนลูก : เงินสี่ด้าน / คิโยซากิ, โรเบิร์ต ที</a><br>
                    </div>
                    <div class="row">
                        <b>Barcode:</b> B59121210<br>
                        <b>Request Date:</b> 12/08/2528<br><br>
                    </div>
                    <div class="row">
                        <b><img class="img-thumbnail" src="~/Content/Icon/iconCar.png"></b> &nbsp; &nbsp;: เรียนรวม5
                    </div>

                </div>


                <div class="row">
                    <div class="col-xs-8 col-sm-6 col-md-6">
                        <br />
                        <!-- Button -->
                        <button type="button" class="btn btn-warning" data-toggle="modal" data-target="#exampleModalScrollable2">
                            สถานะ : Document รอนำส่ง
                        </button>
                        <!-- Modal -->
                        <div class="modal fade" id="exampleModalScrollable2" tabindex="-1" role="dialog" aria-labelledby="exampleModalScrollableTitle" aria-hidden="true">
                            <div class="modal-dialog modal-dialog-scrollable" role="document">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <h2 class="modal-title text-green-opac" id="exampleModalScrollableTitle">Document Delivery Tracking</h2>
                                        <h4 class="text-green-opac">รอบที่จัดส่ง: 11/11/2019 เวลา: 15:30 น.</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>
                                    <div class="modal-body">
                                        <!-- start body textbox -->

                                        <div class="row">
                                            <div class="col-xs-4 col-md-3">
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
                                            <div class="col-xs-4 col-md-3">
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
                                            <div class="col-xs-4 col-md-3">
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
                    <div class="col-xs-4">
                        <br />
                        <button class="btn-xs btn btn-primary"><img src="~/Content/Icon/pencil.png"></button>
                        <button class="btn-xs btn btn-danger"><img src="~/Content/Icon/bin.png"></button>
                    </div>
                </div>


            </div>
            <div class="visible-md visible-lg">
                <div class="col-md-3">
                    <img class="img-qrcode-maxsize" src="~/Content/Image/lineQR.JPG">
                </div>
            </div>
        </div>

        <hr />

        <div class="row">
            <div class="col-xs-5 col-sm-3 col-md-2">
                <img class="img-clover-book img-responsive" src="~/Content/Image/116014-fc-a.jpg">
            </div>
            <div class="col-sm-9 col-md-5">
                <div class="col-xs-7 col-sm-12">
                    <div class="row">
                        <b>Title:</b> <a class="text-info" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682"
                                          target="_blank">คิดมุมกลับ ปรับชีวิตให้เป็นบวก = Flip it /เฮปเพลล์, ไมเคิล</a><br>
                    </div>
                    <div class="row">
                        <b>Barcode:</b> B59121210<br>
                        <b>Request Date:</b> 12/08/2528<br><br>
                    </div>
                    <div class="row">
                        <b><img class="img-thumbnail" src="~/Content/Icon/iconCar.png"></b> &nbsp; &nbsp;: เรียนรวม5
                    </div>

                </div>


                <div class="row">
                    <div class="col-xs-8 col-sm-6 col-md-6">
                        <br />
                        <!-- Button -->
                        <button type="button" class="btn btn-warning" data-toggle="modal" data-target="#exampleModalScrollable3">
                            สถานะ: กำลังร้องขอรายการ
                        </button>
                        <!-- Modal -->
                        <div class="modal fade" id="exampleModalScrollable3" tabindex="-1" role="dialog" aria-labelledby="exampleModalScrollableTitle" aria-hidden="true">
                            <div class="modal-dialog modal-dialog-scrollable" role="document">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <h2 class="modal-title text-green-opac" id="exampleModalScrollableTitle">Document Delivery Tracking</h2>
                                        <h4 class="text-green-opac">รอบที่จัดส่ง: 11/11/2019 เวลา: 15:30 น.</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>
                                    <div class="modal-body">
                                        <!-- start body textbox -->
                                        <div class="row">
                                            <div class="col-xs-4 col-md-3">
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
                    <div class="col-xs-4">
                        <br />

                    </div>
                </div>


            </div>
            <div class="visible-md visible-lg">
                <div class="col-md-3">
                    <img class="img-qrcode-maxsize" src="~/Content/Image/lineQR.JPG">
                </div>
            </div>
        </div>

        <hr />

        <div class="row">
            <div class="col-xs-5 col-sm-3 col-md-2">
                <img class="img-clover-book img-responsive" src="~/Content/Image/71817-fc-a.jpg">
            </div>
            <div class="col-sm-9 col-md-5">
                <div class="col-xs-7 col-sm-12">
                    <div class="row">
                        <b>Title:</b> <a class="text-info" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682"
                                          target="_blank">ช้างกับกิ่งไม้ = The elephant and the twig / ทอมป์สัน, จีออฟ</a><br>
                    </div>
                    <div class="row">
                        <b>Barcode:</b> B59121210<br>
                        <b>Request Date:</b> 12/08/2528<br><br>
                    </div>
                    <div class="row">
                        <b><img class="img-thumbnail" src="~/Content/Icon/iconCar.png"></b> &nbsp; &nbsp;: เรียนรวม5
                    </div>

                </div>


                <div class="row">
                    <div class="col-xs-8 col-sm-6 col-md-6">
                        <br />
                        <!-- Button -->
                        <button type="button" class="btn btn-success" data-toggle="modal" data-target="#exampleModalScrollable">
                            สถานะ: จัดส่งเรียบร้อยแล้ว
                        </button>
                        <!-- Modal -->
                        <div class="modal fade" id="exampleModalScrollable" tabindex="-1" role="dialog" aria-labelledby="exampleModalScrollableTitle" aria-hidden="true">
                            <div class="modal-dialog modal-dialog-scrollable" role="document">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <h2 class="modal-title text-green-opac" id="exampleModalScrollableTitle">Document Delivery Tracking</h2>
                                        <h4 class="text-green-opac">รอบที่จัดส่ง: 11/11/2019 เวลา: 15:30 น.</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>
                                    <div class="modal-body">
                                        <!-- start body textbox -->
                                        <div class="row">
                                            <div class="col-xs-4 col-md-3">
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
                                            <div class="col-xs-4 col-md-3">
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
                                            <div class="col-xs-4 col-md-3">
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
                                            <div class="col-xs-4 col-md-3">
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
                    <div class="col-xs-4">

                    </div>
                </div>


            </div>
            <div class="visible-md visible-lg">
                <div class="col-md-3">
                    <img class="img-qrcode-maxsize" src="~/Content/Image/lineQR.JPG">
                </div>
            </div>
        </div>

        <hr />

        <div class="row">
            <div class="col-xs-5 col-sm-3 col-md-2">
                <img class="img-clover-book img-responsive" src="~/Content/Image/116014-fc-a.jpg">
            </div>
            <div class="col-sm-9 col-md-5">
                <div class="col-xs-7 col-sm-12">
                    <div class="row">
                        <b>Title:</b> <a class="text-info" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682"
                                          target="_blank">คิดมุมกลับ ปรับชีวิตให้เป็นบวก = Flip it /เฮปเพลล์, ไมเคิล</a><br>
                    </div>
                    <div class="row">
                        <b>Barcode:</b> B59121210<br>
                        <b>Request Date:</b> 12/08/2528<br><br>
                    </div>
                    <div class="row">
                        <b><img class="img-thumbnail" src="~/Content/Icon/iconCar.png"></b> &nbsp; &nbsp;: เรียนรวม5
                    </div>

                </div>


                <div class="row">
                    <div class="col-xs-8 col-sm-6 col-md-6">
                        <br />
                        <!-- Button -->
                        <button type="button" class="btn btn-danger" data-toggle="modal" data-target="#exampleModalScrollable1">
                            สถานะ: จัดส่งไม่สำเร็จ
                        </button>
                        <!-- Modal -->
                        <div class="modal fade" id="exampleModalScrollable1" tabindex="-1" role="dialog" aria-labelledby="exampleModalScrollableTitle" aria-hidden="true">
                            <div class="modal-dialog modal-dialog-scrollable" role="document">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <h2 class="modal-title text-green-opac" id="exampleModalScrollableTitle">Document Delivery Tracking</h2>
                                        <h4 class="text-green-opac">รอบที่จัดส่ง: 11/11/2019 เวลา: 15:30 น.</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>
                                    <div class="modal-body">
                                        <!-- start body textbox -->
                                        <div class="row">
                                            <div class="col-xs-4 col-md-3">
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
                                            <div class="col-xs-4 col-md-3">
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
                                            <div class="col-xs-4 col-md-3">
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
                                            <div class="col-xs-4 col-md-3">
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
                    <div class="col-xs-4">
                        <br />

                    </div>
                </div>


            </div>
            <div class="visible-md visible-lg">
                <div class="col-md-3">
                    <img class="img-qrcode-maxsize" src="~/Content/Image/lineQR.JPG">
                </div>
            </div>
        </div>











    </div> <!-- div main row-->
</div><!-- div class container-->

