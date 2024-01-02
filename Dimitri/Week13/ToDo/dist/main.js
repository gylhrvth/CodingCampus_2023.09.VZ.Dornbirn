"use strict";
function getTextFromField() {
    let input = document.getElementById("toDoInput").value;
    console.log(input);
    console.log(document.getElementById("emptyStringWarning") == null);
    if ((input == "") && (document.getElementById("emptyStringWarning") == null)) {
        let formContainer = document.getElementById("inputForm");
        let form = document.createElement("div");
        form.setAttribute("id", "emptyStringWarning");
        let warningText = document.createTextNode("Please provide an input!");
        form.appendChild(warningText);
        formContainer === null || formContainer === void 0 ? void 0 : formContainer.appendChild(form);
    }
    else if (input != "" && input != null) {
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
}
function createButton(name) {
    let inputElement = document.createElement("input");
    inputElement.setAttribute("type", "button");
    inputElement.setAttribute("value", name);
    return inputElement;
}
//# sourceMappingURL=main.js.map