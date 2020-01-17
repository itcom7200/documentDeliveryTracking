@Code
    ViewData("Title") = "TEST json server"
End Code

<h2>TEST json server</h2>

<div>
    <div class="jumbotron">
        <p id="result" class="text-green-opac"></p>
    </div>
</div>



<script type="text/javascript">
    $(document).ready(function () {
        
        $.ajax({
            type: "GET",
            url: "http://localhost:3000/customers",
            //data: "{id: '" + inputId + "'}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: getContent,
            error: failGetContent
        });

        function getContent(data, i) {
            //console.log(data);
            $.each(data, function (i) {
                
                var { id, firstname, lastname} = data[i];
                var string = `My name id ${firstname} ${lastname} ,id ${id}<br>`;
                $("#result").append(string);
            });
            
        }

        function failGetContent() {
            console.log("web service error");
        }



    });



</script>




