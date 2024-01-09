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

function addToDoItem(userInput: string) {
    let container = document.getElementById("toDoContainer");
    let listItemElement = document.createElement("li");

    let listItem = document.createElement("input");
    listItem.setAttribute("value", userInput)
    listItem.setAttribute("readonly", "true")
    listItemElement.setAttribute("class", "toDoItem");
    listItemElement.appendChild(listItem);
    addButtonsAndEventlisteners(container, listItemElement, listItem);
    container?.appendChild(listItemElement);
}

function makeButtonVerySmall(button: HTMLInputElement) {
    button.style.display = 'none';
    button.setAttribute('speak', 'none');
}

function makeButtonNormal(button: HTMLInputElement) {
    button.style.display = 'revert';
    button.removeAttribute('speak');
}

function addButtonsAndEventlisteners(container: HTMLElement | null, listItemElement: HTMLElement, listItem: HTMLInputElement) {
    let doneButton = createButton("done");
    let deleteButton = createButton("delete");
    let editButton = createButton("edit");

    //append buttons to list item element
    listItemElement.appendChild(doneButton);
    listItemElement.appendChild(deleteButton);
    listItemElement.appendChild(editButton)

    deleteButton.addEventListener("click", () => {
        container?.removeChild(listItemElement);
    })

    doneButton.addEventListener("click", () => {

        if (doneButton.value === "done") {
            listItem.style.textDecoration = "line-through";
            doneButton.removeAttribute('value');
            doneButton.setAttribute('value', 'undone');
        } else if (doneButton.value === "undone") {
            listItem.style.textDecoration = 'revert';
            doneButton.removeAttribute('value');
            doneButton.setAttribute('value', 'done');
        }
    })

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

        })

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
        })
    })
}