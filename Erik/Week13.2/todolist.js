// function inputLengthCheck() {
//     let userInput = document.getElementById("userInput")
//     console.log(userInput.value.length)
//     if (userInput.value.length <= 30) {
//     }
//     else {
//         window.alert("Too many inputs")
//     }
// }


let element = document.getElementById("TodoTasks")a


function addInput() {
    let userInput = document.getElementById("userInput")
    printInput(userInput.value);
    userInput.value = null;
}


function printInput(userInput) {
    if (userInput.length < 1) {
        window.alert("Message too short!")
        return
    }
    else {

        let li = document.createElement("li")
        li.textContent = userInput

        element.appendChild(li)
        console.log(li)

    }


}

function removeAll() {

    element.textContent = "";
}
