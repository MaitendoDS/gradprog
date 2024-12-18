const setup = () => {
    const btnWijzig = document.querySelector("#btnWijzig");
    btnWijzig.addEventListener("click", Wijzig);
}

const Wijzig = () => {

    const input = document.querySelector("#txtInput");
    const image = document.querySelector("#image")
    image.setAttribute("src",input.value)
}

window.addEventListener('load',setup);