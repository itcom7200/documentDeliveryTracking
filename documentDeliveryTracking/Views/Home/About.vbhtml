@Code
    ViewData("Title") = "About"
End Code
<h2>@ViewData("Title")</h2>


<div id="demo">

</div>

<script>
    $(document).ready(function () {
        //var QRcode = "http://localhost:49777/Home/testAPI";
        //$("#demo").qrcode({
            
        //    //render:"table",
        //    width: 128,
        //    height: 128,
        //    text: QRcode
        //});

        var GenQRcode = "http://localhost:49777/Home/testAPI";
        if (GenQRcode !== "") {
            var qrcode = new QRCode(document.getElementById('demo'), {
                text: GenQRcode,
                width: 100,
                height: 100
            });
        }



    });
</script>
