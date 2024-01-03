/* fun */

function addElementToDocument() {

    let input: string = getTextFromInput("toDoInput");

    if ((input == "") && (document.getElementById("emptyStringWarning") == null)) {
        addErrorMessage();
    } else if (input != "" && input != null) {
        addToDoItem(input);
    }
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

function addToDoItem(input: string) {
    let container: HTMLElement | null = document.getElementById("container")
    let div: HTMLDivElement = document.createElement("div")
    let ToDoContainer: HTMLSpanElement = document.createElement("span")
    div.appendChild(ToDoContainer)
    let text: Text = document.createTextNode(input);
    ToDoContainer.appendChild(text);
    let doneButton: HTMLInputElement = createButton("done");
    div.appendChild(doneButton);
    let deleteButton: HTMLInputElement = createButton("delete");
    div.appendChild(deleteButton);
    container?.appendChild(div);
}

function removeToDo() {
    let toDoItem: HTMLDivElement = document.getElementById("toDoItem") as HTMLDivElement;
    toDoItem.parentNode?.removeChild(toDoItem)
}




