const setup = () => {
	let generateButton = document.getElementById("generateButton");
	generateButton.addEventListener("click", addTable);
}
const addTable= () =>{

	let input = document.getElementById("numberInput");
	let getal = parseInt(input.value, 10)


	if(Number.isNaN(getal)){
		window.alert("Geen geldig getal");
	} else {

		htmlTable(getal)
	}


	input.value = "";
};

const htmlTable = (getal) => {
	let tablesContainer = document.getElementById("tables-container");
	let tafels="";

	for (let i=1;i<=10;i++) {
		let product = i * getal;
		let lijntje=`<p>${i} x ${getal} = ${product}</p>`;
		tafels+=lijntje;
	}

	let htmlLijntje=`<div class="tafel"><h1 class="titel">Tafel van ${getal}</h1>${tafels}</div>`;

	tablesContainer.innerHTML+=htmlLijntje;
};


window.addEventListener("load", setup);
