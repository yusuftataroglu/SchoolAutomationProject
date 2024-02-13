// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.getElementById("loginButton").onclick = function () {
    validationSummary.style.display = "block";
}
//document.getElementById("loginButton").onclick = function () {

//    var username = $("#username").val();
//    var password = $("#password").val();

//    $.ajax({
//        url: "https://localhost:7186/api/Home",
//        type: "Post",
//        contentType: 'application/json',
//        data: JSON.stringify({
//            userName: username,
//            password: password
//        }),
//        success: function (data) {

//            console.log(data);
//        },
//        error: function (err) {
//            // Gelen hata objesinin içeriğini kontrol edin
//            if (err.responseJSON && err.responseJSON.errors) {
//                // Hata mesajlarını alın
//                var errorMessages = err.responseJSON.errors;

//                // Hata mesajlarını validationSummary elementine ekleyin
//                var validationSummary = document.getElementById("validationSummary");
//                validationSummary.innerHTML = ""; // Önceki içeriği temizleyin
//                for (var key in errorMessages) {
//                    if (errorMessages.hasOwnProperty(key)) {
//                        var errorMessage = errorMessages[key];
//                        validationSummary.style.display="block";
//                        validationSummary.innerHTML += '<div>' + errorMessage + '</div>';
//                    }
//                }
//            } else {
//                // Hata objesi uygun formatta değilse genel bir hata mesajı gösterin
//                document.getElementById("validationSummary").innerHTML = "Bir hata oluştu. Lütfen tekrar deneyin.";
//            }
//        }

//    }
//    )
//}


// Login pop-up'ın dışına tıklandığında


