const display = document.getElementById("screen");
const startFontSize = parseInt(window.getComputedStyle(display).fontSize);
var fontSize = parseInt(window.getComputedStyle(display).fontSize);

function addToScreen(value) {
    if(display.textContent == 0 && value != "." && display.textContent != "0.")
        display.textContent = value;
    else{
        display.textContent += value;
        adjustFontSize();
    }
}

function calc() {
    try{
        if(display.textContent)
        display.textContent = Number(eval(display.textContent).toFixed(6));
    }
    catch (error){
        display.textContent = 'Error';
    }
}

function clearScreen() {
    fontSize = startFontSize
    display.style.fontSize = `${fontSize}px`;
    display.textContent = 0;
}

function changeSign() {
    display.textContent = -display.textContent;
}

function adjustFontSize() {
    const minFontSize = 15; 
    if (fontSize > minFontSize) {
        fontSize -= 0.5;
        display.style.fontSize = `${fontSize}px`;
    }
}