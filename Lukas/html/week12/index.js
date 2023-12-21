console.log("Hello World")

let myLines = []

function add(x, y) {
    let sum = x + y
    return sum
}

function mult(x, y) {
    return x * y
}

const addAnonymous = (x, y) => {
    return x + y
}

function onAddClicked() {
    console.log("On add clicked")

    let rawNumber1 = document.getElementById("number1").value
    let rawNumber2 = document.getElementById("number2").value

    console.log("RawNumber1: " + rawNumber1)
    console.log("RawNumber2: " + rawNumber2)

    let number1 = parseFloat(rawNumber1)
    let number2 = parseFloat(rawNumber2)

    console.log("Number1: " + number1)
    console.log("Number2: " + number2)

    let result = add(number1, number2)

    if (isNaN(result)) {
        result = "Das ist keine ZAHL!"
    }

    document.getElementById("result").innerText = result
}

function saveLines() {
    //Convert array to json
    localStorage.setItem("myLines", JSON.stringify(myLines))
}

function loadLines() {
    let storedLines = localStorage.getItem("myLines")
    if (storedLines != null) {
        myLines = JSON.parse(storedLines)
    }
}
loadLines()

function initLines() {
    for (let line of myLines) {
        onAddLineClicked(line)
    }
}
initLines()

function onAddLineClicked(value) {
    let container = document.getElementById("lineContainer")

    let div = document.createElement("div")

    let myValue
    if (value) {
        myValue = value
    } else {
        myValue = new Date().toISOString()
        myLines.push(myValue)
        saveLines()
    }

    let text = document.createTextNode(myValue)
    let deleteButton = document.createElement("input")
    deleteButton.type = "button"
    deleteButton.value = "Delete"
    deleteButton.onclick = () => {
        myLines = myLines.filter((line) => {
            if (myValue == line) {
                return false
            } else {
                return true
            }
        })
        saveLines()
        container.removeChild(div)
    }
    div.appendChild(text)
    div.appendChild(deleteButton)

    container.appendChild(div)
}

function onResetLineClicked() {
    let answer = window.confirm("Erik möchte wissen ob sie das wirklich löschen möchten")
    if (answer) {
        let container = document.getElementById("lineContainer");
        while (container.hasChildNodes()) {
            container.removeChild(container.firstChild)
        }
        myLines = []
        saveLines()
    }
}