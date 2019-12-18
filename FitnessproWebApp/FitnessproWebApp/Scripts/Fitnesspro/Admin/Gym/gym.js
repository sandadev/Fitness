$(document).ready(function () {
    BindGymDetails();
    $('#btnSaveGym').click(function () { CreateGym(); });
});


function BindGymDetails() {

    var table = $("#tblGym").DataTable({
        ajax: {
            url: "https://localhost:44390/api/Admin/GymList",
            dataSrc:"",
        },
        columns: [
            {
                data: "GymId",
            },
            {
                data:"GymName",
            },
            {
                data: "FirstName"
            },
            {
                data: "LastName"
            },
            {
                data: "MobileNumber"
            },
            {
                data: "EnrolledDate"
            },
            {
                data: "Email"
            },
            {
                data: "GymId",
                render: function (data) {
                    return "<a href='' class='btn btn-secondary btn-block role='button'>Edit</a>";
                }
            },
           
        ]
    });
}

function CreateGym() {
    var Gym = 1;
        var jsonObject = {
            GymName: $('#txtGymName').val(),FirstName: $('#txtFirstName').val(),
            LastName: $('#txtLastName').val(), Email: $('#txtEmail').val(), MobileNumber: $('#txtMobileNumber').val(), TelephoneNumber: $('#txtTelephoneNumber').val(),
            EnrolledDate: $('#txtEnrollDate').val(), EstablishedYear: $('#txtEstablishedYear').val(), ServiceId: Gym
        }
        $.ajax({
            cache: false,
            type: "POST",
            url: "https://localhost:44390/api/Admin/CreateGym" ,
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify(jsonObject),
            success: function (data) {
               
            },
            failure: function (errMsg) {
                HideLoader();
                alert(errMsg.responseText);
            }
        });

    }
