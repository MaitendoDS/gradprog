import { useState,useEffect,createContext } from "react";
import styles from "./CounterStyle.module.css"
import NameInput from "../NameInput/NameInput";

export const CountContext = createContext()

function Counter(){
const [count,setCount] = useState(0)

const IncrementButton = () => {
    setCount(count + 1)
}
const DecrementButton = () => {
    setCount(c => c - 1) //dit is safer om te doen dan het andere... idk why and we don't wanna find out
}

const ResetButton = () => {
    setCount(0)
}

    return(
        <>
            <div className={styles.counter}>
                <p>The count = {count}</p>
                <br></br>
                <button onClick={IncrementButton}>Increment</button>
                <button onClick={DecrementButton}>Decrement</button>
                <button onClick={ResetButton}>Reset</button>
            </div>
            <CountContext.Provider value = {count}>
                <NameInput></NameInput>
            </CountContext.Provider>
        </>
    )
}

export default Counter