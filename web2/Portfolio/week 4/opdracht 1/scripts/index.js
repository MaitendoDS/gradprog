const setup = () => {
	// deze code wordt pas uitgevoerd als de pagina volledig is ingeladen
    let elementNode= document.getElementById("divje");
    elementNode.addEventListener("click", ZegKlik)
}
const ZegKlik = () => {console.log("Klik")}

window.addEventListener("load", setup);