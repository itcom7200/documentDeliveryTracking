@Code
    ViewData("Title") = "Content"
End Code

<h2>Content</h2>

<div class="row">


    <div class="col-md-6">
        <h2>@ViewData("Message")</h2>
        
    </div>
    <div class="col-md-6">
        <h3>Document Delivery Transection</h3>
        <table class="table table-borderless">
            
            <tr>
                <td>
                    <b><img class="img-responsive" src="~/Content/Icon/iconWaiting2.png"></b> &nbsp; &nbsp;

                </td>
                <td>
                    <b>รับคำร้องขอ</b><br>
                    สาขา : หอสมุดกลาง<br>
                    วันที่ : 11/11/2019 เวลา : 10:56 น.
                </td>
            </tr>
            <tr>
                <td>
                    <b><img class="img-responsive" src="~/Content/Icon/iconWaiting2.png"></b> &nbsp; &nbsp;

                </td>
                <td>
                    <b>ทำรายการเรียบร้อย</b><br>
                    เจ้าหน้าที่ : staff WU<br>
                    วันที่ : 11/11/2019 เวลา : 11:56 น.
                </td>
            </tr>
            <tr>
                <td>
                    <b><img class="img-responsive" src="~/Content/Icon/iconWaiting2.png"></b> &nbsp; &nbsp;

                </td>
                <td>
                    <b>Document รอนำส่ง</b><br>
                    Point : ตึกนวัตกรรม<br>
                    วันที่ : 11/11/2019 เวลา : 15:30 น.
                </td>
            </tr>
            <tr>
                <td>
                    <b><img class="img-responsive" src="~/Content/Icon/iconSuccess.png"></b> &nbsp; &nbsp;

                </td>
                <td>
                    <b>จัดส่งเรียบร้อยแล้ว</b><br>
                    ผู้รับ : สวัสดี วันจันทร์<br>
                    วันที่ : 11/11/2019 เวลา : 16:00 น.
                </td>
            </tr>


        </table>
    </div>
</div>