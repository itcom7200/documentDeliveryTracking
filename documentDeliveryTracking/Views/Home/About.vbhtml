@Code
    ViewData("Title") = "About"
End Code
<h2>@ViewData("Title")</h2>


<div id="demo">

</div>

<script>
    $(document).ready(function () {
        

        var GenQRcode = "https://th.kerryexpress.com/th/track/?track=KUBO000109346";
        if (GenQRcode !== "") {
            new QRCode(document.getElementById("demo"), {
                text: GenQRcode,
                width: 100,
                height: 100
            });
        }

        



    });
</script>
