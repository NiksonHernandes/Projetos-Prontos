var visor = document.getElementById("visor");
let dig = document.getElementsByClassName("digitos");

for(let i = 0; i < dig.length; i++){
    // dig[i].addEventListener("mouseover", function () {
    //     this.style.backgroundColor = "blue";
        
    // }); 
    
    // dig[i].addEventListener("mouseout", function(){
    //     this.style.backgroundColor = "#a8b9a8";
    // });
    
    dig[i].addEventListener("click", function(){
        visor.innerText = i + 1;
    })
}



