try {
    var paragraphs = document.querySelectorAll("p");
    console.log(paragraphs.length);
    var newParagraph = document.createElement("p");
    var newParagraphText = document.createTextNode("new");
    newParagraph.appendChild(newParagraphText);
    document.body.appendChild(newParagraph);
    newParagraph.style.background = "red";
    console.log(paragraphs.length);
}
catch (se) {
    console.error(se);
}
