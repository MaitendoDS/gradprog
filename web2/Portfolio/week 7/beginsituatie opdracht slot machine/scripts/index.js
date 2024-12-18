// een globale variabele met de urls van alle afbeeldingen
const urls = ["images/fruit01.jpg", "images/fruit02.jpg", "images/fruit03.jpg", "images/fruit04.jpg", "images/fruit05.jpg"];

const setup = () => {

    const spinBtn = document.querySelector(".buttonLink");
    spinBtn.addEventListener("click", randomImgs);

}

const zelfdeFoto = () => {

    const slots = document.querySelectorAll('.slots img');
    let urls=[];

    urls[0] = slots[0].getAttribute("src");
    urls[1] = slots[1].getAttribute("src");
    urls[2] = slots[2].getAttribute("src");

    let tekstje= document.querySelector('.tekst');


    if (urls[0] === urls[1] && urls[0]===urls[2]){
        tekstje.textContent="hoera!! gewonnen"
    }else  {
     tekstje.textContent="jammer, probeer opnieuw >:)"
    }

}

const randomImgs = () => {

    const slots = document.querySelectorAll('.slots img');
    for (let i = 0; i < slots.length; i++) {
        let randomGetal = Math.floor(Math.random() * urls.length);
        slots[i].setAttribute("src",urls[randomGetal]);
    }

zelfdeFoto()
}

window.addEventListener("load", setup);
