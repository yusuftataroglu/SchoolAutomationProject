// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
https://localhost:7070/admin/home/index

//function OpenStudentPopup(studentId) {
//    document.body.innerHTML += `
//<div class="modal-dialog modal-dialog-centered">
//  ...
//</div>`
//};

function OpenStudentPopup(studentId, studentFirstName, studentLastName) {
    // Modal HTML kodunu oluştur
    var modalHtml = `
            <div id="popupModal" class="modal fade" tabindex="-1" role="dialog">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title">Öğrenci İşlemleri</h5>
                            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div class="modal-body">
                            <p>${studentFirstName} ${studentLastName} öğrencisi için yapmak istediğiniz işlemi seçin:</p>
                            <button onclick="RedirectToAddAttendance('${studentId}')" class="btn btn-primary">Devamsızlık Bilgisi Gir</button>
                            <button onclick="RedirectToAddGrade('${studentId}')" class="btn btn-success">Not Bilgisi Gir</button>
                        </div>
                    </div>
                </div>
            </div>
        `;

    // Modalı sayfaya ekle
    document.body.innerHTML += modalHtml;

    // Modalı göster
    var modal = new bootstrap.Modal(document.getElementById('popupModal'));
    modal.show();
}

function RedirectToAddGrade(studentId) {
    window.location.href = `https://localhost:7070/teacher/grades/addwithstudentinfos/${studentId}`;
}

function RedirectToAddAttendance(studentId) {
    window.location.href = `https://localhost:7070/teacher/attendances/addwithstudentinfos/${studentId}`;
}
