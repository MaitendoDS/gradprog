const setup = () => {
    // registeer click event listener 'voegToe' bij #btnAdd
    const btnVoegToe = document.querySelector("#btnAdd");
    btnVoegToe.addEventListener("click", voegToe);

    // registreer click event listener 'wisAlles' bij #btnClear
    const btnWisAlles = document.querySelector("#btnClear");
    btnWisAlles.addEventListener("click", wisAlles);

    // registreer click event listener 'maakBelangrijk' bij elke <li> in .lstIngredients
    let lis = document.querySelectorAll("#lstIngredients>li");
    for (let i=0; 1<lis.length; i++) {
        lis[i].addEventListener("click", maakBelangrijk);
    }
}

const voegToe = () => {
    // Lees de tekst uit het textveld en voeg nieuw <li> element toe
    const ul = document.querySelector("#lstIngredients");
    const input = document.querySelector("#txtInput");
    const ingredient = input.value;

    input.value ='';

    ul.innerHTML += `<li>${ingredient}</li>`;


    let lis = document.querySelectorAll("#lstIngredients>li");
    for (let i=0; 1<lis.length; i++) {
        lis[i].addEventListener("click", maakBelangrijk);
    }
}

const wisAlles = () => {
    // Wis alle ingredienten
    // Je kunt dit doen door alle de .innerHTML van #lstIngredients een lege string in te stellen
    const lis = document.querySelectorAll("#lstIngredients>li");
    for (let i=0; 1<lis.length; i++)
    {
        lis[i].remove()
    }}


const maakBelangrijk = (event) => {
    // Geef het geklikte element de CSS class 'belangrijk'
    const element = event.target;
    element.classList.add("belangrijk");

}

window.addEventListener('load',setup);

