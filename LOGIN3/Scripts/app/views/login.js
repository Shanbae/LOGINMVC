/*$(document).ready(function () {*/
$("#btnsubmit").click(function () {
    var userName = $("#userName").val();
    var passWord = $("#passWord").val();
    
    var result = addusernamepassword(userName, passWord);
    var f = 5;


});
addusernamepassword = function (userName, passWord) {
    
    $.ajax({

        url: '/api/Loginapi/LoginPost',
        type: 'POST',
        datatype: 'json',
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
        data: $("#login").serialize(),         
        success: function (data) {
            var f = 2;
            var d = 0;
            if (data.AuthorizedUser) {

            }
            if (data.UnkownUser) {
                NewRegistration();

            }
            alert(' sucess');
        },
        error: function (data) {
            alert("failure");
        }

    });
}
NewRegistration = function () {

    window.location.href = registrationurl;

    //$.ajax({

    //    url: registrationurl,
    //    type: 'GET'

    //});




}
