@Code
    ViewData("Title") = "tracking2"
End Code

<h2> Test Jquery </h2>

<div class="btn-group" role="group" aria-label="Test Class button">
    <button type="button" id="btnAll" class="btn btn-primary active">ALL</button>
    <button type="button" id="btnCurrent" class="btn btn-primary">Current</button>
    <button type="button" id="btnReject" class="btn btn-primary">Reject</button>
    <button type="button" id="btnComplete" class="btn btn-primary">Complete</button>
</div>


<button id="baconButton">give me bacon</button><br /><br />

<div id="baconIpsumOutput" class="container-border"></div>

@*<script type="text/javascript">
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
                            $("#baconIpsumOutput").show();
                    }
                });
        });

    });
</script>*@
