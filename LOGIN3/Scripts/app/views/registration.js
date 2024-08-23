$("#btnregsubmit").click(function () {

    var f = $("#FirstName").val();
    var r = $("#LastName").val();
    var t = $("#Email").val();
    var fd = $("#phone").val();

    var fy = $("#ConfirmPassword").val();
    //if ($("#FirstName").val() != '' && $("#LastName").val() != '' && $("#Email").val() != '' && $("#phone").val() != '' && $("#ConfirmPassword").val() != '' && $("#dob").val() != '') {
        $.ajax({
            url: '/api/Loginapi/Register',
            type: 'POST',
            datatype: 'json',
            contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
            data: $("#newRegistration").serialize(),
            sucess() { },
            error() { }

        });
    //}
   // else {
        $(".form-control").each(function () {
            if ($(this).val() == '')
            {
                var id = this.id;
                var field_name = "#" + id;
                var valid_msg = field_name + "error";
                if ($(this).val() == '') {
                    $(valid_msg).html("<p>" + id + " is Required</p>");
                }
                else
                    $(valid_msg).html("<p> </p>");
            }


        });

   // }


});
$("#StatesID").on('change', function (event) {
    var selectedStateId = $(this).val();
    $("#DistrictID option").hide(); // Hide all district options
    $("#DistrictID option:first").show(); // Show the "Select District" option

    $("#DistrictID option").filter(function () {
        return $(this).data('stateid') == selectedStateId;
    }).show();
})
$(".form-control").on('focusout',function (event) {

    
    var id = this.id;
    var field_name = "#" + id;
    var valid_msg = field_name + "error";
    if ($(this).val() == '') {
        $(valid_msg).html("<p>" + id + " is Required</p>");
    }
    else
        $(valid_msg).html("<p> </p>");


})


$("#SSLCTotalMark").on("focusout", function () {

    if ($("#SSLCTotalMark").val() != 0 && $("#SSLCmark").val() != 0) {
        var totalmark=$("#SSLCTotalMark").val();
        var minimummark = $("#SSLCmark").val();
        var avg = (minimummark / totalmark) * 100;
        $("#SSLCAverage").val(avg);
        $("#SSLCAverage").css("color", "white");

    }

});
$("#SSLCmark").on("focusout", function () {

    if ($("#SSLCTotalMark").val() != 0 && $("#SSLCmark").val() != 0) {
        var totalmark = $("#SSLCTotalMark").val();
        var minimummark = $("#SSLCmark").val();
        var avg = (minimummark / totalmark) * 100;
        $("#SSLCAverage").val(avg);
        $("#SSLCAverage").css("color", "white");

    }

});
$("#ConfirmPassword").on('keyup', function () {
    
    if ($("#RegistrationPassword").val() != '') {
        var id = this.id;
        var field_name = "#" + id;
        var valid_msg = field_name + "error";
        if ($("#RegistrationPassword").val() == $("#ConfirmPassword").val()) {
      
            $(valid_msg).html('<p style="color: green; ">Password Incorrect </p>');
        }
        else
            $(valid_msg).html('<p style="color: red; ">Password Incorrect </p>');
    }
   
});

    //Webcam.set({
    //    width: 320,
    //    height: 240,
    //    image_format: 'jpeg',
    //    jpeg_quality: 90
    //});
    $("#btnCamera").click(function () {
        Webcam.set({
            width: 320,
            height: 240,
            image_format: 'jpeg',
            jpeg_quality: 90
        });
        Webcam.attach('#webcam');
    });

    $("#btnCapture").click(function () {
        Webcam.snap(function (data_uri) {
            $("#imgCapture")[0].src = data_uri;
            $('#btnCapture').attr('disabled', true);
           // const bytestring = atob(data_uri.split(',')[1]);
            $("#ImgData").val(data_uri.split(',')[1]);
            //const arraybuffer = new ArrayBuffer(bytestring.length);
            //const uint8array = new Uint8Array(arraybuffer);
            //$('#btnImgDelete').attr('disabled', false);

            //for (let i = 0; i < bytestring.length; i++) {
            //    uint8array[i] = bytestring.charCodeAt(i);
            //}

            //// Convert byte array to JSON
            //const json = JSON.stringify({ imageData: Array.from(uint8array) });
            //$("#ImgData").val(json);
            //$.ajax({
            //    url: '/api/Loginapi/Webcam',
            //    type: 'POST',
            //    datatype: 'json',
            //    contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
            //    data: json,
            //    success: {},
            //    error: {},
            //    completed: {}



            //});
            //Webcam.upload(data_uri, 'Home/ProcessaUploadedFile', function (code, text) {
            //    alert('Photo Captured and saved.')
            //});
        });
    });
$('#btnNext1').click(function () {


    window.location.href = nextAction;


});
