const pictures = ["https://cdn.discordapp.com/attachments/261611273458810883/1174699014734757928/SPOILER_image.png?ex=658d74b5&is=657affb5&hm=1121d58686e501db472b12d2b28facb9f5afcb9835b3de21a66205bd61491656&",
    "https://img.freepik.com/free-photo/painting-mountain-lake-with-mountain-background_188544-9126.jpg",
    "https://www.shutterstock.com/image-photo/photo-amazed-shocked-young-woman-600nw-1928233076.jpg",
    "https://i0.wp.com/picjumbo.com/wp-content/uploads/man-looking-at-heart-shaped-explosion-free-photo.jpg?w=600&quality=80",
    "https://www.recordnet.com/gcdn/presto/2021/03/22/NRCD/9d9dd9e4-e84a-402e-ba8f-daa659e6e6c5-PhotoWord_003.JPG?crop=1999,1125,x0,y78&width=1600&height=800&format=pjpg&auto=webp",
    "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885_1280.jpg",
    "https://photo-works.net/images/europe-landscape-photo-edited.jpg",
    "https://media.discordapp.net/attachments/1161650123672133663/1184863117159698492/image.png?ex=658d84c4&is=657b0fc4&hm=4a148d65ab9d240b5bc96a2ca55c93d4ba5f13d520cd66499294d06d8534db15&=&format=webp&quality=lossless&width=583&height=406",
    "https://media.discordapp.net/attachments/1161650123672133663/1185123948996861992/chaos.png?ex=658e77af&is=657c02af&hm=bdec05ff22f4c6121e7f3c4713e029cba983885448eceffea387dc741f6c4c84&=&format=webp&quality=lossless&width=722&height=406"]

const preview = document.querySelector(".previews");
const displayed = document.querySelector(".displayed");
const gallery = document.querySelector(".gallery");
let konamiCoded = false;

pictures.forEach(picture => addToPreview(picture));
document.addEventListener("keypress", (e) => addLetter(e));
let pressedLetters = [];
const secretCode = "wwssadadba";
let flashing;

function addToPreview(picture) {
    const outerDiv = document.createElement("div");
    const pic = document.createElement("img");
    pic.src = picture;
    pic.classList.add("img");
    outerDiv.classList.add("outerDiv");
    outerDiv.appendChild(pic);

    pic.addEventListener("click", makeBig);

    preview.appendChild(outerDiv);
}

function makeBig() {
    displayed.src = this.src;
}

function addLetter(e) {
    pressedLetters.push(e.key);

    if (pressedLetters.length > secretCode.length) {
        pressedLetters.shift();
    }

    if (pressedLetters.join("") == secretCode) {
        easterEgg();
    }
}

function easterEgg() {
    if (!konamiCoded) {
        flashing = setInterval(changeColor, 50);
        konamiCoded = true;
    }
    else {
        console.log("test");
        resetGallery();
        konamiCoded = false;
    }

}

function randomNumber(max) {
    return Math.random() * max;
}

function changeColor() {
    gallery.style.border = `4vw solid rgb(${randomNumber(255)}, ${randomNumber(255)}, ${randomNumber(255)})`;
    gallery.style.transform = `rotate(${-5 + randomNumber(10)}deg)`;
    gallery.style.transition = "0.05s";
}

function resetGallery() {
    clearInterval(flashing);
    gallery.style.border = "10px solid black";
    gallery.style.transform = "rotate(0deg)";
}

