const setup = () => {
	// deze code wordt pas uitgevoerd als de pagina volledig is ingeladen
    let elementNode= document.getElementById("divje");
    elementNode.addEventListener("click", ZegKlik);
    elementNode.addEventListener("mouseenter", ZegEnter);
    elementNode.addEventListener("mousemove", ZegMove);
    elementNode.addEventListener("mouseleave", ZegLeave);
}
const ZegKlik = () => {console.log("Klik")}
const ZegEnter = () => {console.log("enter")}
const ZegMove = () => {console.log("move")}
const ZegLeave = () => {console.log("leave")}

window.addEventListener("load", setup);