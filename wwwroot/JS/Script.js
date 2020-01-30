$(document).ready(function () {
    $(".login-form").hide();
    $(".login").css("background", "transparent");

    $(".login").click(function () {
        $(".signup-form").hide();
        $(".login-form").show();
        $(".signUp").css("background", "transapent");
        $(".login").css("background", "tranparent");
    });

    $(".signup").click(function () {
        $(".login-form").hide();
        $(".signup-form").show();
        $(".login").css("background", "transparent");
        $(".signup").css("background", "transparent");
    });

    $(".notmember").click(function () {
        $(".login-form").hide();
        $(".signup-form").show();
        $(".login").css("background", "transparent");
        $(".signup").css("background", "transparent");
    });

    $(".signupcomplete").click(function () {
        $(".signup-form").hide();
        $(".login-form").show();
        $(".signUp").css("background", "transapent");
        $(".login").css("background", "tranparent");
    });
});