
const setup = () => {
    let btnKopieer=document.getElementById("btnKopieer");
    btnKopieer.addEventListener("click", kopieer);
}

const kopieer = () => {
    let txtInput=document.getElementById("txtInput");
    let text = txtInput.textContent;
    let txtOutput=document.getElementById("txtOutput");
    txtOutput.textContent = text;
}

window.addEventListener("load", setup  );