function submitTipp(){
    if(document.getElementById("tippEmailInput").value != "" && document.getElementById("tippInput").value != ""){
        alert("succesfully sended your tipp!")    
    }
    else{
        alert("please fill out all necessary fields!")
    }
}