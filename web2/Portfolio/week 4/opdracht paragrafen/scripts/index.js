const setup = () => {
	// deze code wordt pas uitgevoerd als de pagina volledig is ingeladen
    let para= document.getElementsByClassName("belangrijk");
    for (let i=0;i<para.length;i++){
        para[i].classList.add("opvallend")
    }
}


window.addEventListener("load", setup);