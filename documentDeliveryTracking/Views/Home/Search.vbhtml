@Code
    ViewData("Title") = "Search"
End Code

<h2>Search</h2>

<div class="container">
    <div class="row">
        <div class="form-group">
            <label for="usr">Name:</label>
            <input type="text" class="form-control" id="usr">
        </div>
        <div class="form-group">
            <label for="pwd">Password:</label>
            <input type="password" class="form-control" id="pwd">
        </div>
    </div>
</div>


<button class="btn btn-success" onclick="loadPage()">show Content</button>

<div id="showcontent">

</div>

<script type="text/javascript">

    function loadPage() {
        var x = new XMLHttpRequest();
        x.open("get", "content");
        x.onreadystatechange = function () {
            var content = document.getElementById("showcontent");
            content.innerHTML = x.responseText;
        }
        x.send(null);
    }
</script>





