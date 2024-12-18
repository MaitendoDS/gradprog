let priorities=["low","medium","high"]; // vervang null door een array met drie string waarden, resp. low, medium en high

const getTextForPriorityLevel = (level) => {
    // geef de tekst terug voor dit priority level (bv. 0 is "low" en 2 is "high")
    // (gebaseerd op het priorities array)
    return priorities[level]
};

const getPriorityLevelForText = (text) => {
    // geef het level terug voor deze priority tekst (bv. "low" is 0 en "high" is 2)
    // of -1 indien de tekst geen geldige priority tekst is.
    // (gebaseerd op het priorities array)
    console.log(priorities.indexOf(text))

};

const setup = () => {
    // Zorg ervoor dat een klik op de #btnAdd button onze 'addTask' event listener oproept
    let btnAdd = document.getElementById("btnAdd")
    btnAdd.addEventListener("click",addTask)
    // Zorg ervoor dat een klik op een .dot element onze 'filterTasks' event listener oproept
    let dots = document.getElementsByClassName("dot")

    for (let i = 0;i<dots.length;i++){
        dots[i].addEventListener("click",filterTasks)
    }

    // Voeg enkele tasks toe, om snel te kunnen testen
    // insertTaskHTML(0, "low priority");
    // insertTaskHTML(1, "medium priority");
    // insertTaskHTML(2, "high priority");
};

const addTask= () => {
    // haal de titel van de task op uit #txtDescription
    let input = document.getElementById("txtDescription")

    let description = input.value ; // geef description de juiste waarde

    // haal het priority level van de task op uit sldLevel en zet om naar een getal
    let prioriteit = document.getElementById("sldLevel")

    let level= parseInt(prioriteit.value,10); // vervang 0 door de juiste waarde

    // voeg de HTML voor de task toe
    insertTaskHTML(level, description);

    // maak titel inputveld leeg
    input.textContent="";
};

const insertTaskHTML = (level, description) => {
    // Voeg de HTML code toe aan .tasks voor deze task (level is een Number, description is een string)
    // De task krijgt ook een class volgens het priority level (.low, medium of .high)
    // Om de naam vd class te bekomen op basis van het level gebruik je getTextForPriorityLevel

    // Je hoeft hierbij geen rekening te houden met de actuele filter level!
    // (maw indien wegens de filter enkel 'high' getoond wordt en je voegt een 'low' toe, dan mag deze 'low' zichtbaar zijn)

    let levelTekst = getTextForPriorityLevel(level)
    let code = `<p class="task ${levelTekst}">${description}</p>`
    let tasks = document.getElementsByClassName("tasks")[0];

    tasks.innerHTML+=code;
};

const filterTasks = (event) => {
    // achterhaal op welk .dot element geklikt werd
    let element = event.target
    // haal de (onzichtbare) tekst op uit dit element
    let invisTekst = element.textContent
    // zet de tekst om naar een priority level (zodat je een Number hebt)
    // gebruik hiervoor getPriorityLevelForText
    let filterLevel = getTextForPriorityLevel(invisTekst); // vervang 2 door de juiste waarde

    // pas de classes aan van de .task elementen op basis van filterLevel
    adjustForFilter(filterLevel);
};

const adjustForFilter = (filterLevel) => {
    // pas de CSS classes aan van de .task elementen (filterLevel is een Number)
    let tasks = document.getElementsByClassName("task")

    for (let i = 0;i<tasks.length;i++){
        tasks[i].classList.remove("hidden")

        for (let j=0;j<filterLevel;j++){
            let juisteTekst = getTextForPriorityLevel(j)
            if (tasks[i].classList.contains(juisteTekst)){

                tasks[i].classList.add("hidden")

            }
        }
    }

    // je maakt tasks onzichtbaar door hun element de class .hidden te geven
    // om ze zichtbaar te maken, moet je gewoon de class .hidden verwijderen

    // om te weten welke task element je moet filteren (i.e. verbergen), kun je checken
    // of ze bv. de 'medium' class hebben. Je zult wellicht ook 'getTextForPriorityLevel en/of
    // getPriorityLevelForText nodig hebben.
};
window.addEventListener("load",setup)
// Zorg ervoor dat je setup functie pas wordt uitgevoerd als de DOM-tree klaar is!