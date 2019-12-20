@Code
    Layout = Nothing
End Code
@For Each item In ViewData.Model
    @<hr Class="hr-set-margin" />
    @<div Class="row">
        <div Class="col-xs-5 col-sm-3 col-lg-3">
            <img Class="img-clover-book img-thumbnail" src="~/@item("cloverBook")">
            <br> <br>
        </div>
        <div Class="col-sm-8 col-lg-7">
            <div Class="col-xs-7 col-sm-12">
                <div Class="row">
                    <b> Title :   </b> <a class="text-info" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=b00006682" target="_blank">@item("title")</a><br>
                    <b> Barcode :   </b> @item("barcode")<br>
                    <b>Request Date:</b> @item("requestDate")<br><br>
                    
                    <img Class="img-thumbnail" src="~/@item("ddType")"> &nbsp; &nbsp;: @item("ddPoint")
                    <br> <br>
                </div>
                <div Class="row">
                    <div Class="col-xs-12"></div>
                </div>
            </div>
        </div>
        <div Class="visible-lg col-xs-2 nopadding">
            <img Class="img-qrcode-maxsize" src="~/Content/Image/lineQR.JPG">
        </div>

    </div>
Next