let allImg = document.querySelectorAll(".gridImage");


allImg.forEach(imgs => imgs.addEventListener("animationstart", onAnimationScript))
console.log('eventlistner');

function onAnimationScript() {
    console.log('animationstart');
    allImg.forEach(imgs => {
        if (this != imgs) {
            imgs.classList.add("smol");
            console.log('foreach end');
        }
    })
}


allImg.forEach(imgs => imgs.addEventListener("mouseleave", onMouseLeave));

function onMouseLeave() {

    allImg.forEach(imgs => {
        imgs.classList.remove("smol");
    })

}


