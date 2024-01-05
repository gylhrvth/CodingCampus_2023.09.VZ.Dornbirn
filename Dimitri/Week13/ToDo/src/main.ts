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
    let listItem: HTMLInputElement = document.createElement("input");
    listItemElement.appendChild(listItem);
    listItem.setAttribute("value", userInput)
    listItem.setAttribute("readonly", "true")
    let doneButton: HTMLInputElement = createButton("done");
    listItemElement.appendChild(doneButton);
    let deleteButton: HTMLInputElement = createButton("delete");
    listItemElement.appendChild(deleteButton);
    let editButton = createButton("edit")
    listItemElement.appendChild(editButton)
    container?.appendChild(listItemElement);
    listItemElement.setAttribute("class", "toDoItem");

    deleteButton.addEventListener("click", () => {
        container?.removeChild(listItemElement);
    })

    doneButton.addEventListener("click", () => {
        listItem.style.textDecoration = "line-through";

        // let undoneButton = createButton('undone');
        // doneButton.replaceWith(undoneButton);
        doneButton.removeAttribute('value');
        doneButton.setAttribute('value', 'undone');
        doneButton.addEventListener("click", () => {
            listItem.style.textDecoration = 'revert';
            doneButton.removeAttribute('value');
            doneButton.setAttribute('value', 'done');
        })
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

        confirmEditButton.addEventListener("click", () => {
            let newText = listItem.value;
            listItem.removeAttribute('value');
            listItem.setAttribute("value", newText);
            listItem.setAttribute('readonly', 'true');
            makeButtonNormal(deleteButton);
            makeButtonNormal(editButton);
            makeButtonNormal(doneButton);
            listItemElement.removeChild(confirmEditButton);

        })

        listItem.addEventListener("keydown", (event) => {
            if (event.key === "Enter") {
                event.preventDefault();
                confirmEditButton.click();

            }
        })





    })
}

function makeButtonVerySmall(button: HTMLInputElement) {
    button.style.display = 'none';
    button.setAttribute('speak', 'none');
}

function makeButtonNormal(button: HTMLInputElement) {
    button.style.display = 'revert';
    button.removeAttribute('speak');
}




