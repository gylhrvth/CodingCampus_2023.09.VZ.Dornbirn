
function onClick() {

    let Type = GetOption();
    console.log(Type)

    let NameInput = prompt('Say the Name of the Item')
    console.log(NameInput);

    let Value = prompt('Say the Value of the Item')
    console.log(Value);

    let Amount = prompt('Say the Amount of the Item')
    console.log(Amount);

    let newItem = document.createElement("tr");
    
    let TypeChild = document.createElement("td");
    TypeChild.style = GetColor(Type);
    TypeChild.textContent = Type;
    
    let NameChild = document.createElement("td")
    NameChild.style="color:#3a4e9e";
    NameChild.textContent = NameInput;
    

    let ValueChild = document.createElement("td")
    ValueChild.style="color:#3a4e9e";
    ValueChild.textContent = Value;

    let AmountChild = document.createElement("td")
    AmountChild.style="color:#3a4e9e";
    AmountChild.textContent = Amount;


    let DeleteButton = document.createElement("td");
    

    
   

    let button = document.createElement("button");
    button.style.fontSize = "13.33px";
    button.style.width = "60px"
    button.style.height = "20px"
    button.style.borderRadius = "10pc"
    button.style.fontFamily = 'Franklin Gothic Medium', 'Arial Narrow';

    button.textContent = "REMOVE"
    button.setAttribute("id","DeleteButton")
    button.addEventListener("click", DeleteBut)

    DeleteButton.appendChild(button);

    newItem.appendChild(TypeChild);
    newItem.appendChild(NameChild);
    newItem.appendChild(ValueChild);
    newItem.appendChild(AmountChild);
    newItem.appendChild(DeleteButton);

    let HtmlTable = document.querySelector("#tableId");
    HtmlTable.appendChild(newItem);
}

function DeleteBut(){

    this.parentElement.parentElement.remove();
    let button = document.getElementById("#DeleteButton")
}

function GetOption(){
    selectElement = document.querySelector('#rarityselector');

    output = selectElement.options[selectElement.selectedIndex].value;

    return output;
    
}

function GetColor(TypeColor) {
    if(TypeColor == "Godly") {
        return "color:magenta";
    } else if(TypeColor == "Rare") {
        return "color:green";
    } else if(TypeColor == "Golden") {
        return "color:gold";
    } else if(TypeColor == "Winter/Godly") {
        return "color:dodgerblue";
    } else if(TypeColor == "Legendary") {
        return "color:red";
    }
}

function ChangeDarkmodeColor() 
{
    var elememnt = document.body
     elememnt.classList.toggle("darkmode")
}