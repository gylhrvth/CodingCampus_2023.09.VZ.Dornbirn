const nickname = document.getElementById("nicknameInput");


nickname.addEventListener("change", () => checkLength(this, 0, 10));


function checkLength(reference, min, max) {
    console.log(this);
    if (!reference.classList.includes("wrongInput") && (reference.value.length < min || reference.value.length > max)) {
        reference.classList.add("wrongInput");
    }
    else if (reference.classList.includes("wrongInput")) {
        this.classList.remove("wrongInput");
    }
}