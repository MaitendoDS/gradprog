const setup = () => {
	let sliders = document.getElementsByClassName("slider");
	for (let i = 0; i < sliders.length; i++) {
		// we moeten zowel op het input als het change event reageren,
		// zie http://stackoverflow.com/questions/18544890
		sliders[i].addEventListener("change", update);
		sliders[i].addEventListener("input", update);
	}
	update();
	let saveBtn =  document.querySelector("#btn")
	saveBtn.addEventListener("click",save)

};

const update = () => {
	// haal de waarden op van de 3 sliders
	let red=document.getElementById("sldRed").value;
	let green=document.getElementById("sldGreen").value;
	let blue=document.getElementById("sldBlue").value;

	
	// stop de waarden in de 3 spans
	document.getElementById("lblRed").textContent=red;
	document.getElementById("lblGreen").textContent=green;
	document.getElementById("lblBlue").textContent=blue;
	
	// wijzig de achtergrondkleur van de swatch
	let swatch=document.getElementById("swatch");
	swatch.style.backgroundColor="rgb("+red+","+green+","+blue+")";
};

const save = () => {

	let colorPickerDiv = document.querySelector(".colorPicker")

	colorPickerDiv.insertAdjacentHTML("afterend", "<div class=\"kotje\" id=\"kotje\"><button class='btnX' data-index='' type=\"button\">X</button></div>")

	let verwBtn = document.querySelector(".btnX:last-child")
	verwBtn.addEventListener("click",verwijder)

	let red = document.getElementById("sldRed").value;
	let green = document.getElementById("sldGreen").value;
	let blue = document.getElementById("sldBlue").value;

	let kotje = document.getElementById("kotje");
	kotje.style.backgroundColor = "rgb(" + red + "," + green + "," + blue + ")";

	//VANAF HIER DEZE OEFENING

	let kleuren = {
		rood: red,
		groen: green,
		blauw: blue
	}
	let jasonString = JSON.stringify(kleuren)
	colorPickerDiv.setAttribute("data-index",jasonString)

	// TOT HIER
}
const verwijder = (event) =>  {
	const element= event.target
	event.stopPropagation()
	let p= element.parentNode
	let pp = p.parentNode
	pp.removeChild(p)
}

window.addEventListener("load", setup);