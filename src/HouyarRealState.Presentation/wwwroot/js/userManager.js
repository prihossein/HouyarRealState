$("#frmAdd").submit(function (e) {
    e.preventDefault();

    var model = new FormData(this);

    $(".btn-submit").addClass("hidden");
    $(".btn-submit-waiting").removeClass("hidden");

    $.ajax({
        type: "POST",
        data: model,
        url: "/UserManager/AddUser",
        cache: false,
        success: function (d) {
            if (d.status == true) // Message Sent? Show the 'Thank You' message and hide the form
            {
      
                toastr.success(d.message);
                window.location.href = "/UserManager";
            }

            else {

                toastr.error(d.message);
                $(".btn-submit").addClass("hidden");
                $(".btn-submit-waiting").removeClass("hidden");
            }

        }
    })
 
});