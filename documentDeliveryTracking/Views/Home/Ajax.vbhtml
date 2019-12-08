@Code
    ViewData("Title") = "Ajax"
End Code

<h2>
    Ajax Test
</h2>

<div class="container">
    <form>
        <div align="center">
            <fieldset>
                <div id="contentArea">
                    <button id="btnSubmit" runat="server" class="btn btn-success">Press Start</button>
                </div>
            </fieldset>
        </div>
    </form>
</div>

<script language="javascript" type="text/javascript">
    $(document).ready(function () { 
        $.ajaxSetup({
            cache: false,
            dataType: "html",
            error: function (xhr, status, error) {
                alert('มี error เกิดขึ้น: ' + error);
            },
            timeout: 30000, //กำหนด Timeout เท่ากับ 30 วินาที
            type: "GET",
            beforeSend: function () {
                console.log('log นี้เกิดใน Ajax beforeSend');
            },
            complete: function () {
                console.log('log นี้เกิดใน  Ajax complete');
            }
        });

        $("#btnSubmit").click(function (e) {
            e.preventDefault();
            $.ajax({
                url: "content2",
                success: function (data) {
                    $("#contentArea").html("").append(data);
                }
            });
        });
    });
</script>




