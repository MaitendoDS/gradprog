const setup = () => {
let btn = document.querySelector("#btn")
    btn.addEventListener("click",toonResultaat)
}


const toonResultaat= () => {
    let isRoker = document.querySelector("#checkbox")
    if (isRoker.checked === true) {
        console.log("is roker")
    } else {
        console.log("is geen roker")
    }

    let moedertaal = document.querySelector("input[name='moedertaal']:checked")
    console.log("moedertaal is " + moedertaal.value)

    let buurland = document.querySelector("#buurland")
    console.log("favoriete buurland is "+ buurland.value)

    let selectedOptions = document.querySelectorAll("#bestelling option:checked");
    let bestellingen = [];
    selectedOptions.forEach(option => {
        bestellingen.push(option.value);
    });
    console.log("Bestelling bestaat uit " + bestellingen);

}


window.addEventListener("load", setup);