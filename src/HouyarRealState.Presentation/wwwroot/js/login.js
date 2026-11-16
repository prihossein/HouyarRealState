const mobile = document.getElementById("Mobile");

mobile.addEventListener("input", function () {
    this.value = this.value.replace(/\D/g, "");
});

mobile.addEventListener("keypress", function (e) {
    if (!/[0-9]/.test(e.key)) {
        e.preventDefault();
    }
});



