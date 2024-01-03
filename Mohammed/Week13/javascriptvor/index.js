let x = 18;

console.log(x == 18);//true
console.log(x !=18);//false

let sureName = "Mohammed";

console.log(sureName == "David");
console.log(sureName !="David");

//array

var names = ["Mohammed", "ali", "David"];
console.log(names);
names.push("Patrick");
console.log(names);

//
var numbers =[1,2,4,5];
numbers.splice(2,0,3);
console.log(numbers);

//

var names = ["a", "b", "d"];
names.splice(2,0,"C");
console.log(names);

//

var numbers=[1,2,3,4,5,6];
var numbers2 = [7,8,9,10,11];

var newArray= numbers.concat(numbers2);
console.log(newArray);
//concat function hat ruckgabewert 


//Array löschen
var numbers = [1,2,3,4,5,5,6,7,8];
//numbers.pop(); letze element löschen
//numbers.shift(); erste element löschen
numbers.splice(4,1);//aussuchen welche element löschen möchtest
console.log(numbers)

//array finden
//da kann ich wissen, ob den element gibts.
var numbers =[3,5,3,7,5,3,2];

var result = numbers.find(Element => Element == 3);
console.log(result);

var names1 =["David", "Ali", "Patrick", "David", "Mohammed", "Mohammed",""]
var result = names1.indexOf("Patrick")
names1.splice(result,1);
console.log(result)

var numbers = [4,2,5,4,3,6,5,7,8]

var result = numbers.lastIndexOf(2)
console.log(result)

//Array Sort
var names = ["Mohammed", "Ali", "Ahmad", "Patrick", "David"]
names.sort()
console.log(names)

//Array reverse umdrehen 
var names = ["Mohammed", "Ali", "Ahmad", "Patrick", "David"]
names.reverse()
console.log(names);

//Objects
var human = {
    name: "Mohammed",
    heiht: "180",
    age:28,
    country: "A",
    children:[
        {name:"Doha", age:17},
        {name:"Amal", age:60},
        {name: "Miri", age:29}
    ]
}
console.log(human.children[1].age)
console.log(human)
//--------------------------------
human.age = 30;//value ändern
console.log(human.age)

// If Statements
/*
var age =prompt("Trage deine alte ein:");

if(age > 18) {
    console.log("Er darf rein kommen!")
}
else {
    console.log("Er darf nicht rein kommen")
}
*/
//------------------------------------

function main (){
    var input = document.getElementById("inputColor")
    var color = input.value;
    var toLowerName =color.toLowerCase();
    // wenn grün -> fahren
    if (toLowerName =="grün"){
        alert("Du dafrst fahren");
    }else if(toLowerName == "orange"){
        alert("Du musst bremsen oder anfahren");
    }else if(toLowerName == "rot"){
        alert("Du musst halten");
    }else{
        alert("Keine gültige Ampel-Farbe eingetragen");
    }
}
//wenn orange -> anfahren/bremsen
//wenn rot -> halten
// Fehlermeldung zurpckgeben bei falscher Farbe

