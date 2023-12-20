const passwordInput = document.getElementById("password");
const usernameInput = document.getElementById("username")
var username = "Fabii137";
var password = "password";

function login(){
    if(usernameInput.value == username && passwordInput.value == password){
        alert("Nice! u are logged in")
    }
    else{
        alert("Password or username is wrong!")
    }
}