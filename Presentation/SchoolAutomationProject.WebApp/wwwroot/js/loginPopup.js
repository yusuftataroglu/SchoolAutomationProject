// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


// Login pop-up'ı göster
function showLoginPopup() {
    document.getElementById('loginPopup').style.display = 'block';
}

// Login pop-up'ı gizle
function hideLoginPopup() {
    document.getElementById('loginPopup').style.display = 'none';
}

// Login butonuna tıklandığında
document.getElementById("getLoginPopupButton").onclick = function () {
    showLoginPopup(); // Login pop-up'ı göster
};

// Pop-up içindeki login butonuna tıklandığında
document.getElementById("closeButton").onclick = function () {
    hideLoginPopup();// Login pop-up'ı gizle
}

document.getElementById("loginButton").onclick = function () {

    var username = $("#username").val();
    var password = $("#password").val();

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
                        validationSummary.style.display="block";
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
}


// Login pop-up'ın dışına tıklandığında
window.onclick = function (event) {
    var loginPopup = document.getElementById('loginPopup');
    if (event.target == loginPopup) {
        hideLoginPopup(); // Login pop-up'ı gizle
    }
};

