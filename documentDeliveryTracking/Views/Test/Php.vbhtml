@Code
    ViewData("Title") = "Php"
End Code

<h2>Php</h2>


<script type="text/javascript">
    $(document).ready(function () {


        $.ajax({
            type: "GET",
            url: "http://localhost/json/index.php",
            //data: "{id: '" + inputId + "'}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: getContent,
            error: failGetContent
        });

        function getContent() {
            alert("Success");
            
        }

        function failGetContent() {
            alert("web service error");
        }



    });



</script>




