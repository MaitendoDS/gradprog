const setup = () => {


let stop=false
    let inputGemeenten= [];

while (!stop){
        let userInput = window.prompt("Voer een gemeente in (of 'stop' om te stoppen):");
        stop = userInput === "stop" || userInput === null;

    if (!stop){
        inputGemeenten.push(userInput);
    }
}
    inputGemeenten.sort();


let selGemeenten = document.querySelector("#selGemeenten");
    for (let i = 0;i<inputGemeenten.length;i++) {

        selGemeenten.insertAdjacentHTML("beforeend", `<option>${inputGemeenten[i]}</option>`)
    }
}

window.addEventListener("load", setup);