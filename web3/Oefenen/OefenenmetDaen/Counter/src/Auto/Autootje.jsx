import { useState } from "react";
import styles from "./Autootje.module.css"

function Autootje(){
const [car, setCar] = useState (
    {
        year:2024,
        make:"Ford",
        model:"Mustang"
    }
)

function handleYearChange(event){

    setCar(c => ({...c, year: event.target.value})) //die ...c is eig car ma dan heel het object met die anderes dingetjes bij
}
function handleMakeChange(event){
    setCar(c => ({...c, make: event.target.value}))
}
function handleModelChange(event){
    setCar(c => ({...c, model: event.target.value}))
}



return(

    <>

<div className={styles.autootje}>
    <p>Your fav car is: {car.year} {car.make} {car.model} </p>


<input type="number" value={car.year} onChange={handleYearChange} />
<input type="text" value={car.make} onChange={handleMakeChange} />
<input type="text" value={car.model} onChange={handleModelChange} />

</div>
    </>

)

}

export default Autootje;