document.getElementById("showImage").onclick = function () {
    var x = document.getElementById("myCV");
    console.log(">>>" + x.style.display + "<<<")

    if (!x.style.display || x.style.display === "none") {
        x.style.display = "block";
    } else {
        x.style.display = "none";
    }
}

document.getElementById("showsexy").onclick = function () {
    var x = document.getElementById("sexy");
    console.log(">>>" + x.style.display + "<<<")

    if (!x.style.display || x.style.display === "none") {
        x.style.display = "block";
    } else {
        x.style.display = "none";
    }
}


