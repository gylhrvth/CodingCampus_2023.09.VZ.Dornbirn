/* fun */

function getTextFromField(): void {
    let input: string = (<HTMLInputElement>document.getElementById("toDoInput")).value

    // input = document.getElementById("toDoInput") as HTMLInputElement | null

    // let inputValue = input?.value

    console.log(input)

    console.log(document.getElementById("emptyStringWarning") == null)

    if ((input == "") && (document.getElementById("emptyStringWarning") == null)) {
        let formContainer: HTMLElement | null = document.getElementById("inputForm")
        let form: HTMLDivElement = document.createElement("div")
        form.setAttribute("id", "emptyStringWarning")
        let warningText: Text = document.createTextNode("Please provide an input!")
        form.appendChild(warningText)
        formContainer?.appendChild(form)
    } else if (!(input == "")) {

        let container: HTMLElement | null = document.getElementById("container")

        let div: HTMLDivElement = document.createElement("div")

        let ToDoContainer: HTMLParagraphElement = document.createElement("p")

        div.appendChild(ToDoContainer)

        let text: Text = document.createTextNode(input)

        ToDoContainer.appendChild(text)

        container?.appendChild(div)

    }
}

