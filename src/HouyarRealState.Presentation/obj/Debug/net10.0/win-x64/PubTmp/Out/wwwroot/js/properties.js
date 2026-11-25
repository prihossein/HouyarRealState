$("#frmDelete").submit(function (e) {
    e.preventDefault();

    var model = new FormData(this);

    $(".btn-delete-submit").addClass("hidden");
    $(".btn-delete-submit-waiting").removeClass("hidden");

    $.ajax({
        type: "POST",
        data: model,
        url: "/Property/Delete",
        processData: false,
        contentType: false,
        cache: false,
        success: function (d) {

            if (d.status == true) {
                toastr.success(d.message);
                window.location.href = "/Properties";
            }
            else {
                toastr.error(d.message);
                $(".btn-delete-submit").removeClass("hidden");
                $(".btn-delete-submit-waiting").addClass("hidden");
            }

        }
    })

});



$(".btn-delete").click(function () {
    var id = $(this).attr('id');
    $('#propertyId').val(id);
});