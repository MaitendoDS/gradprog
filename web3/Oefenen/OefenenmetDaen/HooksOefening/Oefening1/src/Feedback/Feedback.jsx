import { useState } from "react";
import styles from "./FeedbackStyle.module.css"

function Feedback(){

    const [countGoed,setGoed] = useState(0)
    const [countNeutraal,setNeutraal] = useState(0)
    const [countSlecht,setSlecht] = useState(0)

    const GoedButton = () => {
        setGoed(countGoed + 1)
    }
    const NeutraalButton = () => {
        setNeutraal(countNeutraal + 1)
    }
    const SlechtButton = () => {
        setSlecht(countSlecht + 1)
        
    }


    return(
        <>
        <div className={styles.feedback}>  
            <h1>geef feedback</h1>
            <button className={styles.goedBtn} onClick={GoedButton}>GOED</button>
            <button className={styles.neutraalBtn} onClick={NeutraalButton}>NEUTRAAL</button>
            <button className={styles.slechtBtn} onClick={SlechtButton}>SLECHT</button>
            <br />
            <h1>statistieken</h1>
            <p>goed: {countGoed}</p>
            <p>neutraal: {countNeutraal}</p>
            <p>slecht: {countSlecht}</p>

        </div>        
        </>
    );
}
export default Feedback