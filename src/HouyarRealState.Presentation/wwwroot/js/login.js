$("#frmLogin").submit(function (e) {

    e.preventDefault();

    var model = new FormData(this);

    $(".submitWating").removeClass("hidden");
    $(".submit").addClass("hidden");

    $.ajax({
        type: "POST",
        data: model,
        url: "/Account/Login",
        processData: false,
        contentType: false,
        cache: false,
        success: function (d) {

            if (d.status == true) // Message Sent? Show the 'Thank You' message and hide the form
            {
                toastr.success(d.message);
                window.location.href = d.returnUrl;
            }

            else {
                $(".submit").removeClass("hidden");
                $(".submitWating").addClass("hidden");
                toastr.error(d.message);
            }

        }
    })

});