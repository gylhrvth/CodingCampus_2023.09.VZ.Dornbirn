var counter = document.getElementById("counter");

var storedCounter = localStorage.getItem("clickCounter");
if (storedCounter) {
    counter.textContent = storedCounter;
}

function count() {
    counter.textContent = parseInt(counter.textContent) + 1;
    localStorage.setItem("clickCounter", counter.textContent);

}
