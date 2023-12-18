let numberList = new Array;
let firstNumber;
let solution;
let listCounter = 0;
let currentOperator;
let firstNumberListCounter = 0;
let numberOfInputsCounter = 0;
const displayOutput = document.querySelector('.display');
const options = ["+", "-", "*", "/", "=", "Enter"];

keyboardPressed();

function keyboardPressed() {

    document.addEventListener('keydown', function (event) {

        console.log(event.key);

        let input = event.key;
        if (event.key == "Enter") {
            input = "=";
        }

        if (!isNaN(input) || options.includes(input)) {
            GetInput(input);
        }
    })
}

function GetInput(dataInput) {
    readInput(dataInput);

    if (dataInput != '*' && dataInput != '-' && dataInput != '+' && dataInput != '/' && dataInput != '=') {
        AddDataToList(dataInput);
    }
    else if (firstNumber == null) {
        currentOperator = dataInput;
        firstNumber = numberList.join("");
        console.log(firstNumber);
        numberList = [];
        listCounter = 0;
    }
    else {
        firstNumber = Number(firstNumber);
        const secondNumber = Number(numberList.join(""));

        solution = resultOf(firstNumber, currentOperator, secondNumber);
        firstNumber = solution;
        currentOperator = dataInput;
        listCounter = 0;
        numberList = [];
        console.log(solution);
    }

}


function resultOf(first, operator, second) {
    switch (operator) {
        case '+': return first + second;
        case '-': return first - second;
        case '*': return first * second;
        case '/': return first / second;
    }

    alert("Error at resultOf!");
}


function AddDataToList(dataInput) {

    if (numberList.length >= 20) {

        alert('To much numbers')
    }
    else {
        numberList[listCounter] = dataInput;
        listCounter++;
        console.log(numberList);
        numberOfInputsCounter++;
    }

}


function readInput(dataInput) {

    if (!isNaN(dataInput)) {
        displayOutput.textContent += dataInput;
        displayOutput.textContent = displayOutput.textContent.replace(currentOperator, "");
    }
    else if (dataInput == '*' || dataInput == '-' || dataInput == '+' || dataInput == '/') {
        displayOutput.textContent = dataInput;
    }
    else if (numberOfInputsCounter > 1 && dataInput == '=') {
        displayOutput.textContent = resultOf(Number(firstNumber), currentOperator, Number(numberList.join("")));
    }
    else {
        displayOutput.textContent = "Error!"
    }

}