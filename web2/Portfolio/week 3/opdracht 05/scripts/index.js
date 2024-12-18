const setup = () => {


    let btnWijzig=document.getElementById("btnWijzig");
    btnWijzig.addEventListener("click", wijzigen);
}

const wijzigen = () => {
    let pElement=document.getElementById("txtOutput");
    pElement.textContent="Welkom!";}

window.addEventListener("load", setup);