import styles from './Mensjes.module.css'
import PropTypes from 'prop-types'

function Mensjes(props){
    const clickhandler =(name) => {
        switch (name) {
            case "Irk":
                console.log("Don't drop that");
                break;
                case "Aitme":
                    console.log("Tihi");
                break;
                case "MrDien":
                    console.log("O");
                break;
                case "Josim":
                    console.log("Euhm jongens");
                break;
                case "Dommy":
                    console.log("Obviously");
                break;
            
        }
    }
    return(
        <ul>
            <li className={styles.Mensjes}>
            <p>Name: {props.name}</p>
            <p>Leeftijd: {props.leeftijd}</p>
            <img onClick={() => clickhandler(props.name)} src={props.linkje}/>
        </li>
        </ul>
        
    )

}
Mensjes.propTypes = {
    name: PropTypes.string,
    leeftijd: PropTypes.number,
    linkje: PropTypes.string,
} 
export default Mensjes