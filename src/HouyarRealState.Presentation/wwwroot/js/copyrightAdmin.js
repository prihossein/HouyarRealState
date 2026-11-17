$(".copyright p").click(function () {

    $.ajax(
        {
            url: "/Home/GetRandomWordsOfElders/",
            cache: false,
            type: "GET",
            success: function (d) {
                if (d.status == true) {

                    console.log(d);

                    $(".copyright p").html(d.randomWordsOfElders.Words + "<strong> «" + d.randomWordsOfElders.Speaker + "»");
                }
                else {
                    alert("Error");
                }
            }
        }
    );


})