@Code
    ViewData("Title") = "Tracking"
End Code

<h2>Document Delivery Tracking </h2>

<div class="row">
        <div class="col-xs-12 col-sm-12">
            <div class="container-fluid">
                <div class="row">
                    <div class="btn-group">
                        <button type="button" class="btn btn-primary hidden-ss">ALL(4)</button>
                        <button type="button" class="btn btn-primary">Current(1)</button>
                        <button type="button" class="btn btn-primary">Reject(1)</button>
                        <button type="button" class="btn btn-primary">Complete(2)</button>
                    </div>
                    <hr />

                    <div class="row">
                        <div class="col-xs-5 col-sm-3">
                            <img class="img-clover-book" src="~/Content/Image/bookDefultImage.jpg">
                        </div>
                        <div class="col-xs-7 col-sm-9">
                            <b>Title :</b> <a class="text-info" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682" target="_blank">กรรมวิธีการผลิตชาสมุนไพร : รายงานการวิจัย = The production tea from herbs I / กุลยา จันทร์อรุณ.</a><br>
                            <div class="hidden-ss"> <br /></div>
                            <b><img class="img-thumbnail" src="~/Content/Icon/iconDoc.png"></b> &nbsp; &nbsp;

                            <a href="https://www.youtube.com/watch?v=HgzGwKwLmgM" target="_blank">Download</a><br>
                        </div>
                        <div class="col-xs-8 col-sm-4">
                            <br>
                            <b>Barcode :</b> B59121210<br>
                            <b>Request Date :</b> 12/08/2528<br><br>
                            <div class="btn btn-warning" role="alert"><b>สถานะ : กำลังทำการจัดส่ง</b></div>
                            <br />
                        </div>
                        <div class="col-xs-4 col-sm-3">
                            <br>
                            <button type="button" class="btn-action btn btn-primary">Edit</button>
                            <!--<img src="~/Content/Icon/iconEdit.png"> -->
                            <br /><br />
                            <button type="button" class="btn-action btn btn-danger">Delete</button>
                            <!--<img src="~/Content/Icon/iconDelete.png"> -->
                        </div>
                    </div>
                    <hr />
                </div><!-- / div row-->
            </div><!-- /div container-->
        </div> 
</div>