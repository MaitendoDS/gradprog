const setup = () => {
  let lis = document.querySelectorAll("#lstIngredients>li")
  for (let i=0;i<lis.length;i++){
    lis[i].addEventListener("click",remove)
  }


}
const remove = (event) =>{
    const element= event.target
  let p= element.parentNode
  let pp = p.parentNode
  pp.removeChild(p)
}

window.addEventListener("load", setup);