document.addEventListener('DOMContentLoaded', function () {

    const resultElement = document.querySelector('.result span');
    const buttonsContainer = document.querySelector('.buttons');

    let currentInput = ''; 
    let lastOperator = ''; 

  
    function updateDisplay() {
        resultElement.textContent = currentInput || '0';
    }

    function ButtonClick(event) {
        const buttonValue = event.target.textContent;
        console.log("buttonvalue =" + buttonValue)

        switch (buttonValue) {
            case 'AC':
                currentInput = '';
                lastOperator = '';
                break;
            case '+/-':
                currentInput = (parseFloat(currentInput) * -1).toString();
                break;
            case '%':
                currentInput = (parseFloat(currentInput) / 100).toString();
                break;
            case '=':
                currentInput = calculateResult();
                lastOperator = '';
                break;
            case '+':
            case '-':
            case 'x':
            case '/':
                Operator(buttonValue);
                break;
            default:
                Number(buttonValue);
                break;
        }

        updateDisplay(); 
    }


    function Number(value) {
        if (currentInput === '0') {
            currentInput = value;
        } else {
            currentInput += value;
            if(currentInput.includes(",")){
                currentInput = currentInput.replace("," , ".")
            }

            console.log("currentinput "+currentInput)
        }
    }

    
    function Operator(operator) {
        if (lastOperator && currentInput) {
            currentInput = calculateResult();
        }

        lastOperator = operator;
        currentInput += ' ' + operator + ' ';
    }

    
    function calculateResult() {
        const expression = currentInput.replace(/x/g, '*'); 
        try {
            return eval(expression).toString();
        } catch (error) {
            return 'Error';
        }
    }

    
    buttonsContainer.addEventListener('click', function (event) {
        if (event.target.tagName === 'BUTTON') {
            ButtonClick(event);
        }
    });
});