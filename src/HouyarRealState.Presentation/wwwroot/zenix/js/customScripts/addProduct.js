function readURLLogo(input) {

    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#feautureIMG').attr('src', e.target.result);
        }

        reader.readAsDataURL(input.files[0]);
    }
}

$("#IntroThumbnail").change(function () {
    readThumbnailLogo(this);
});


function readThumbnailLogo(input) {

    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#thumbnailIMG').attr('src', e.target.result);
        }

        reader.readAsDataURL(input.files[0]);
    }
}

$("#FutureImage").change(function () {
    readURLLogo(this);
});

$("#ProductCategoryId").change(function () {
    $("#ProductSubCategoryId").empty();
    $.getJSON("/home/GetProductSubCategories/" + $("#ProductCategoryId :selected").val(),
        function (data) {
            $('#ProductSubCategoryId').children().remove().end()
            $.each(data,
                function () {

                    $("#ProductSubCategoryId").append('<option value=' + this.value + '>' + this.text + '</option>');

                });
        });
});

$('#tagInput').on("keypress", function (e) {
    if (e.keyCode == 13) {
        if ($(this).val() != "") {
            $('#tagsArea').append(
                "<div class='alert alert-info alert-dismissible' style='max-width:max-content;display:inline-table;margin:3px'><a class='close' data-dismiss='alert' aria-label='close'>&times;</a><strong name='selectedTags'>" + $(this).val() + "</strong><input type='hidden' name='selectedTags' value='" + $(this).val() + "'/></div>"
            );
            $(this).val("");
        }
        return false;
    }
});

//============
$("#modalProductSpecification .modal-footer .btn-submit").click(function () {
    var addSpecificationTitle = $('[name="addSpecificationTitle"]').val();
    var addSpecificationDescription = $('[name="addSpecificationDescription"]').val();

    var validate = ValidateModalProductSpecification();

    if (validate == true) {
        $("#tblProductSpecification").find('tbody')
            .append($('<tr>')
                .append($('<td>')
                    .append(addSpecificationTitle + "<input type='hidden' name='productSpecificationTitle' value='" + addSpecificationTitle + "' />")
                ).append($('<td>')
                    .append(addSpecificationDescription + "<input type='hidden' name='productSpecificationDescription' value='" + addSpecificationDescription + "' />")
                ).append($('<td>')
                    .append("<a href='javascript:void(0)' id='btnDelete' class='text-danger' title='حذف'><i class='fa fa-trash'></i></a>")
                )
        );

        $('[name="addSpecificationTitle"]').val('');
        $('[name="addSpecificationDescription"]').val('');
    }

});

function ValidateModalProductSpecification() {

    var addSpecificationTitle = $('[name="addSpecificationTitle"]').val();
    var addSpecificationDescription = $('[name="addSpecificationDescription"]').val();

    if (addSpecificationTitle == "") {
        $("#addSpecificationTitleValidate").removeClass("display-none");
        return false;
    } else {
        $("#addSpecificationTitleValidate").addClass("display-none");
    }

    if (addSpecificationDescription == "") {
        $("#addSpecificationDescriptionValidate").removeClass("display-none");
        return false;
    } else {
        $("#addSpecificationDescriptionValidate").addClass("display-none");
    }

    return true;
}


$("#tblProductSpecification").on("click", "#btnDelete", function () {
    $(this).closest("tr").remove();
});

//================================
$("#PartnerPrice").on("input", function () {
    var number = $(this).val()

    if (number == "") {
        $("#stringPartnerPrice").html("")
    } else {
        $.ajax({
            url: "/home/NumberToString/" + number,
            cache: false,
            success: function (data) {
                $("#stringPartnerPrice").html(data.stringNumber + " تومان");
            }
        });
    }
});

$("#SalePrice").on("input", function () {
    var number = $(this).val()

    if (number == "") {
        $("#stringSalePrice").html("")
    } else {
        $.ajax({
            url: "/home/NumberToString/" + number,
            cache: false,
            success: function (data) {
                $("#stringSalePrice").html(data.stringNumber + " تومان");
            }
        });
    }
});

