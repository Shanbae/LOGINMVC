$(function () {
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
            
            $('#btnImgDelete').attr('disabled', false);
            Webcam.upload(data_uri, 'Home/ProcessaUploadedFile', function (code, text) {
                alert('Photo Captured and saved.')
            });
        });
    });

});