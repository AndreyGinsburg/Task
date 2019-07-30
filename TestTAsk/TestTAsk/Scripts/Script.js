$(document).ready(function () {
    $("#pat").click(function () {
        var name = $("#name").val();
        if (name) {
            var href = "/Pat/Index?phone=" + encodeURIComponent(name);
            $("#pat").attr("href", href).click();
        }
    });
    $("#doc").click(function () {
        var password = $("#password").val();
        if (name) {
            var href = "/Doc/Index?password=" + encodeURIComponent(password);
            $("#doc").attr("href", href).click();
        }
    });
});