const setup = () => {
	// deze code wordt pas uitgevoerd als de pagina volledig is ingeladen
	

	let button = document.getElementById("goBtn")
	button.addEventListener("click",ToonTafels)

}
const ToonTafels =() =>{
	let input = document.getElementById("inputBox");
	let inputAlsNumber = parseFloat(input.value);

	let titel = document.getElementById("titel");
	titel.textContent ="Tafels van "+ inputAlsNumber;
	
	
	
	let maal1= document.getElementById("maal1")
	maal1.textContent=inputAlsNumber+" x "+"1 ="+ inputAlsNumber*1;

	let maal2= document.getElementById("maal2")
	maal2.textContent=inputAlsNumber+" x "+"2 ="+ inputAlsNumber*2;

	let maal3= document.getElementById("maal3")
	maal3.textContent=inputAlsNumber+" x "+"3 ="+ inputAlsNumber*3;

	let maal4= document.getElementById("maal4")
	maal4.textContent=inputAlsNumber+" x "+"4 ="+ inputAlsNumber*4;

	let maal5= document.getElementById("maal5")
	maal5.textContent=inputAlsNumber+" x "+"5 ="+ inputAlsNumber*5;

	let maal6= document.getElementById("maal6")
	maal6.textContent=inputAlsNumber+" x "+"6 ="+ inputAlsNumber*6;

	let maal7= document.getElementById("maal7")
	maal7.textContent=inputAlsNumber+" x "+"7 ="+ inputAlsNumber*7;

	let maal8= document.getElementById("maal8")
	maal8.textContent=inputAlsNumber+" x "+"8 ="+ inputAlsNumber*8;

	let maal9= document.getElementById("maal9")
	maal9.textContent=inputAlsNumber+" x "+"9 ="+ inputAlsNumber*9;

	let maal10= document.getElementById("maal10")
	maal10.textContent=inputAlsNumber+" x "+"10 ="+ inputAlsNumber*10;




	clearInput()
}
const clearInput=()=>{

	let input = document.getElementById("inputBox");
	input.value="";
}

window.addEventListener("load", setup);