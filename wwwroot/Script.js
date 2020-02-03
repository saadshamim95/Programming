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

    $.ajax({
        url: 'api/Employee/Add',
        type: 'POST',
        contentType: 'application/json;charset=utf-8',
        dataType: 'json',
        data: "{'Name': '" + $('#Name').val() + "','UserName': '" + $('#SignUpUserName').val() + "','Pass': '" + $('#SignUpPass').val() + "','Email': '" + $('#Email').val() + "','Mobile': '" + $('#Mobile').val() + "'}",
        success: function () {
            alert("Data Inserted successfully!!!");
        },
        error: function () {
            alert("Insert Error!!!");
        }
    });

    $(".signup-form").hide();
    $(".login-form").show();
    event.preventDefault();
    return true;
}

function validateLogin() {
    if (document.getElementById("LoginEmail").value.length < 4 || document.getElementById("LoginPass").value.length < 4) {
        document.getElementById("errorLogin").innerHTML = "Email or Password is incorrect";
        document.LoginForm.LoginPass.focus();
        return false;
    }

    $.ajax({
        url: 'api/Employee/Add',
        type: 'POST',
        contentType: 'application/json;charset=utf-8',
        dataType: 'json',
        data: "{'Email': '" + $('#LoginEmail').val() + "','Pass': '" + $('#LoginPass').val() + "'}",
        success: function () {
            alert("Login Successful!!!");
        },
        error: function () {
            alert("Login Error!!!");
        }
    });

    $(".signup-form").hide();
    $(".login-form").show();
    event.preventDefault();
    return true;
}

$(document).ready(function () {
    $(".login-form").hide();


    $(".login").click(function () {
        $(".signup-form").hide();
        $(".login-form").show();
        $("#errorSignUp").hide();
    });

    $(".signup").click(function () {
        $(".login-form").hide();
        $(".signup-form").show();
        $("errorSignUp").show();
        $(".login").reset();
    });

    $(".notmember").click(function () {
        $(".login-form").hide();
        $(".signup-form").show();
        
    });

    $("#signup-button").click(function () {
        validateSignUp();
    });

    $("#login-button").click(function () {
        validateLogin();
    });

});