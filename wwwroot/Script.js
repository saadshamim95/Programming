function validateSignUp() {
    if (document.getElementById("Name").value.length < 3) {
        document.getElementById("errorSignUp").innerHTML = "Name should be atleast 3 letter";
        document.SignUpForm.Name.focus();
        return false;
    }

    if (document.getElementById("SignUpUserName").value.length < 4) {
        document.getElementById("errorSignUp").innerHTML = "Username should be atleast 4 letter";
        document.SignUpForm.SignUpUserName.focus();
        return false;
    }

    if (document.getElementById("SignUpPass").value.length < 4) {
        document.getElementById("errorSignUp").innerHTML = "Password should be atleast 4 letter";
        document.SignUpForm.SignUpPass.focus();
        return false;
    }

    if (document.getElementById("SignUpPass").value != document.getElementById("RetypePass").value) {
        document.getElementById("errorSignUp").innerHTML = "Password doesn't match!!!";
        document.SignUpForm.RetypePass.focus();
        return false;
    }

    if (document.getElementById("Email").value.length < 4) {
        document.getElementById("errorSignUp").innerHTML = "Type correct Email ID";
        document.SignUpForm.Email.focus();
        return false;
    }

    if (document.getElementById("Mobile").value.length != 10) {
        document.getElementById("errorSignUp").innerHTML = "Incorrect Mobile Number";
        document.SignUpForm.Mobile.focus();
        return false;
    }

    return true;
}

function validateLogin() {
    if (document.getElementById("LoginUserName").value.length < 4 || document.getElementById("LoginPass").value.length < 4) {
        document.getElementById("errorLogin").innerHTML = "Username or Password is incorrect";
        document.LoginForm.LoginPass.focus();
        return false;
    }

    return true;
}

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