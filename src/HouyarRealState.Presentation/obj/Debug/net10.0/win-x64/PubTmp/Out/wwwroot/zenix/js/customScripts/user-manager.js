$(".btn-delete").click(function () {
    var id = $(this).attr('id');
    $('#userId').val(id);
})