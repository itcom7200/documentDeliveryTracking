@Code
    ViewData("Title") = "Contact"
End Code

<script>
    $(document).ready(function () {
        $("#myInput").on("keyup", function () {
            var value = $(this).val().toLowerCase();
            $("#myTable tr").filter(function () {
                $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
            });
        });
    });
</script>

<div class="row">
    <div class="col-md-4">
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
    <div class="col-md-8">
        <h2>Document Delivery Tracking</h2>
        <p>Type something in the input field to search the table for first names, last names or emails:</p>
        <br><br> <!--<input id="myInput" type="text" placeholder="Search..">   -->

        <div class="btn-group">
            <button type="button" class="btn btn-primary">ALL(4)</button>
            <button type="button" class="btn btn-primary">Current(1)</button>
            <button type="button" class="btn btn-primary">Reject(1)</button>
            <button type="button" class="btn btn-primary">Complete(2)</button>
        </div>



        <table class="table table-hover">
            <tr>
                <th>#</th>
                <th>Bib Info</th>
                <th>Image</th>
                <th>QR Code</th>
                <th>Action</th>
            </tr>
            <tbody id="myTable">
                <tr>
                    <td> </td>
                    <td class="col-md-5">
                        <b>Title :</b> <a class="text-info" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682" target="_blank">กรรมวิธีการผลิตชาสมุนไพร : รายงานการวิจัย = The production tea from herbs I / กุลยา จันทร์อรุณ.</a><br>
                        <b><img class="img-thumbnail" src="~/Content/Icon/iconDoc2.png"></b> &nbsp; &nbsp;

                        <a href="https://www.youtube.com/watch?v=HgzGwKwLmgM" target="_blank">Link download</a><br>

                        <b>Barcode :</b> B59121210<br>
                        <b>Request Date :</b> 12/08/2528<br>
                        <div class="btn btn-warning" role="alert"><b>สถานะ : กำลังทำการจัดส่ง</b></div>
                    </td>
                    <td class="col-md-2"><img class="img-responsive img-thumbnail" src="~/Content/Image/bookDefultImage.jpg" style="max-height:240px; min-width:100%"></td>
                    <td class="col-md-2"><img class="img-responsive img-thumbnail" src="~/Content/Image/barcodeDefultImage.jpg" style="max-height:240px; min-width:100%;"></td>
                    <td class="col-md-3">
                        <div>
                            <button type="button" class="btn btn-primary">Edit</button>
                            <button type="button" class="btn btn-danger">Delete</button>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td> </td>
                    <td class="col-md-5">
                        <b>Title :</b> <a href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682" target="_blank">กรรมวิธีการผลิตชาสมุนไพร : รายงานการวิจัย = The production tea from herbs I / กุลยา จันทร์อรุณ.</a><br>
                        <b><img class="img-thumbnail" src="~/Content/Icon/iconCar.png"></b> &nbsp; &nbsp; : เรียนรวม5 <br>
                        <b>Barcode :</b> B59121293<br>
                        <b>Request Date :</b> 12/08/2528<br>
                        <!-- <div class="btn btn-success" role="alert"><b>สถานะ : จัดส่งเรียบร้อยแล้ว</b></div> -->
                        <!-- Button -->
                        <button type="button" class="btn btn-success" data-toggle="modal" data-target="#exampleModalScrollable">
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
                    </td>
                    <td class="col-md-2"><img class="img-responsive img-thumbnail" src="~/Content/Image/bookDefultImage.jpg" style="max-height:240px;"></td>
                    <td class="col-md-2"><img class="img-responsive img-thumbnail" src="~/Content/Image/barcodeDefultImage.jpg" style="max-height:240px;"></td>
                    <td class="col-md-3">
                        <div>
                            <button type="button" class="btn btn-primary">Edit</button>
                            <button type="button" class="btn btn-danger">Delete</button>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td> </td>
                    <td class="col-md-5">
                        <b>Title :</b> <a href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682" target="_blank">กรรมวิธีการผลิตชาสมุนไพร : รายงานการวิจัย = The production tea from herbs I / กุลยา จันทร์อรุณ.</a><br>
                        <b><img class="img-thumbnail" src="~/Content/Icon/iconCar.png"></b> &nbsp; &nbsp; : ตึกนวัตกรรม <br>
                        <b>Barcode :</b> B59121293<br>
                        <b>Request Date :</b> 12/08/2528<br>
                        <div class="btn btn-success" role="alert"><b>สถานะ : จัดส่งเรียบร้อยแล้ว</b></div>

                    </td>
                    <td class="col-md-2"><img class="img-responsive img-thumbnail" src="~/Content/Image/bookDefultImage.jpg" style="max-height:240px;"></td>
                    <td class="col-md-2"><img class="img-responsive img-thumbnail" src="~/Content/Image/barcodeDefultImage.jpg" style="max-height:240px;"></td>
                    <td class="col-md-3">
                        <div>
                            <button type="button" class="btn btn-primary">Edit</button>
                            <button type="button" class="btn btn-danger">Delete</button>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td> </td>
                    <td class="col-md-5">
                        <b>Title :</b> <a href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682" target="_blank">กรรมวิธีการผลิตชาสมุนไพร : รายงานการวิจัย = The production tea from herbs I / กุลยา จันทร์อรุณ.</a><br>
                        <b><img class="img-thumbnail" src="~/Content/Icon/iconCar.png"></b> &nbsp; &nbsp; : ตึกนวัตกรรม <br>
                        <b>Barcode :</b> B59121293<br>
                        <b>Request Date :</b> 12/08/2528<br>
                        <!--<div class="btn btn-danger" role="alert"><b>สถานะ : จัดส่งไม่สำเร็จ</b></div> -->
                        <!-- Button -->
                        <button type="button" class="btn btn-danger" data-toggle="modal" data-target="#exampleModalScrollable2">
                            สถานนะ : จัดส่งไม่สำเร็จ
                        </button>
                        <!-- Modal -->
                        <div class="modal fade" id="exampleModalScrollable2" tabindex="-1" role="dialog" aria-labelledby="exampleModalScrollableTitle" aria-hidden="true">
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
                                                    <b><img class="img-responsive" src="~/Content/Icon/iconFail.png"></b> &nbsp; &nbsp;

                                                </td>
                                                <td>
                                                    <b>จัดส่งไม่สำเร็จ</b> <br>
                                                    สาเหตุ : ไม่มารับตัวเล่ม<br>
                                                    วันที่ : 11/11/2019 เวลา : 16:00 น.
                                                </td>
                                            </tr>


                                        </table>

                                    </div>

                                </div>
                            </div>
                        </div>
                        <!-- Button&Model -->
                    </td>
                    <td class="col-md-2"><img class="img-responsive img-thumbnail" src="~/Content/Image/bookDefultImage.jpg" style="max-height:240px;"></td>
                    <td class="col-md-2"><img class="img-responsive img-thumbnail" src="~/Content/Image/barcodeDefultImage.jpg" style="max-height:240px;"></td>
                    <td class="col-md-3">
                        <div>
                            <button type="button" class="btn btn-primary">Edit</button>
                            <button type="button" class="btn btn-danger">Delete</button>
                        </div>
                    </td>
                </tr>

            </tbody>
        </table>


    </div>
</div>