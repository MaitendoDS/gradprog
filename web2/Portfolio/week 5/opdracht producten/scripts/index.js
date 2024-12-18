const setup = () => {
    // deze code wordt pas uitgevoerd als de pagina volledig is ingeladen
    let prijs = document.getElementsByClassName("prijs");
    let aantal = document.getElementsByClassName("aantal");
    let btw = document.getElementsByClassName("btw");
    let subtotaal = document.getElementsByClassName("subtotaal");

    const berekenSubtotaal = () => {
        for (let i = 0; i < prijs.length; i++) {
            let btwAlsNumber = parseFloat(btw[i].textContent);
            let prijsAlsNumber = parseFloat(prijs[i].textContent);
            let aantalAlsNumber = parseFloat(aantal[i].value);

            subtotaal[i].textContent = (prijsAlsNumber + (prijsAlsNumber * aantalAlsNumber / 100) * btwAlsNumber).toFixed(2) + " Eur";
        }
    }


    let button = document.getElementById("herberekenBtn");
    button.addEventListener("click", berekenSubtotaal);
}

window.addEventListener("load", setup);
