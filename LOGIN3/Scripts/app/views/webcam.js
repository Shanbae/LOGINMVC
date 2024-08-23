//$(function () {
//    //Webcam.set({
//    //    width: 320,
//    //    height: 240,
//    //    image_format: 'jpeg',
//    //    jpeg_quality: 90
//    //});
//    $("#btnCamera").click(function () {
//        Webcam.set({
//            width: 320,
//            height: 240,
//            image_format: 'jpeg',
//            jpeg_quality: 90
//        });
//        Webcam.attach('#webcam');
//    });
    
//    $("#btnCapture").click(function () {
//        Webcam.snap(function (data_uri) {
//            $("#imgCapture")[0].src = data_uri;
//            $('#btnCapture').attr('disabled', true);
//            const bytestring = atob(data_uri.split(',')[1]);
//            const arraybuffer = new ArrayBuffer(bytestring.length);
//            const uint8array = new Uint8Array(arraybuffer);
//            $('#btnImgDelete').attr('disabled', false);

//            for (let i = 0; i < bytestring.length; i++) {
//                uint8array[i] = bytestring.charCodeAt(i);
//            }

//            // Convert byte array to JSON
//            const json = JSON.stringify({ imageData: Array.from(uint8array) });
//            $.ajax({
//                url: '/api/Loginapi/Webcam',
//                type: 'POST',
//               datatype:'json',
//                contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
//                data: json,
//                success: {},
//                error: {},
//                completed: {}



//            });
//            //Webcam.upload(data_uri, 'Home/ProcessaUploadedFile', function (code, text) {
//            //    alert('Photo Captured and saved.')
//            //});
//        });
//    });

//});