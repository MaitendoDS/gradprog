const setup = () => {
    let p1 = { naam : 'Jan Janssens', gemeente : 'Melle', };
    let p2 = { naam : 'Mieke Mickelson', gemeente : 'Bruhhe', };
    let personen = [];
    personen.push( p1 );
    personen.push( p2 );
    console.log( JSON.stringify( personen ) );
}

window.addEventListener("load", setup);