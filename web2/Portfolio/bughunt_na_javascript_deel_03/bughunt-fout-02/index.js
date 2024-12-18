
const setup = () => {
    let btnKopieer=document.getElementsByClassName("btnKopieer");[0]
    btnKopieer.addEventListener("click", kopieer);
}

const kopieer = () => {
    let txtInput=document.getElementById("txtInput");
    let text = txtInput.value;
    let txtOutput=document.getElementById("txtOutput");
    txtOutput.textContent = text;
}

window.addEventListener("load", setup  );