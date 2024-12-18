const setup = () => {
	// deze code wordt pas uitgevoerd als de pagina volledig is ingeladen
    let sliders = document.getElementsByClassName("slider")
    for (let i=0;i<sliders.length;i++) {
        sliders[i].addEventListener("change",update);
        sliders[i].addEventListener("input",update);

    }
    update()

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
}

window.addEventListener("load", setup);


// let sliderRood = document.getElementById("rood");
//     let sliderGroen = document.getElementById("groen");
//     let sliderBlauw = document.getElementById("blauw");
//     let output = document.getElementById("demo");
//     output.innerHTML = sliderRood.value; // Display the default slider value
//     output.innerHTML = sliderGroen.value;
//     output.innerHTML = sliderBlauw.value;
// // Update the current slider value (each time you drag the slider handle)
//     sliderRood.oninput = function() {
//         waardeRood.content = sliderRood.value;
//     }
//     sliderGroen.oninput = function() {
//         output.innerHTML = sliderGroen.value;
//     }
//     sliderBlauw.oninput = function() {
//         output.innerHTML = sliderBlauw.value;
//     }