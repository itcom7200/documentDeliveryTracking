@Code
    ViewData("Title") = "Content"
End Code

<div class="container">
    <div class="row">

        <div class="row col-md-4">
            <h2>@ViewData("Title").</h2>
            <h3>@ViewData("Message")</h3>
            <p>Use this area to provide additional information.</p>
            <address>
                ID : 59121293<br />
                Name : สันติภาพ ตันประมวล<br />
                Default point : ตึกนวัตกรรม <br>

            </address>

            <address>
                <strong>E-mail:</strong>   <a href="mailto:suntiparb.tu@mail.com">suntiparb.tu@mail.com</a><br />

            </address>
        </div>
        <div class="row col-md-8">
            <h3>Document Delivery Tracking</h3>
            <p>Type something in the input field to search the table for first names, last names or emails:</p>
            <br>
            <!--<input id="myInput" type="text" placeholder="Search..">   -->
            <div class="btn-group">
                <button type="button" class="btn btn-primary">ALL(4)</button>
                <button type="button" class="btn btn-primary">Current(1)</button>
                <button type="button" class="btn btn-primary">Reject(1)</button>
                <button type="button" class="btn btn-primary">Complete(2)</button>
            </div>
            <br><br>

                <div class="container-fluid">
                    <hr />
                    <div class="row">
                        <div class="col-md-3 col-xs-4">
                            <img class="img-clover-book" src="~/Content/Image/bookDefultImage.jpg">
                        </div>
                        <div class="col-md-4 col-xs-8">
                            <b>Title :</b> <a class="text-info" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682" target="_blank">กรรมวิธีการผลิตชาสมุนไพร : รายงานการวิจัย = The production tea from herbs I / กุลยา จันทร์อรุณ.</a><br>
                            <b><img class="img-thumbnail" src="~/Content/Icon/iconDoc.png"></b> &nbsp; &nbsp;

                            <a href="https://www.youtube.com/watch?v=HgzGwKwLmgM" target="_blank">Link download</a><br>

                            <b>Barcode :</b> B59121210<br>
                            <b>Request Date :</b> 12/08/2528<br>
                            <div class="btn btn-warning" role="alert"><b>สถานะ : กำลังทำการจัดส่ง</b></div>
                            <br><br>
                        </div>
                        <div class="visible-lg col-md-3">
                            <img class="img-responsive img-thumbnail" src="~/Content/Image/barcodeDefultImage.jpg">
                        </div>
                        <div class="col-xs-4 visible-xs"></div>

                        <div class="col-md-2 col-sm-6 col-xs-5">
                             <!-- <button type="button" class="btn-action btn btn-primary">Edit</button> -->
                             
                             <img class="img-thumbnail" src="~/Content/Icon/iconEdit.png">
                             <div class="visible-lg visible-md"><br /></div>
                             <!-- <button type="button" class="btn-action btn btn-danger">Delete</button> -->
                             
                            <img class="img-thumbnail" src="~/Content/Icon/iconDelete.png">
                        </div>



                    </div><!-- row content-->   
                    <hr />

                    <div class="row">
                        <div class="col-xs-2">
                            <img class="img-clover-book" src="~/Content/Image/bookDefultImage.jpg">
                        </div>
                        <div class="col-xs-6">
                            <b>Title :</b> <a class="text-info" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682" target="_blank">กรรมวิธีการผลิตชาสมุนไพร : รายงานการวิจัย = The production tea from herbs I / กุลยา จันทร์อรุณ.</a><br>
                            <b><img class="img-thumbnail" src="~/Content/Icon/iconCar.png"></b> &nbsp; &nbsp; : เรียนรวม5 <br>

                            <b>Barcode :</b> B59121210<br>
                            <b>Request Date :</b> 12/08/2528<br>
                            <!-- Button -->
                            <button type="button" class="btn btn-success" data-toggle="modal" data-target="#exampleModalScrollable">
                                สถานนะ : จัดส่งเรียบร้อยแล้ว
                            </button>
                            <!-- Modal -->
                            <div class="modal fade" id="exampleModalScrollable" tabindex="-1" role="dialog" aria-labelledby="exampleModalScrollableTitle" aria-hidden="true">
                                <div class="modal-dialog modal-dialog-scrollable" role="document">
                                    <div class="modal-content"> 
                                        <div class="modal-header">
                                            <h2 class="modal-title text-success" id="exampleModalScrollableTitle">Document Delivery Tracking</h2>
                                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                                <span aria-hidden="true">&times;</span>
                                            </button>
                                        </div>
                                        <div class="modal-body"> <!-- start body textbox -->
                                            <div class="row">
                                                <div class="col-xs-12">
                                                    <div class="row">
                                                        <div class="col-xs-3">
                                                            <div class="icon">
                                                                <img class="img-iconfix" src="~/Content/Icon/iconSuccess.png">
                                                                <br><br>
                                                            </div>
                                                        </div>
                                                        <div class="col-xs-9">
                                                            <b class="lead text-success">จัดส่งเรียบร้อยแล้ว</b><br>
                                                            ผู้รับ : คุณ สวัสดี วันจันทร์<br>
                                                            วันที่ : 11/11/2019 เวลา : 16:00 น.
                                                        </div>
                                                    </div>
                                                    <div class="row">
                                                        <div class="col-xs-3">
                                                            <div class="icon">
                                                                <img class="img-iconfix" src="~/Content/Icon/iconTime.png">
                                                                <br><br>
                                                            </div>
                                                        </div>
                                                        <div class="col-xs-9">
                                                            <b class="lead text-success">Document รอนำส่ง</b><br>
                                                            Point : ตึกนวัตกรรม<br>
                                                            วันที่ : 11/11/2019 เวลา : 15:30 น.
                                                        </div>
                                                    </div>
                                                    <div class="row">
                                                        <div class="col-xs-3">
                                                            <div class="icon">
                                                                <img class="img-iconfix" src="~/Content/Icon/iconPlane.png">
                                                                <br><br>
                                                            </div>
                                                        </div>
                                                        <div class="col-xs-9">
                                                            <b class="lead text-success">ทำรายการเรียบร้อย</b><br>
                                                            เจ้าหน้าที่ : ตึกนวัตกรรม<br>
                                                            วันที่ : 11/11/2019 เวลา : 11:56 น.
                                                        </div>
                                                    </div>
                                                    <div class="row">
                                                        <div class="col-xs-3">
                                                            <div class="icon-noline">
                                                                <img class="img-iconfix" src="~/Content/Icon/iconFail.png">
                                                                <br><br>
                                                            </div>
                                                        </div>
                                                        <div class="col-xs-9">
                                                            <b class="lead text-success">รับคำร้องขอ</b><br>
                                                            สาขา : หอสมุดกลาง<br>
                                                            วันที่ : 11/11/2019 เวลา : 10:56 น.
                                                        </div>
                                                    </div>


                                                </div>
                                                
                                            </div>

                                        </div> <!-- modal-body -->

                                    </div>
                                </div>
                            </div>
                            <!-- Button&Model -->
                        </div>
                        <div class="visible-lg col-xs-2">
                            <img class="img-responsive" src="~/Content/Image/barcodeDefultImage.jpg">
                        </div>

                        <div class="col-xs-2">
                            <button type="button" class="btn-action btn btn-primary">Edit</button><br><br>
                            <button type="button" class="btn-action btn btn-danger">Delete</button>
                        </div>
                        
                    </div><!-- row content-->
                    <hr />

                    <div class="row">
                        <div class="col-xs-2">
                            <img class="img-clover-book" src="~/Content/Image/bookDefultImage.jpg">
                        </div>
                        <div class="col-xs-6">
                            <b>Title :</b> <a class="text-info" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682" target="_blank">กรรมวิธีการผลิตชาสมุนไพร : รายงานการวิจัย = The production tea from herbs I / กุลยา จันทร์อรุณ.</a><br>
                            <b><img class="img-thumbnail" src="~/Content/Icon/iconCar.png"></b> &nbsp; &nbsp; : เรียนรวม5 <br>

                            <b>Barcode :</b> B59121210<br>
                            <b>Request Date :</b> 12/08/2528<br>
                            <!-- Button -->
                            <button type="button" class="btn btn-success" data-toggle="modal" data-target="#exampleModalScrollable1">
                                สถานนะ : จัดส่งเรียบร้อยแล้ว
                            </button>
                            <!-- Modal -->
                            <div class="modal fade" id="exampleModalScrollable1" tabindex="-1" role="dialog" aria-labelledby="exampleModalScrollableTitle1" aria-hidden="true">
                                <div class="modal-dialog modal-dialog-scrollable" role="document">
                                    <div class="modal-content">
                                        <div class="modal-header">
                                            <h3 class="modal-title text-success" id="exampleModalScrollableTitle1">Document Delivery Tracking</h3>
                                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                                <span aria-hidden="true">&times;</span>
                                            </button>
                                        </div>
                                        <div class="modal-body">
                                            <!-- start body textbox -->
                                            <div class="row">
                                                <div class="col-xs-12"> 
                                                    <div class="row">
                                                        <div class="col-xs-3">
                                                            <div class="icon">
                                                                <img class="img-iconfix" src="~/Content/Icon/iconPlane.png">
                                                                <br><br>
                                                            </div>
                                                        </div>
                                                        <div class="col-xs-9">
                                                            <b class="text-success">Document รอนำส่ง</b><br>
                                                            Point : ตึกนวัตกรรม<br>
                                                            วันที่ : 11/11/2019 เวลา : 15:30 น.
                                                        </div>
                                                    </div>
                                                    <div class="row">
                                                        <div class="col-xs-3">
                                                            <div class="icon">
                                                                <img class="img-iconfix" src="~/Content/Icon/iconTime.png">
                                                                <br><br>
                                                            </div>
                                                        </div>
                                                        <div class="col-xs-9">
                                                            <b class="text-success">ทำรายการเรียบร้อย</b><br>
                                                            เจ้าหน้าที่ : ตึกนวัตกรรม<br>
                                                            วันที่ : 11/11/2019 เวลา : 11:56 น.
                                                        </div>
                                                    </div>
                                                    <div class="row">
                                                        <div class="col-xs-3">
                                                            <div class="icon-noline">
                                                                <img class="img-iconfix" src="~/Content/Icon/iconTime.png">
                                                                <br><br>
                                                            </div>
                                                        </div>
                                                        <div class="col-xs-9">
                                                            <b class="text-success">รับคำร้องขอ</b><br>
                                                            สาขา : หอสมุดกลาง<br>
                                                            วันที่ : 11/11/2019 เวลา : 10:56 น.
                                                        </div>
                                                    </div>


                                                </div>

                                            </div>

                                        </div> <!-- modal-body -->

                                    </div>
                                </div>
                            </div>
                            <!-- Button&Model -->
                        </div>
                        <div class="visible-lg col-xs-2">
                            <img class="img-responsive visible-lg" src="~/Content/Image/barcodeDefultImage.jpg">
                        </div>

                        <div class="col-xs-2">
                            <button type="button" class="btn-action btn btn-primary">Edit</button><br><br>
                            <button type="button" class="btn-action btn btn-danger">Delete</button>
                        </div>
                    </div><!-- row content-->
                    <hr />

                    <div class="row">
                        <div class="col-xs-2">
                            <img class="img-clover-book" src="~/Content/Image/bookDefultImage.jpg">
                        </div>
                        <div class="col-xs-6">
                            <b>Title :</b> <a class="text-info" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682" target="_blank">กรรมวิธีการผลิตชาสมุนไพร : รายงานการวิจัย = The production tea from herbs I / กุลยา จันทร์อรุณ.</a><br>
                            <b><img class="img-thumbnail" src="~/Content/Icon/iconCar.png"></b> &nbsp; &nbsp; : เรียนรวม5 <br>

                            <b>Barcode :</b> B59121210<br>
                            <b>Request Date :</b> 12/08/2528<br>
                            <!-- Button -->
                            <button type="button" class="btn btn-danger" data-toggle="modal" data-target="#exampleModalScrollable">
                                สถานนะ : จัดส่งเรียบร้อยแล้ว
                            </button>
                            <!-- Modal -->
                            <div class="modal fade" id="exampleModalScrollable" tabindex="-1" role="dialog" aria-labelledby="exampleModalScrollableTitle" aria-hidden="true">
                                <div class="modal-dialog modal-dialog-scrollable" role="document">
                                    <div class="modal-content">
                                        <div class="modal-header">
                                            <h3 class="modal-title" id="exampleModalScrollableTitle">Document Delivery Transection</h3>
                                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                                <span aria-hidden="true">&times;</span>
                                            </button>
                                        </div>
                                        <div class="modal-body">
                                            <h3></h3>
                                            <table class="table table-borderless">

                                                <tr>
                                                    <td>
                                                        <b><img class="img-responsive" src="~/Content/Icon/iconWaiting2.png"></b> &nbsp; &nbsp;

                                                    </td>
                                                    <td>
                                                        <b>รับคำร้องขอ</b><br>
                                                        สาขา : หอสมุดกลาง<br>
                                                        วันที่ : 11/11/2019 เวลา : 10:56 น.
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <b><img class="img-responsive" src="~/Content/Icon/iconWaiting2.png"></b> &nbsp; &nbsp;

                                                    </td>
                                                    <td>
                                                        <b>ทำรายการเรียบร้อย</b><br>
                                                        เจ้าหน้าที่ : staff WU<br>
                                                        วันที่ : 11/11/2019 เวลา : 11:56 น.
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <b><img class="img-responsive" src="~/Content/Icon/iconWaiting2.png"></b> &nbsp; &nbsp;

                                                    </td>
                                                    <td>
                                                        <b>Document รอนำส่ง</b><br>
                                                        Point : ตึกนวัตกรรม<br>
                                                        วันที่ : 11/11/2019 เวลา : 15:30 น.
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <b><img class="img-responsive" src="~/Content/Icon/iconSuccess.png"></b> &nbsp; &nbsp;

                                                    </td>
                                                    <td>
                                                        <b>จัดส่งเรียบร้อยแล้ว</b><br>
                                                        ผู้รับ : คุณ สวัสดี วันจันทร์<br>
                                                        วันที่ : 11/11/2019 เวลา : 16:00 น.
                                                    </td>
                                                </tr>


                                            </table>

                                        </div>

                                    </div>
                                </div>
                            </div>
                            <!-- Button&Model -->
                        </div>
                        <div class="visible-lg col-xs-2">
                            <img class="img-responsive visible-lg" src="~/Content/Image/barcodeDefultImage.jpg">
                        </div>

                        <div class="col-xs-2">
                            <button type="button" class="btn-action btn btn-primary">Edit</button><br><br>
                            <button type="button" class="btn-action btn btn-danger">Delete</button>
                        </div>
                    </div><!-- row content-->
                    <hr />




                </div>


        </div><!-- row col-md-8 -->
    </div><!-- main row -->
</div><!-- container-->