@Code
    ViewData("Title") = "testAPI"
End Code

<h2>testAPI</h2>

<input type="text" value="1">


<script type="text/javascript">
    $(document).ready(function () {
        jQuery.support.cors = true;

        


        var id = "1";
        
        $.ajax({
            type: "POST",
            url: "http://localhost:62597/WebService1.asmx/getValue",
            data: "{id: '" + id + "'}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: getContent,
            error: failGetContent
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


