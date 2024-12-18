const setup = () => {
	// deze code wordt pas uitgevoerd als de pagina volledig is ingeladen
    let elementNode= document.getElementById("divje");
    elementNode.addEventListener("click", MaakRood)
}
const MaakRood = () => {
    let elementNode= document.getElementById("divje");
    elementNode.style.backgroundColor="red";
}

window.addEventListener("load", setup);