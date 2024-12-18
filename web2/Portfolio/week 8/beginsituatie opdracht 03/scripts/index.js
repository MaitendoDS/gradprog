const setup = () => {
    let lis = document.querySelectorAll("#lstIngredients a")
    const btnAdd = document.querySelector("#btnAdd");
    btnAdd.addEventListener("click", add);

    for (let i=0;i<lis.length;i++){
        lis[i].addEventListener("click",remove)
    }


}
const add = () => {
    // Lees de tekst uit het textveld en voeg nieuw <li> element toe
    const ul = document.querySelector("#lstIngredients");
    const input = document.querySelector("#txtInput");
    const ingredient = input.value;

    input.value ='';
    ul.insertAdjacentHTML("beforeend", `<li>${ingredient} <a href="#">verwijder</a></li>`);
    let li = document.querySelector("#lstIngredients>li:last-child");
    li.addEventListener("click", remove)
}
const remove = (event) =>{
    const element= event.target
    let p= element.parentNode
    let pp = p.parentNode
    event.preventDefault();
    pp.removeChild(p)
}

window.addEventListener("load", setup);