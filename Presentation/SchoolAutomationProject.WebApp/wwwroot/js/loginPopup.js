// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
https://localhost:7070/admin/home/index

$(document).ready(() => {
    //CheckToken();
});

function CheckToken() {
    let token = localStorage.getItem("appJwt")
    if (token != null) {
        //RedirectToAdminArea(token);
    }
};



function RedirectToAdminArea(token) {
    $.ajax({
        url: "https://localhost:7070/admin",
        type: "Get",
        headers: {
            "accept": "application/json",
            "content-type": "application/json",
            "Authorization": "Bearer " + token
        },
        success: function (data) {
            console.log(data);
            window.location.href="https://localhost:7070/admin";
        },
        error: function (err) {
            console.log(err);
        }
    })
};

function Login() {
    const username = $("#username").val();
    const password = $("#password").val();

    $.ajax({
        url: "https://localhost:7186/api/Home",
        type: "Post",
        contentType: 'application/json',
        data: JSON.stringify({
            userName: username,
            password: password
        }),
        success: function (data) {
            console.log(data);
            localStorage.setItem("appJwt", data);
            CheckToken();
        },
        error: function (err) {
            // Gelen hata objesinin içeriğini kontrol edin
            if (err.responseJSON && err.responseJSON.errors) {
                // Hata mesajlarını alın
                var errorMessages = err.responseJSON.errors;

                // Hata mesajlarını validationSummary elementine ekleyin
                var validationSummary = document.getElementById("validationSummary");
                validationSummary.innerHTML = ""; // Önceki içeriği temizleyin
                for (var key in errorMessages) {
                    if (errorMessages.hasOwnProperty(key)) {
                        var errorMessage = errorMessages[key];
                        validationSummary.style.display = "block";
                        validationSummary.innerHTML += '<div>' + errorMessage + '</div>';
                    }
                }
            } else {
                // Hata objesi uygun formatta değilse genel bir hata mesajı gösterin
                document.getElementById("validationSummary").innerHTML = "Bir hata oluştu. Lütfen tekrar deneyin.";
            }
        }

    }
    )
};

$("#loginButton").click(function (e) { 
    Login();
});




