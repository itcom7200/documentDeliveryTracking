@Code
    ViewData("Title") = "wait"
End Code

<div class="row">
    <div class="col-md-4">
        <h2>Contact </h2>
        <address>
            <b>ID : </b>59121293<br />
            <b>Name : </b>สันติภาพ ตันประมวล<br />
            <b>Default point : </b>ตึกนวัตกรรม <br>
            @*<div class="col-xs-12 nopadding">
                    <div class="col-xs-1 nopadding"> <img class="img-thumbnail" src="/Content/Icon/iconHome.png"></div>
                    <div class="col-xs-9">
                        : ตึกนวัตกรรม<br>
                        :<b> DeliverDate 11/11/2020 12.30 </b>
                    </div>
                </div>*@

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
            <button id="getAll" class="btn btn-primary">All</button>
        </div>

        <div class="container-fluid nopadding">

            <div id="main">

            </div>

        </div>

    </div>
</div>


<script type="text/javascript">
    $(document).ready(function () {

        var resultMaster, numI = "";

        $('.btn-group').on('click', '.btn', function () {

            $(this).addClass('active').siblings().removeClass('active');

            switch (this.id) {
                case "getAll":
                    getId = null;
                    break;
                case "getCurrent":
                    getId = 1;
                    break;
                case "getReject":
                    getId = 0;
                    break;
                case "getComplete":
                    getId = 2;
                    break;
            }

            //console.log(getId);
            $("#main").empty();

            $.each(resultMaster, function (i) {

                //console.log(resultMaster);
                var { DDRECSTATUS } = resultMaster[i];

                //console.log(DDRECSTATUS.__proto__);

                switch (getId) {
                    case DDRECSTATUS:
                        //console.log(`ID = ${getId} & REC = ${DDRECSTATUS} จาก click id ตรงกัน`);
                        numI = i;
                        renderData(resultMaster[i], i);
                        break;
                    case null:
                        //console.log(`ID = ${getId} & REC = ${DDRECSTATUS} จาก click ALL`);
                        numI = i;
                        renderData(resultMaster[i], i);
                        break;
                    default:
                        //console.log(`ไม่ตรงกัน`);
                        //$("#main").append('ไม่มีข้อมูล');
                        break;
                }
            });


        });

        async function ajax() {
            var result = "";
            await $.ajax({
                //"url": "http://localhost:3000/test", // mockup json-server 'http://localhost:3000/tracking'
                "url": "https://wulibdemoapi.walaiautolib.com/wulib/api/NDDRequest/13",
                //"url": "http://localhost:3000/tracking",
                "method": "GET",
                "timeout": 0,
                "success": function (data) {
                    result = data;
                    resultMaster = data;
                    //console.log(`Log จาก ajax`);
                    //console.log(result);
                },
                "error": function () {
                    result = "Webservice ERROR!";
                }
            });

            return result;

        }

        async function filterDataDefault(data) {

            //console.log(`Log จาก filterData`);

            //console.log(data);

            $.each(data, function (i) {
                var { DDRECSTATUS } = data[i];

                var defaultID = 1; // current process id

                switch (defaultID) {
                    case DDRECSTATUS:
                        //console.log(`ID = ${defaultID} & REC = ${DDRECSTATUS} จาก default`); //
                        //console.log(`ข้อมูลก้อนที่ ${i} นำไป render`);
                        //console.log(data[i]);
                        
                        renderData(data[i], i);

                        break;
                    default:
                        //console.log(`ไม่ตรงกัน`);
                        break;
                }
            });

        }

        async function renderData(data, i) {
            //console.log(`จะ render ละนะ`);
            //console.log(data);


            var { TITLE, BIBID, BARCODE, DDRECSTATUS, REQUESTDATE, REQUESTTIME, DELIVERDATE, DELIVERTIME, REQUESTCODE, DDPOINTNAME, DDADDRESS,
                DDDISTRICTNAME, DDPROVINCENAME, DDPOSTCODE, EDITFLAG, DELETEFLAG, DDCURRENTPROCESS, URL, DDTYPEID, DDCOST, DOWNLOADLINK } = data;
            //console.log(TITLE);

            var reqYear = REQUESTDATE.substring(0, 4);
            var reqMonth = REQUESTDATE.substring(4, 6);
            var reqDate = REQUESTDATE.substring(6, 8);

            var btnColor, location, iconType, divSendpoint, messageType, cost = '';

            switch (DDRECSTATUS) {
                case 0: // Reject
                    btnColor = "btn-danger";
                    break;
                case 1: // Active
                    btnColor = "btn-warning";
                    break;
                case 2: // Close
                    btnColor = "btn-success";
                    break;

            }

            switch (DDCOST) {
                case null:
                    cost = "";
                    break;
                default:
                    cost = DDCOST;
                    break;
            }

            

            switch (DDTYPEID) {
                case 1: // P2F
                    messageType = "File delivery";
                    iconType = "iconDoc.png";

                    divSendpoint = `<div class="col-xs-2 col-sm-1 nopadding"> <img class="img-thumbnail" src="/Content/Icon/${iconType}"></div>
                    <div class="col-xs-9">
                         <a href="${DOWNLOADLINK}" target="_blank">Download</a> <!-- DOWNLOADLINK -->
                    </div>`;



                    break;
                case 2:  //P2P
                    var deliverYear = DELIVERDATE.substring(0, 4);
                    var deliverDate = DELIVERDATE.substring(6, 8);
                    var deliverMonth = DELIVERDATE.substring(4, 6);

                    var deliverHour = DELIVERTIME.substring(0, 2);
                    var deliverMin = DELIVERTIME.substring(2, 4);

                    messageType = "Point to point";

                    location = `${DDPOINTNAME} <br><br> <!--<b>กำหนดส่ง</b> --> <br> ${deliverDate}/${deliverMonth}/${deliverYear} ${deliverHour}:${deliverMin} น.`;
                    iconType = "iconCar.png";

                    divSendpoint = `<div class="col-xs-2 col-sm-1 nopadding"> <img class="img-thumbnail" src="/Content/Icon/${iconType}"></div>
                    <div class="col-xs-9">
                         ${DDPOINTNAME}<br>
                         ${deliverDate}/${deliverMonth}/${deliverYear} ${deliverHour}:${deliverMin} <br>
                    </div>`;

                    break;
                case 3: //P2H
                    messageType = "Point to home";

                    location = `${DDADDRESS} ${DDDISTRICTNAME}`;
                    //location = `${DDADDRESS} ${DDDISTRICTNAME} ${DDPROVINCENAME} ${DDPOSTCODE}`;
                    iconType = "iconHome.png";

                    divSendpoint = `<div class="col-xs-2 col-sm-1 nopadding"> <img class="img-thumbnail" src="/Content/Icon/${iconType}"></div>
                    <div class="col-xs-9">
                         ${location}
                    </div>`;

                    break;
            }





            switch (EDITFLAG) {
                case "0": // can edit
                    editBtn = `<!-- Button trigger modal (Edit model)  -->
                        <button type="button" class="btn-xs btn btn-primary" data-toggle="modal" data-target="#exampleModalEdit${i}">
                            <img src="/Content/Icon/IconEdit2.png">
                        </button>

                        <!-- Modal -->
                        <div class="modal fade" id="exampleModalEdit${i}" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                            <div class="modal-dialog" role="document">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <h5 class="modal-title" id="exampleModalLabel">Edit your Request</h5>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>
                                    <div class="modal-body">
                                        <div id="btnTime" class="btn-group">
                                            <button class="btn btn-primary">12.00 วันพุธ</button>
                                            <button class="btn btn-primary">12.00 วันพฤหัส</button>
                                            <button class="btn btn-primary">12.00 วันศุกร์</button>

                                        </div>
                                        <div class="form-group">
                                            <label for="test2">Note:</label>
                                            <input type="text" class="form-control" id="pwd">
                                        </div>
                                    </div>

                                    <div class="modal-footer">
                                        <button type="button" class="btn btn-success" data-dismiss="modal">Save</button>
                                        <button type="button" class="btn " data-dismiss="modal">Cancle</button>
                                    </div>
                                </div>
                            </div>
                        </div><!-- div close modal-->`;
                    break;
                case "1": // Active
                    editBtn = "";
                    break;
            }

            switch (DELETEFLAG) {
                case "0": // can delete
                    deleteBtn = `<!-- Button trigger modal (Reject model)  -->
                        <button type="button" class="btn-xs btn btn-danger" data-toggle="modal" data-target="#exampleModalReject${i}">
                            <img src="/Content/Icon/IconReject2.png">
                        </button>

                        <!-- Modal -->
                        <div class="modal fade" id="exampleModalReject${i}" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                            <div class="modal-dialog" role="document">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <h5 class="modal-title" id="exampleModalLabel">Reject Confirms</h5>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>
                                    <div class="modal-body">
                                        Are you sure you want to do this !
                                    </div>
                                    <div class="modal-footer">
                                        <button type="button" class="btn btn-danger" data-dismiss="modal">Reject</button>
                                        <button type="button" class="btn " data-dismiss="modal">Cancle</button>
                                    </div>
                                </div>
                            </div>
                        </div><!-- div close modal-->`;
                    break;
                case "1": // Active
                    deleteBtn = "";
                    break;
            }

            // เรียก อีก function เพื่อ ajax & loopRow

            let resultRow =  await getRowData(REQUESTCODE);
            //let resultRow = '1';

            //console.log(a);

            let htmlLayout = `<hr class="hr-set-margin" />

<div class="row">
    <div class="col-xs-5 col-sm-3 col-lg-3">
        <img class="img-clover-book img-thumbnail" src="${URL}">
        <br><br>
    </div>
    <div class="col-sm-8 col-lg-7">
        <div class="col-xs-7 col-sm-12">
            <div class="row">
                <b>Title:</b> <a class="text-info" href="http://192.168.74.221/psru/catalog/BibItem.aspx?BibID=${BIBID}"
                                 target="_blank">${TITLE}</a><br>
                <b>Barcode:</b> ${BARCODE}<br>
                <b>Fee: </b> ${cost} <!-- ${reqDate}/${reqMonth}/${reqYear} --> <br><br>
                <div class="col-xs-12 nopadding">
                    ${divSendpoint}
                </div>
                <br><br><br>
            </div>
        </div>
        <div class="col-xs-12">
            <div class="row">
                <div class="col-xs-7 col-sm-6 col-lg-7">
                    <div class="row">
                        
                        <!-- Button -->
                        <button type="button" class="btn ${btnColor} btn-block" data-toggle="modal" data-target="#exampleModalScrollable${i}">
                            <b>${DDCURRENTPROCESS}</b>
                        </button>
                        <!-- Modal -->
                        <div class="modal fade" id="exampleModalScrollable${i}" tabindex="-1" role="dialog" aria-labelledby="exampleModalScrollableTitle" aria-hidden="true">
                            <div class="modal-dialog modal-dialog-scrollable" role="document">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <h2 class="modal-title text-green-opac" id="exampleModalScrollableTitle">Track & Trace</h2>
                                        <h4 class="text-header-track-and-trace"><!-- รอบที่จัดส่ง: 11/11/2019 เวลา: 15:30 น. --> Type: ${messageType}</h4>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>
                                    <div class="modal-body">
                                        <!-- start body textbox -->
                                        ${resultRow}

                                    </div> <!-- modal-body -->

                                </div>
                            </div>
                        </div>
                        <!-- Button&Model -->
                    </div>

                </div>

                <div class="col-xs-5">
                    ${editBtn}
                    ${deleteBtn}
                </div> 
            </div>
        </div>
    </div>
    <div id="QRcode${i}" class="visible-lg col-xs-2 nopadding">
        
    </div>


</div>`;

            
            $("#main").append(htmlLayout);
            await genQR(i,REQUESTCODE);
        }

        function genQR(i,requestCode) {
            //console.log(`ตรงที่จะ render ${i}`);
            var GenQRcode = `http://localhost:49777/Test/requestcode?trackingId=${requestCode}`;
            if (GenQRcode !== "") {
                new QRCode(document.getElementById(`QRcode${i}`), {
                    text: GenQRcode,
                    width: 110,
                    height: 110
                });
            }
        }

        async function getRowData(id) {

            var requestCodeData = '';

            await $.ajax({
                data: `requestcode=${id}`,
                "url": "https://wulibdemoapi.walaiautolib.com/wulib/api/NDDTrackinginfo",
                "method": "GET",
                "timeout": 0,
                "success": function (data) {
                    requestCodeData = data;
                },
                "error": function () {
                    console.log("Webservice ERROR!");
                }
            });

            var icon, line, row, resultRow = '';

            $.each(requestCodeData.tracking, function (i) {

                var { DDHISDATE, DDHISTIME, USERFLAG, ACTPERSONID, DDACTDETAIL, ICONFLAG, ACTPERSON } = requestCodeData.tracking[i];

                switch (ICONFLAG) {
                    case 0:
                        icon = "iconTime.png";
                        break;
                    case 1:
                        icon = "iconFail.png";
                        break;
                    case 2:
                        icon = "iconCancle.png";
                        break;
                    case 3:
                        icon = "iconInfo.png";
                        break;
                    case 4:
                        icon = "iconPlane.png";
                        break;
                }

                switch (DDACTDETAIL) {
                    case "Waiting for Accept":
                        line = "icon-noline";
                        break;
                    default:
                        line = "icon";
                }

                let hisYear = DDHISDATE.substring(0, 4);
                let hisMonth = DDHISDATE.substring(4, 6);
                let hisDate = DDHISDATE.substring(6, 8);

                let hisTime = DDHISTIME.substring(0, 2);
                let hisMin = DDHISTIME.substring(2, 4);

                var row = `<div class="row">
                            <div class="col-xs-3 col-sm-2 nopadding">
                                <div class="${line}-request">
                                    <img class="img-iconfix-request" src="/Content/Icon/${icon}">
                                </div>
                            </div>
                            <div class="col-xs-9">
                                <b class="lead text-green-opac">${DDACTDETAIL}</b><br>
                                ${ACTPERSON} <br>
                                Date ${hisDate}/${hisMonth}/${hisYear} Time ${hisTime}:${hisMin} น. 
                                
                            </div>

                        </div>`;

                resultRow += row;




            });

            return resultRow;



        }


        async function main() {

            let data = await ajax();
            //console.log(data);
            await filterDataDefault(data);

        }

        main();



    });

</script>

