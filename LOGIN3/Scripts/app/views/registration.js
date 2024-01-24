$("#btnregsubmit").click(function () {

    var f = $("#FirstName").val();
    var r = $("#LastName").val();
    var t = $("#Email").val();
    var fd= $("#phone").val();
    var fy = $("#ConfirmPassword").val();

    $.ajax({
        url: '/api/Loginapi/Register',
        type: 'POST',
        datatype: 'json',
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
        data: $("#newRegistration").serialize(),
        sucess() { },
        error() { }

    });


});