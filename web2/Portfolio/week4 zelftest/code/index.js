let globalKleur = "white";
const setup = () => {
    // deze code wordt pas uitgevoerd als de pagina volledig is ingeladen

    const btnVoegToe = document.getElementById("btnVoegToe");
    btnVoegToe.addEventListener("click", VoegToe);

    let testZones = document.getElementsByClassName("testZone");
    for (let i=0;i<testZones.length;i++){
        let testZone = testZones[i];
        testZone.addEventListener("click",kleurTestZone);
    }
}
const VoegToe=()=>{

    let inputKleur = document.getElementById("txtKleur") ;
    let kleur = inputKleur.value;

    inputKleur.value = "";

    let secKleurZones = document.getElementById("secKleurZones");

    secKleurZones.innerHTML += "<span class='kleurZone' style='background-color:"+kleur+";'>"+kleur+"</span>";

    let kleurZones = document.getElementsByClassName("kleurZone");

    for (let i=0;i<kleurZones.length;i++){
        let kleurZone = kleurZones[i];
        kleurZone.addEventListener("click",selectKleur)
    }

    let beginInstructies = document.getElementsByClassName("secInstructiesBegin")[0];
    beginInstructies.className = "hidden";
     let vervolgInstructies = document.getElementsByClassName("secInstructiesVervolg")[0];
     vervolgInstructies.className = ""
}
const selectKleur = (event)=>{

    let selectedKleur =  event.target;
    let kleurtje = selectedKleur.style.backgroundColor;
    globalKleur = kleurtje;

}
const kleurTestZone = (event)=>{
    let clicked = event.target;
    clicked.style.backgroundColor = globalKleur;
}

window.addEventListener("load", setup);