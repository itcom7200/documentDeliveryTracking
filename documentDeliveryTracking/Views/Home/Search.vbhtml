@Code
    ViewData("Title") = "Search"
End Code
</div>

<div class="background-fullscreen">
    <div class="container">
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
                    <img class="img-banner" src="~/Content/Image/img-Bikeman.png">
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
            //$.get("viewTrackingSearch", function (data) {
            //    $("#main").html(data);
            //});

            $.ajax({
                type: "POST",
                url: "http://localhost:62597/WebService1.asmx/SearchTracking",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: getContent,
                error: failGetContent
            });
        });

        function getContent(data) {
            resultSearch = $.parseJSON(data.d);
            $.each(resultSearch, function (i, item) {
                let contact1 = '<div class="col-sm-4 col-md-4"><h2>Contact</h2><p>หากมีข้อสงสัย กรุณาติดต่อ</p>';
                let contact2 = '<address>Staff: '+ resultSearch[i].staffName +'<br />Line id: '+resultSearch[i].staffLine;
                let contact3 = '<br>Tel: ' + resultSearch[i].staffTel + ' <br><b>Point: ' + resultSearch[i].ddPoint + '</b><br></address></div >';
                let contact = contact1 + contact2 + contact3;

                console.log(resultSearch[i].status)

                switch (resultSearch[i].status) {
                    case "0": // startRequest
                        var row1 = '<div class="row"><div class="col-xs-3 col-md-3 nopadding">';
                        var row2 = '<div class="icon-noline"><img class="img-iconfix" src="/Content/Icon/iconTime.png">';
                        var row3 = '<br><br></div></div><div class="col-xs-9">';
                        var row4 = '<b class="lead text-green-opac">' + resultSearch[i].requestStep + '</b><br> สาขา: ' + resultSearch[i].libBranch + '<br>วันที่: ' + resultSearch[i].requestDate + ' เวลา: ' + resultSearch[i].requestTime+' น.</div></div>';
                        var resultRow = row1 + row2 + row3 + row4;
                        break;
                    case "1": // rejectRequest
                        var row1 = '<div class="row"><div class="col-xs-3 col-md-3 nopadding">';
                        var row2 = '<div class="icon-noline"><img class="img-iconfix" src="/Content/Icon/iconCancle.png">';
                        var row3 = '<br><br></div></div><div class="col-xs-9">';
                        var row4 = '<b class="lead text-danger">' + resultSearch[i].requestStep + '</b><br> สาขา: ' + resultSearch[i].libBranch + '<br>วันที่: ' + resultSearch[i].requestDate + ' เวลา: ' + resultSearch[i].requestTime + ' น.</div></div>';
                        var resultRow = row1 + row2 + row3 + row4;
                        break;
                    case "2": // requestSuccess
                        var row1 = '<div class="row"><div class="col-xs-3 col-md-3 nopadding">';
                        var row2 = '<div class="icon-noline"><img class="img-iconfix" src="/Content/Icon/iconCancle.png">';
                        var row3 = '<br><br></div></div><div class="col-xs-9">';
                        var row4 = '<b class="lead text-danger">' + resultSearch[i].requestStep + '</b><br> สาขา: ' + resultSearch[i].libBranch + '<br>วันที่: ' + resultSearch[i].requestDate + ' เวลา: ' + resultSearch[i].requestTime + ' น.</div></div>';
                        var resultRow = row1 + row2 + row3 + row4;
                        break;
                    case "3": //requestNotComplete
                        var row1 = '<div class="row"><div class="col-xs-3 col-md-3 nopadding">';
                        var row2 = '<div class="icon"><img class="img-iconfix" src="/Content/Icon/iconCancle.png">';
                        var row3 = '<br><br></div></div><div class="col-xs-9">';
                        var row4 = '<b class="lead text-danger">' + resultSearch[i].processStep + '</b><br> สาเหตุ: ' + resultSearch[i].staffLib + '<br>วันที่: ' + resultSearch[i].requestDate + ' เวลา: ' + resultSearch[i].requestTime + ' น.</div></div>';
                        var row5 = '<div class="row"><div class="col-xs-3 col-md-3 nopadding">';
                        var row6 = '<div class="icon-noline"><img class="img-iconfix" src="/Content/Icon/iconTime.png">';
                        var row7 = '<br><br></div></div><div class="col-xs-9">';
                        var row8 = '<b class="lead text-green-opac">' + resultSearch[i].requestStep + '</b><br> สาขา: ' + resultSearch[i].libBranch + '<br>วันที่: ' + resultSearch[i].requestDate + ' เวลา: ' + resultSearch[i].requestTime + ' น.</div></div>';
                        
                        var resultRow = row1 + row2 + row3 + row4 + row5 + row6 + row7 + row8;



                }

                
                

                




                let track = '<div class="col-sm-7 col-md-4"><br />'+ resultRow +'</div>';
                


                let content = contact + track;


                $("#main").html(content);
            });

            

        }

        function failGetContent() {
            alert("Web Service Error!!!");
        }




    });

</script>



<div class="container">