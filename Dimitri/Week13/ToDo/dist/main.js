"use strict";
function addElementToDocument() {
    let input = getTextFromInput("toDoInput");
    if ((input == "") && (document.getElementById("emptyStringWarning") == null)) {
        addErrorMessage();
    }
    else if (input != "" && input != null) {
        addToDoItem(input);
    }
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
}
function removeToDo() {
    var _a;
    let toDoItem = document.getElementById("toDoItem");
    (_a = toDoItem.parentNode) === null || _a === void 0 ? void 0 : _a.removeChild(toDoItem);
}
//# sourceMappingURL=main.js.map