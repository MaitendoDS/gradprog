const setup = () => {
	// deze code wordt pas uitgevoerd als de pagina volledig is ingeladen
    let sliders = document.getElementsByClassName("slider")
    for (let i=0;i<sliders.length;i++) {
        sliders[i].addEventListener("change",update);
        sliders[i].addEventListener("input",update);

    }
    update()
localStorage.getItem("kleuren");

}
const update = () => {
    let sliderRood= document.getElementById("rood").value;
    let sliderGroen= document.getElementById("groen").value;
    let sliderBlauw= document.getElementById("blauw").value;

    document.getElementById("waardeRood").textContent=sliderRood;
    document.getElementById("waardeGroen").textContent=sliderGroen;
    document.getElementById("waardeBlauw").textContent=sliderBlauw;

    let swatch= document.getElementById("swatch")
    swatch.style.backgroundColor="rgb("+sliderRood+","+sliderGroen+","+sliderBlauw+")"



    let jsonstring = JSON.stringify(kleuren)
    localStorage.setItem("kleuren",jsonstring);

    // kijk nr oplossing
}

window.addEventListener("load", setup);

