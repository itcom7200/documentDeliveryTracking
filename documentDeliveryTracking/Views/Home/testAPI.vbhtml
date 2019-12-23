@Code
    ViewData("Title") = "testAPI"
End Code
</div>

<div class="background-fullscreen">
    <div class="container">
        <div class="row">
            <div class="col-xs-12 col-sm-7 col-md-8">
                <h1 class="text">Document Delivery</h1>
                <p class="font-discription">ติดตามหนังสือของคุณได้ทุกเวลา</p>
                <br />
                <div class="form-group row">
                    <div class="col-xs-12 col-sm-7 col-md-8">
                        <input id="inputId" type="text" class="form-control input-lg"
                               placeholder="Enter Your Tracking Number"
                               value="1">
                    </div>
                    <div class="col-xs-12 col-sm-2" style="padding-left: 0px;">
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
                <img class="img-banner" src="~/Content/Image/DeliveryMan.png">
            </div>
        </div>

    </div>
</div>


<script type="text/javascript">
    $(document).ready(function () {

        $("#Enter").click(function () {
            var inputId = $("#inputId").val();

            $.ajax({
                type: "POST",
                url: "http://localhost:62597/WebService1.asmx/getValue",
                data: "{id: '" + inputId + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: getContent,
                error: failGetContent
            });
            
        });


        function getContent(data) {
            resultSearch = $.parseJSON(data.d);
            $.each(resultSearch, function (i, item) {   
                console.log(resultSearch[i].staffName);
            });

        }

        function failGetContent() {
            alert("web service error");
            //console.log("error");
        }

    });

</script>


<div class="container">