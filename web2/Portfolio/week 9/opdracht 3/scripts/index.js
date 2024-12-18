let personen =[
    {
        voornaam: "Jan",
        familienaam: "Janssens",
        leeftijd: 29
    },
    {
        voornaam: "Mieke",
        familienaam: "Mickelson",
        leeftijd: 31
    } , {
        voornaam: "Donald",
        familienaam: "Duck",
        leeftijd: 89
    }  ,{
        voornaam: "pietje",
        familienaam: "piraatje",
        leeftijd: 54
    }
]

const setup = () => {

    let selection = document.querySelector(".person-list");

    for (let i=0;i<personen.length;i++){
        selection.insertAdjacentHTML("beforeend", "<option value='"+i+"'>" +personen[i].voornaam+ "("+personen[i].leeftijd+")"+" </option>")

    }

console.log(selection)

    selection.addEventListener("change",selected)
}

const selected =()=> {
    let selection = document.querySelector(".person-list");
    let selectedIndex = selection.selectedIndex;
    let selected = selection.options[selectedIndex]

    //let dataIndex = Number.parseInt(selected.getAttribute("data-index"),10);
    //let juistePersoon = personen[dataIndex];

    let juistePersoon = personen[selected.value]

    console.log(juistePersoon.voornaam)

    let firstName = document.querySelector(".firstname");
    let lastName = document.querySelector(".lastname");
    let age = document.querySelector(".age");

    firstName.textContent = juistePersoon.voornaam
    lastName.textContent = juistePersoon.familienaam;
    age.textContent = juistePersoon.leeftijd;
}
//let selectedOption=document.querySelector("#select option:checked");

window.addEventListener("load", setup)