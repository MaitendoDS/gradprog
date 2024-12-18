
const setup = () => {
    let btnKopieer=document.getElementById("btnKopieer");
    btnKopieer.addEventListener("click", kopieer);
}

const Kopieer = () => {
    let txtInput=document.getElementById("txtInput");
    let text = txtInput.value;
    let txtOutput=document.getElementById("txtOutput");
    txtOutput.textContent = text;
}

window.addEventListener("load", setup  );