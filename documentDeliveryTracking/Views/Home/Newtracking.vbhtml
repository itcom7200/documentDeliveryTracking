@Code
    ViewData("Title") = "Newtracking"
End Code



<div class="container-fluid">
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
                <div class="col-xs-5">
                    <img class="img-clover-book img-thumbnail" src="~/Content/Image/116014-fc-a.jpg">
                </div>
                <div class="col-xs-7">
                    <div class="row">
                        <b>Title :</b> <a class="text-info" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682"
                                          target="_blank">คิดมุมกลับ ปรับชีวิตให้เป็นบวก = Flip it /เฮปเพลล์, ไมเคิล</a><br>
                        <b>Barcode :</b> B59121210<br>
                        <b>Request Date :</b> 12/08/2528<br>
                    </div>
                    <div class="row">
                        <b><img class="img-thumbnail" src="~/Content/Icon/iconCar.png"></b> &nbsp; &nbsp; : เรียนรวม5
                    </div>
                    
                </div>
                <div class="col-xs-6">
                    <div class="row">
                        <br />
                        <button type="button" class="btn btn-warning" data-toggle="modal" data-target="#exampleModalScrollable3">
                            สถานนะ : กำลังร้องขอรายการ
                        </button>
                    </div>
                </div>
            </div>
            
            
        

    </div> <!-- div main row-->
</div><!-- div class container-->

