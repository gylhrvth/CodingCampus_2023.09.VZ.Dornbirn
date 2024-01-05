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
function addToDoItem(userInput) {
    let container = document.getElementById("toDoContainer");
    let listItemElement = document.createElement("li");
    let listItem = document.createElement("input");
    listItemElement.appendChild(listItem);
    listItem.setAttribute("value", userInput);
    listItem.setAttribute("readonly", "true");
    let doneButton = createButton("done");
    listItemElement.appendChild(doneButton);
    let deleteButton = createButton("delete");
    listItemElement.appendChild(deleteButton);
    let editButton = createButton("edit");
    listItemElement.appendChild(editButton);
    container === null || container === void 0 ? void 0 : container.appendChild(listItemElement);
    listItemElement.setAttribute("class", "toDoItem");
    deleteButton.addEventListener("click", () => {
        container === null || container === void 0 ? void 0 : container.removeChild(listItemElement);
    });
    doneButton.addEventListener("click", () => {
        listItem.style.textDecoration = "line-through";
        doneButton.removeAttribute('value');
        doneButton.setAttribute('value', 'undone');
        doneButton.addEventListener("click", () => {
            listItem.style.textDecoration = 'revert';
            doneButton.removeAttribute('value');
            doneButton.setAttribute('value', 'done');
        });
    });
    editButton.addEventListener("click", () => {
        makeButtonVerySmall(deleteButton);
        makeButtonVerySmall(editButton);
        makeButtonVerySmall(doneButton);
        let confirmEditButton = createButton("confirm");
        listItemElement.appendChild(confirmEditButton);
        confirmEditButton.setAttribute("id", "newEditField");
        listItem.removeAttribute('readonly');
        const end = listItem.value.length;
        listItem.setSelectionRange(end, end);
        listItem.focus();
        confirmEditButton.addEventListener("click", () => {
            let newText = listItem.value;
            listItem.removeAttribute('value');
            listItem.setAttribute("value", newText);
            listItem.setAttribute('readonly', 'true');
            makeButtonNormal(deleteButton);
            makeButtonNormal(editButton);
            makeButtonNormal(doneButton);
            listItemElement.removeChild(confirmEditButton);
        });
        listItem.addEventListener("keydown", (event) => {
            if (event.key === "Enter") {
                event.preventDefault();
                confirmEditButton.click();
            }
        });
    });
}
function makeButtonVerySmall(button) {
    button.style.display = 'none';
    button.setAttribute('speak', 'none');
}
function makeButtonNormal(button) {
    button.style.display = 'revert';
    button.removeAttribute('speak');
}
//# sourceMappingURL=main.js.map