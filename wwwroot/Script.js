$(document).ready(function () {
        $(".Login-form").hide();
    $(".Login").css("background", "none");

            $(".Login").click(function () {
        $(".SignUp-form").hide();
    $(".Login-form").show();
    $(".SignUp").css("background", "none");
    $(".Login").css("background", "#fff");
});

            $(".SignUp").click(function () {
        $(".Login-form").hide();
    $(".SignUp-form").show();
    $(".Login").css("background", "none");
    $(".SignUp").css("background", "#fff");
});
});