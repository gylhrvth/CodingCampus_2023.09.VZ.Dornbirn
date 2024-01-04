"use strict";
function addElementToDocument() {
    let input = getTextFromInput("toDoInput");
    if ((input == "") && (document.getElementById("emptyStringWarning") == null)) {
        addErrorMessage();
    }
    else if (input != "" && input != null) {
        addToDoItem(input);
    }
    clearFormText("toDoInput");
}
function clearFormText(elementId) {
    let inputElement = document.getElementById(elementId);
    inputElement.value = '';
}
function createButton(name) {
    let inputElement = document.createElement("input");
    inputElement.setAttribute("type", "button");
    inputElement.setAttribute("value", name);
    return inputElement;
}
function getTextFromInput(elementId) {
    let inputElement = document.getElementById(elementId);
    let input = inputElement.value;
    return input;
}
function addErrorMessage() {
    let formContainer = document.getElementById("inputForm");
    let form = document.createElement("div");
    form.setAttribute("id", "emptyStringWarning");
    let warningText = document.createTextNode("Please provide an input!");
    form.appendChild(warningText);
    formContainer === null || formContainer === void 0 ? void 0 : formContainer.appendChild(form);
}
function removeErrorMessage() {
    var _a;
    let errorMessageDiv = document.getElementById("emptyStringWarning");
    (_a = errorMessageDiv === null || errorMessageDiv === void 0 ? void 0 : errorMessageDiv.parentElement) === null || _a === void 0 ? void 0 : _a.removeChild(errorMessageDiv);
}
function addToDoItem(input) {
    let container = document.getElementById("container");
    let div = document.createElement("div");
    let ToDoContainer = document.createElement("span");
    div.appendChild(ToDoContainer);
    let text = document.createTextNode(input);
    ToDoContainer.appendChild(text);
    let doneButton = createButton("done");
    div.appendChild(doneButton);
    let deleteButton = createButton("delete");
    div.appendChild(deleteButton);
    container === null || container === void 0 ? void 0 : container.appendChild(div);
    div.setAttribute("class", "toDoItem");
    deleteButton.addEventListener("click", () => {
        container === null || container === void 0 ? void 0 : container.removeChild(div);
    });
    doneButton.addEventListener("click", () => {
        ToDoContainer.style.textDecoration = "line-through";
    });
}
//# sourceMappingURL=main.js.map