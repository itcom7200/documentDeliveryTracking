@Code
    ViewData("Title") = "Search"
End Code
</div>

<div class="background-fullscreen">
    <div class="container">
        <!-- container ซ้อนสองอัน ได้เหมือนหน้าอื่น -->
        <div class="container">

            <div class="row">
                <div class="col-xs-12 col-sm-7 col-md-8">
                    <h1 class="text">Document Delivery</h1>
                    <p class="font-discription">ติดตามหนังสือของคุณได้ทุกเวลา</p>
                    <br />
                    <div class="form-group row">
                        <div class="col-xs-12 col-sm-7 col-md-8" style="padding-right: 0px;">
                            <input type="text" class="form-control input-lg"
                                   placeholder="Enter Your Tracking Number"
                                   value="59148965">
                        </div>
                        <div class="col-xs-12 col-sm-2">
                            <div class="visible-xs">
                                <br />
                            </div>
                            <center><button id="Enter" class="btn btn-green-opac btn-lg">Enter</button></center>
                        </div>
                    </div>
                    <br />
                    <br />
                    <br />
                </div>
                <div class="col-sm-4 col-md-3 visible-sm visible-md visible-lg">
                    <img class="img-banner" src="~/Content/Image/img-banner.png">
                </div>
            </div>
        </div>
    </div>
</div>
<div class="container">
    <div class="container">
        <div class="row">
            <div id="main">
                
            </div>
        </div>


    </div>
</div>

<script type="text/javascript">
    $(document).ready(function () {
        $("#Enter").click(function () {
            $.get("viewTrackingSearch", function (data) {
                $("#main").html(data);
            });
        });





    });

</script>



<div class="container">