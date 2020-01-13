@Code

    ViewData("Title") = "Contact"
End Code

</div>

<div class="background-fullscreen">
    <div class="container">
        <div class="row">
            <div class="col-xs-12 col-sm-7 col-md-8">
                <h1 class="text">Walai DD Tracking</h1>
                <p class="font-discription">ติดตามหนังสือของคุณได้ทุกเวลา</p>
                <br />
                <div class="search-container">
                    <form class="form-group row">
                        <div class="col-xs-9 col-sm-9 col-md-8" style="padding-right: 00px;">
                            <input type="text" id="inputId" name="trackingId" class="form-control input-lg" placeholder="Enter Your Tracking Number" value="@ViewData("Message")">
                        </div>
                        <div class="col-xs-3 col-sm-3" style="padding-left: 0px;">
                            <center><button type="submit" id="Enter" class="btn btn-green-opac btn-lg">Go</button></center>
                        </div>
                    </form>
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
        var myObj, i, j, x = "";

        myObj = {
            "name": "John",
            "id": "59121293",
            "content": [
                { "step": "Request", "detail": ["ห้องสมุดแพทย์", "11/11/2019", "09:00"] },
                { "step": "Accept", "detail": ["Staff WU", "11/11/2019", "10:30"] },
                { "step": "Ready Delivery", "detail": ["WU Lineman", "11/11/2019", "11:30"] }
            ]
        }


        for (i in myObj.content) {
            x += "<h2>" + myObj.content[i].step + "</h2>";
            for (j in myObj.content[i].detail) {
                x += myObj.content[i].detail[j] + "<br>";
            }
        }

        //console.log(x);
        var contentRow = x;

        $("#main").append(contentRow);


    });
</script>

<div class="container">