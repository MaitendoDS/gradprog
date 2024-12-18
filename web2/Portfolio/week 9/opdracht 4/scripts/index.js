let personen =[]
const setup = () => {
	// deze code wordt pas uitgevoerd als de pagina volledig is ingeladen
    vulMetDemoData();
    toonAllePersonen();
    let bewaarKnop = document.querySelector("#submit");
    bewaarKnop.addEventListener("click",bewaarPersoon);

}
const toonPersoon = (persoon) =>{
console.log(persoon.voornaam+", "+persoon.familienaam+", "+persoon.geboortedatum.toISOString().substr(0,10)+", "+persoon.email+", "+persoon.aantalKinderen)
}
const vulMetDemoData = () =>{
   let p1 =  {
       voornaam: "Jan",
       familienaam: "Jansens",
       geboortedatum: new Date("2010-10-15"),
       email: "jan@example.com",
       aantalKinderen:0
   }
    let p2 =  {
        voornaam: "Mieke",
        familienaam: "Mickelson",
        geboortedatum: new Date("1980-01-01"),
        email: "mieke@example.com",
        aantalKinderen:1
    }
    let p3 =  {
        voornaam: "Piet",
        familienaam: "Pieters",
        geboortedatum: new Date("1970-01-31"),
        email: "piet@example.com",
        aantalKinderen:2
    }
    personen.push(p1);
    personen.push(p2);
    personen.push(p3);
}
const toonAllePersonen =()=>{
    console.clear();
    for (let i = 0; i < personen.length; i++) {
        toonPersoon(personen[i]);
    }
}
const bewaarPersoon = () =>{

    let voornaam = document.querySelector("#txtVoornaam");
    let persoonDiv = document.querySelectorAll("#persoontje input");

    let persoon = {
        voornaam: persoonDiv[0].value,
        familienaam: persoonDiv[1].value,
        geboortedatum: new Date(persoonDiv[2].value),
        email: persoonDiv[3].value,
        aantalKinderen: Number.parseInt(persoonDiv[4].value,10)
    }
    personen.push(persoon)
    toonAllePersonen()

}


window.addEventListener("load", setup);