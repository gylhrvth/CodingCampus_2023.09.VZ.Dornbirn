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
    else if (!(input == "")) {
        let container = document.getElementById("container");
        let div = document.createElement("div");
        let text = document.createTextNode(input);
        div.appendChild(text);
        container === null || container === void 0 ? void 0 : container.appendChild(div);
    }
}
//# sourceMappingURL=main.js.map