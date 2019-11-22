@Code
    ViewData("Title") = "ajaxJson"
End Code

<input type="button" name="btnSend" id="btnSend" value="Send">

<script type="text/javascript">
    $(document).ready(function () {

        $("#btnSend").click(function () {

            var jsonObj = { "name": "Suntiparb", "age": "21" }

            $.ajax({
                type: "POST",
                url: "about",
                data: jsonObj,
                success: function (result) {
                    alert(result);
                }
            });

        });

    });
</script>

<!--
<h2>ajaxJson</h2>

<div>ตัวอย่าง</div>
<div id="mindphp">Mindphp.com</div>
<div class="classmindphp">ข้อความที่อยู่ใน classmindphp Mindphp.com</div>
<p class="classmindphp">ข้อความที่อยู่ใน classmindphp Tag p</p>
<div id="mindphp2">TODO write content</div>
<button id="Mybutton">Mybutton</button>

<script language="javascript" type="text/javascript">
    $(document).ready(function () {
        $('#Mybutton').click(function () {
            $.ajax({
                url: "123546", // Not found อยู่
                dataType: "json",
                success: function (datajson) {
                    $("#mindphp2").html(datajson.a);
                },
            })
        })

    });

</script>
    -->
