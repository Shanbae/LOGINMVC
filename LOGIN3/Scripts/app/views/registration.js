$("#btnregsubmit").click(function () {

    var f = $("#FirstName").val();
    var r = $("#LastName").val();
    var t = $("#Email").val();
    var fd= $("#phone").val();
    var fy = $("#ConfirmPassword").val();
    if ($("#FirstName").val() != '' && $("#LastName").val() != '' && $("#Email").val() != '' && $("#phone").val() != '' && $("#ConfirmPassword").val() != '' && $("#dob").val() != '') {
        $.ajax({
            url: '/api/Loginapi/Register',
            type: 'POST',
            datatype: 'json',
            contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
            data: $("#newRegistration").serialize(),
            sucess() { },
            error() { }

        });
    }
    else {
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

    }


});

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