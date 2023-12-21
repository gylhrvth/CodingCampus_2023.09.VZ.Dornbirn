var elements = document.getElementById("elements");

function addElement(){
    var newElement = document.createElement("div");
    newElement.innerHTML = "*Clicked at " + new Date().toISOString()  + "<br> <button onclick='remove(this)'>Remove</button> <br>";
    elements.appendChild(newElement);
}
function remove(button){  
    elements.removeChild(button.parentNode);
}
function removeAll(){
    elements.innerHTML = "";
}