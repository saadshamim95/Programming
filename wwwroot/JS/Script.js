$(document).ready(function () {
    $(".login-form").hide();

    $(".login").click(function () {
        $(".signup-form").hide();
        $(".login-form").show();        
    });

    $(".signup").click(function () {
        $(".login-form").hide();
        $(".signup-form").show();        
    });

    $(".notmember").click(function () {
        $(".login-form").hide();
        $(".signup-form").show();        
    });

    $(".signupcomplete").click(function () {
        $(".signup-form").hide();
        $(".login-form").show();        
    });
});