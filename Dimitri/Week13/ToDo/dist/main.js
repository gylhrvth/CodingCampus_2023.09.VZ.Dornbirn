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
    let form = document.createElement("p");
    form.setAttribute("id", "emptyStringWarning");
    form.setAttribute("class", "warning");
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
    listItem.setAttribute("value", userInput);
    listItem.setAttribute("readonly", "true");
    listItemElement.setAttribute("class", "toDoItem");
    listItemElement.appendChild(listItem);
    addButtonsAndEventlisteners(container, listItemElement, listItem);
    container === null || container === void 0 ? void 0 : container.appendChild(listItemElement);
}
function makeButtonVerySmall(button) {
    button.style.display = 'none';
    button.setAttribute('speak', 'none');
}
function makeButtonNormal(button) {
    button.style.display = 'revert';
    button.removeAttribute('speak');
}
function addButtonsAndEventlisteners(container, listItemElement, listItem) {
    let doneButton = createButton("done");
    let deleteButton = createButton("delete");
    let editButton = createButton("edit");
    listItemElement.appendChild(doneButton);
    listItemElement.appendChild(deleteButton);
    listItemElement.appendChild(editButton);
    deleteButton.addEventListener("click", () => {
        container === null || container === void 0 ? void 0 : container.removeChild(listItemElement);
    });
    doneButton.addEventListener("click", () => {
        if (doneButton.value === "done") {
            listItem.style.textDecoration = "line-through";
            doneButton.removeAttribute('value');
            doneButton.setAttribute('value', 'undone');
        }
        else if (doneButton.value === "undone") {
            listItem.style.textDecoration = 'revert';
            doneButton.removeAttribute('value');
            doneButton.setAttribute('value', 'done');
        }
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
        let currentText = listItem.value;
        confirmEditButton.addEventListener("click", () => {
            let newText = listItem.value;
            listItem.removeAttribute('value');
            listItem.setAttribute("value", newText);
            listItem.setAttribute('readonly', 'true');
            makeButtonNormal(deleteButton);
            makeButtonNormal(editButton);
            makeButtonNormal(doneButton);
            listItemElement.removeChild(confirmEditButton);
            currentText = listItem.value;
        });
        listItem.addEventListener("keydown", (event) => {
            if (event.key === "Enter") {
                event.preventDefault();
                confirmEditButton.click();
            }
            if (event.key === "Escape") {
                listItem.value = currentText;
                listItem.setAttribute('readonly', 'true');
                makeButtonNormal(deleteButton);
                makeButtonNormal(editButton);
                makeButtonNormal(doneButton);
                listItemElement.removeChild(confirmEditButton);
            }
        });
    });
}
//# sourceMappingURL=main.js.map