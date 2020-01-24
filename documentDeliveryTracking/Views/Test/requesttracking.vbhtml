@Code
    ViewData("Title") = "requesttracking"
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
            <strong>E-mail: </strong>@*<a href="mailto:suntiparb.tu@mail.wu.ac.th">*@suntiparb.tu@mail.wu.ac.th</a><br />
        </address>
    </div>

    <div class="col-md-8">
        <h2>Document Delivery Tracking</h2>
        <div class="btn-group">
            <button id="getCurrent" class="btn btn-primary active">Current</button>
            <button id="getReject" class="btn btn-primary">Reject</button>
            <button id="getComplete" class="btn btn-primary">Complete</button>
            <button id="getAll" class="btn btn-primary">ALL</button>
        </div>

        <div class="container-fluid nopadding">

            <div id="main">

            </div>

        </div>

    </div>
</div>

<script type="text/javascript">
    $(document).ready(function () {

        $.ajax({
            "url": "https://wulibdemoapi.walaiautolib.com/wulib/api/NDDRequest/59121293",
            "method": "GET",
            "timeout": 0,
            "success": function (data) {
                //console.log(data);

                var defaultID = "1"; // id 1 = current Process

                $.each(data, function (i) {

                    var { TITLE, BARCODE, DDRECSTATUS, REQUESTDATE, REQUESTTIME, DELIVERDATE, DELIVERTIME, DDSENDPOINTNAME, DDADDRESS,
                        DDDISTRICTNAME, DDPROVINCENAME, DDPOSTCODE, EDITFLAG, DELETEFLAG, DDCURRENTPROCESS, URL } = data[i];

                    switch (defaultID) {
                        case DDRECSTATUS:
                            console.log(`ID = ${defaultID} & REC = ${DDRECSTATUS} จาก default`); //
                            break;
                        default:
                            console.log(`ไม่ตรงกัน`);
                            break;
                    }
                });
            },
            "error": function () {
                console.log("webservice error! ,default ajax");
            }
        });



        $('.btn-group').on('click', '.btn', function () {

            $(this).addClass('active').siblings().removeClass('active');

            var getId = "1";

            switch (this.id) {
                case "getAll":
                    getId = null;
                    break;
                case "getCurrent":
                    getId = "1";
                    break;
                case "getReject":
                    getId = "3";
                    break;
                case "getComplete":
                    getId = "2";
                    break;
            }
            
            $.ajax({
                "url": "https://wulibdemoapi.walaiautolib.com/wulib/api/NDDRequest/59121293",
                "method": "GET",
                "timeout": 0,
                "success": function (data) {

                    $.each(data, function (i) {
                        var { TITLE, BARCODE, DDRECSTATUS, REQUESTDATE, REQUESTTIME, DELIVERDATE, DELIVERTIME, DDSENDPOINTNAME, DDADDRESS,
                            DDDISTRICTNAME, DDPROVINCENAME, DDPOSTCODE, EDITFLAG, DELETEFLAG, DDCURRENTPROCESS, URL } = data[i];
                        
                        switch (getId) {
                            case DDRECSTATUS , null:
                                console.log(`ID = ${getId} & REC = ${DDRECSTATUS} จาก click id ตรงกัน`);
                                break;
                            //case null:
                            //    console.log(`ID = ${getId} & REC = ${DDRECSTATUS} จาก click ALL`);
                            //    break;
                            default:
                                console.log(`ไม่ตรงกัน`);
                                break;
                        }
                        
                    });
                },
                "error": function () {
                    console.log("webservice error");
                }
            });

            

        });

        

    });



</script>