const setup = () => {

   let locaties = [{
       straat : "Koekoekstraat 70",
       postcode : "9090",
       gemeente : "Melle"
   },
       {
           straat : "Kerkstraat 12",
           postcode : "8000",
           gemeente : "Brugge"
       }];


    let personen = [{
        voornaam : "Jan",
        familienaam : "Janssens",
        adres : locaties[0]
    },{
        voornaam : "Mieke",
        familienaam : "Mickelson",
        adres : locaties[1]
    }];

}

window.addEventListener("load", setup);