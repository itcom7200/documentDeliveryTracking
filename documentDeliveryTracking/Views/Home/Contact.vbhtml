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
    </div>
    <div class="col-md-8">
        <h2>Document Delivery Tracking</h2>
        <p>Type something in the input field to search the table for first names, last names or emails:</p>
        <input id="myInput" type="text" placeholder="Search.."><br><br>

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
                        <b>Title :</b> กรรมวิธีการผลิตชาสมุนไพร : รายงานการวิจัย = The production tea from herbs I / กุลยา จันทร์อรุณ.<br>
                        <b>DD Point :</b> ตึกนวัตกรรม<br>
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
                        <b>Title :</b> กรรมวิธีการผลิตชาสมุนไพร : รายงานการวิจัย = The production tea from herbs I / กุลยา จันทร์อรุณ.<br>
                        <b>DD Point :</b> ตึกนวัตกรรม<br>
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
                        <b>Title :</b> กรรมวิธีการผลิตชาสมุนไพร : รายงานการวิจัย = The production tea from herbs I / กุลยา จันทร์อรุณ.<br>
                        <b>DD Point :</b> ตึกนวัตกรรม<br>
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

            </tbody>
        </table>


    </div>
</div>
