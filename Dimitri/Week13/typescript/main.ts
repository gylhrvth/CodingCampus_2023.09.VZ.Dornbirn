try {
    let paragraphs = document.querySelectorAll("p");
    console.log(paragraphs.length);
    let newParagraph = document.createElement("p");
    let newParagraphText = document.createTextNode("new");
    newParagraph.appendChild(newParagraphText);
    document.body.appendChild(newParagraph);
    newParagraph.style.background = "red";
    console.log(paragraphs.length);
} catch (se) {
    console.error(se);
}


