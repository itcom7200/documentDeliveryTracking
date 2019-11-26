@Code
    ViewData("Title") = "tracking2"
End Code


<button id="baconButton">give me bacon</button><br /><br />

<div id="baconIpsumOutput" class="container-border"></div>

<script type="text/javascript">
    $(document).ready(function () {
        $("#baconButton").click(function () {
            $.getJSON('http://localhost:3000/customers',
                function (baconGoodness) {
                    //console.log(baconGoodness);
                    var obj = jQuery.parseJSON('{ "id": "1" }');
                    
                    if (baconGoodness && baconGoodness.length > 0) {
                        $("#baconIpsumOutput").html('');
                        for (var i = 0; i < baconGoodness.length; i++)
                            $("#baconIpsumOutput").append('<p>' + baconGoodness[i] + '</p>');
                           // $("#baconIpsumOutput").show();
                    }
                });
        });
    });
</script>
