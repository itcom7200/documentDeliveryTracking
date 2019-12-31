@Code
    ViewData("Title") = "Test"
End Code

<div class="row">
    <div class="col-md-4">
        <h2>Contact </h2>
        <address>
            <b>ID : </b>59121293<br />
            <b>Name : </b>สันติภาพ ตันประมวล<br />
            <b>Default point : </b>ตึกนวัตกรรม <br>
        </address>

        <address>
            <strong>E-mail:</strong>
        </address>
    </div>

    <div class="col-md-8">
        <h2>Document Delivery Tracking</h2>
        <div class="btn-group">
            <button id="getAll" class="btn btn-primary active">ALL</button>
            <button id="getCurrent" class="btn btn-primary">Current</button>
            <button id="getReject" class="btn btn-primary">Reject</button>
            <button id="getComplete" class="btn btn-primary">Complete</button>
        </div>

        <div class="container-fluid nopadding">

            <div id="main">


            </div>


        </div>

    </div>
</div>


<script type="text/javascript">
    $(document).ready(function () {
        $.get("viewAll", function (data) {
            $("#main").html(data);
        });

        $('.btn-group').on('click', '.btn', function () {
            $(this).addClass('active').siblings().removeClass('active');
        });

        $("#getAll").click(function () {
            $.get("viewAll", function (data) {
                $("#main").html(data);
            });
        });

        $("#getCurrent").click(function () {
            $.get("viewCurrent", function (data) {
                $("#main").html(data);
            });
        });

        $("#getReject").click(function () {
            $.get("viewReject", function (data) {
                $("#main").html(data);
            });
        });

        $("#getComplete").click(function () {
            $.get("viewComplete", function (data) {
                $("#main").html(data);
            });
        });

    });
</script>

