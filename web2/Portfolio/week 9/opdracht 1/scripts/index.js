const setup = () => {

   let locatie1 = {};
   locatie1.straat = "Koekoekstraat 70";
   locatie1.postcode = "9090"
    locatie1.gemeente = "Melle"

    let persoon1 = {};
   persoon1.voornaam = "Jan";
   persoon1.familienaam = "Janssens";
    persoon1.adres = locatie1;

    let locatie2 = {};
    locatie2.straat = "Kerkstraat 12";
    locatie2.postcode = "8000"
    locatie2.gemeente = "Brugge"

    let persoon2 = {};
    persoon2.voornaam = "Mieke";
    persoon2.familienaam = "Mickelson";
    persoon2.adres = locatie2;

    let array = [];

    array.push(persoon1);
    array.push(persoon2)

    console.log(array)
}

window.addEventListener("load", setup);