/* fun */

function addElementToDocument() {

    let input: string = getTextFromInput("toDoInput");

    if ((input == "") && (document.getElementById("emptyStringWarning") == null)) {
        addErrorMessage();
    } else if (input != "" && input != null) {
        addToDoItem(input);
    }

    clearFormText("toDoInput")

}

function clearFormText(elementId: string) {
    let inputElement = document.getElementById(elementId) as HTMLInputElement;
    inputElement.value = '';
}

function createButton(name: string): HTMLInputElement {
    let inputElement: HTMLInputElement = document.createElement("input")

    inputElement.setAttribute("type", "button")
    inputElement.setAttribute("value", name)

    return inputElement
}

function getTextFromInput(elementId: string): string {
    let inputElement: HTMLInputElement = document.getElementById(elementId) as HTMLInputElement;
    let input: string = inputElement.value;
    return input;
}

function addErrorMessage() {
    let formContainer: HTMLElement | null = document.getElementById("inputForm")
    let form: HTMLDivElement = document.createElement("div")
    form.setAttribute("id", "emptyStringWarning")
    let warningText: Text = document.createTextNode("Please provide an input!")
    form.appendChild(warningText)
    formContainer?.appendChild(form)
}

function removeErrorMessage() {
    let errorMessageDiv = document.getElementById("emptyStringWarning");
    errorMessageDiv?.parentElement?.removeChild(errorMessageDiv);
}

function addToDoItem(input: string) {
    let container = document.getElementById("container");
    let div = document.createElement("div");
    let ToDoContainer: HTMLSpanElement = document.createElement("span");
    div.appendChild(ToDoContainer);
    let text: Text = document.createTextNode(input);
    ToDoContainer.appendChild(text);
    let doneButton: HTMLInputElement = createButton("done");
    div.appendChild(doneButton);
    let deleteButton: HTMLInputElement = createButton("delete");
    div.appendChild(deleteButton);
    // todo edit button
    // let editButton = createButton("edit")
    // div.appendChild(editButton)
    container?.appendChild(div);
    div.setAttribute("class", "toDoItem");
    deleteButton.addEventListener("click", () => {
        container?.removeChild(div);
    })
    doneButton.addEventListener("click", () => {
        ToDoContainer.style.textDecoration = "line-through";
    })

}




