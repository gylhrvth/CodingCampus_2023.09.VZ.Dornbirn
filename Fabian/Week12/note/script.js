var notes = document.getElementById("notes");

function submit(){
    var noteInput = document.getElementById("noteInput");
    
    if(noteInput.value != ""){
        var newElement = document.createElement("li")
        newElement.innerHTML = noteInput.value + "<button class='newButton' onclick='remove(this)'>remove</button> <br>";
        notes.appendChild(newElement);
    }
    noteInput.value = "";

    
}

function remove(button){
    notes.removeChild(button.parentNode);
}
