const setup = () => {
	// deze code wordt pas uitgevoerd als de pagina volledig is ingeladen
    let paras= document.getElementsByTagName("p");
    for (let i=0;i<paras.length;i++){
        let para = paras[i]
        para.addEventListener("click",maakOpvallend)
    }

}
const maakOpvallend = (event) => {

    let para = event.target;
    para.classList.add("opvallend")
}


window.addEventListener("load", setup);