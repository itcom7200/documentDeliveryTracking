@Code
    ViewData("Title") = "Tracking"
End Code

<h2>Document Delivery Tracking </h2>

<div class="container">
    <div class="row">
        <div class="btn-group">
            <button type="button" class="btn btn-primary hidden-ss">ALL(4)</button>
            <button type="button" class="btn btn-primary">Current(1)</button>
            <button type="button" class="btn btn-primary">Reject(1)</button>
            <button type="button" class="btn btn-primary">Complete(2)</button>
        </div>
        <hr />
    <!-- ใส่ row จะได้ทำได้เป็นแถว-->
        <div class="col-xs-5">
            <img class="img-clover-book" src="~/Content/Image/bookDefultImage.jpg">
        </div>
        <div class="col-xs-7">
            <b>Title :</b> <a class="text-info" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682" target="_blank">กรรมวิธีการผลิตชาสมุนไพร : รายงานการวิจัย = The production tea from herbs I / กุลยา จันทร์อรุณ.</a><br>

            <b><img class="img-thumbnail" src="~/Content/Icon/iconDoc.png"></b> &nbsp; &nbsp;

            <a href="https://www.youtube.com/watch?v=HgzGwKwLmgM" target="_blank">Download</a><br>
        </div>
        <div class="col-xs-5">
            
            <b>Barcode :</b> B59121210<br>
            <b>Request Date :</b> 12/08/2528<br>
            <div class="btn btn-warning" role="alert"><b>สถานะ : กำลังทำการจัดส่ง</b></div>
            <br />
        </div>
        <div class="col-md-7">
            <img class="img-thumbnail" src="~/Content/Icon/iconEdit.png">
            <br><br>
            <img class="img-thumbnail" src="~/Content/Icon/iconDelete.png">
        </div>



    </div><!-- / div row-->
</div><!-- /div container-->


        



