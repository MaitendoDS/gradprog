import styles from "./NameInput.module.css";
import { useState,useContext,useEffect } from "react";
import { CountContext } from "../Counter/Counter";

function NameInput(){

    const count = useContext(CountContext)
    const [name,setName] = useState("jij");
    const [inputje,setInput] = useState("jij");

    useEffect(() => {
        document.title = `Count: ${count}`
    },[name])

    function NameChanger (event){
        if(event.target.value.trim() == "")
        {
           setName("jij")
        }
        else
        {
            setName(event.target.value);
        }
        setInput(event.target.value)
    }

    return(
        <>
             <div className={styles.input}>
                <input value={inputje} onChange={NameChanger} />
                <p>{name} stinkt</p>
             </div>
       </>
    );
}


export default NameInput