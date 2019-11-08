@Code
    ViewData("Title") = "About"
End Code

<script>
    $(document).ready(function () {
        $("#myInput").on("keyup", function () {
            var value = $(this).val().toLowerCase();
            $("#myTable tr").filter(function () {
                $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
            });
        });
    });
</script>

<div class="row">
    <div class="col-md-4">
        <h2>@ViewData("Title").</h2>
        <h3>@ViewData("Message")</h3>
        <p>Use this area to provide additional information.</p>
    </div>
    <div class="col-md-8">
        <h2>HTML Table</h2>
        <p>Type something in the input field to search the table for first names, last names or emails:</p>
        <input id="myInput" type="text" placeholder="Search.."><br><br>

        <table class="table table-hover">
            <tr>
                <th>Firstname</th>
                <th>Lastname</th>
                <th>Email</th>
            </tr>
            <tbody id="myTable">
                <tr>
                    <td>John</td>
                    <td>Doe</td>
                    <td>john@example.com</td>
                </tr>
                <tr>
                    <td>Mary</td>
                    <td>Moe</td>
                    <td>mary@mail.com</td>
                </tr>
                <tr>
                    <td>July</td>
                    <td>Dooley</td>
                    <td>july@greatstuff.com</td>
                </tr>
                <tr>
                    <td>Anja</td>
                    <td>Ravendale</td>
                    <td>a_r@test.com</td>
                </tr>
            </tbody>
        </table>


    </div>
</div>


