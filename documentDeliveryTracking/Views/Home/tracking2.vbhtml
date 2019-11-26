@Code
    ViewData("Title") = "tracking2"
End Code

<div class="row">
    <div class="col-md-4">
        <h2>Contact </h2>
        <p>Use this area to provide additional information.</p>
        <address>
            ID : 59121293<br />
            Name : สันติภาพ ตันประมวล<br />
            Default point : ตึกนวัตกรรม <br>

        </address>

        <address>
            <strong>E-mail:</strong>   <a href="mailto:suntiparb.tu@mail.com">suntiparb.tu@mail.com</a><br />

        </address>



    </div>
    <div class="col-md-8">
        <h2>Document Delivery Tracking </h2>
        <div class="col-xs-12">
        </div>
        <div class="btn-group btn-toggle">
            <label class="btn btn-primary active"><input type="radio" onclick="loadPage('all')">ALL</label>
            <label class="btn btn-primary"><input type="radio" onclick="loadPage('current')">Current</label>
            <label class="btn btn-primary"><input type="radio" onclick="loadPage('reject')">Reject</label>
            <label class="btn btn-primary"><input type="radio" onclick="loadPage('complete')">Complete</label>
        </div>

        <div id="showcontent" class="container-fluid"></div>












    </div>
</div>

<script type="text/javascript">

    function loadPage(page) {
        var x = new XMLHttpRequest();
        x.open("get", page);
        x.onreadystatechange = function () {
            var content = document.getElementById("showcontent");
            content.innerHTML = x.responseText;
        }
        x.send(null);
    }
</script>