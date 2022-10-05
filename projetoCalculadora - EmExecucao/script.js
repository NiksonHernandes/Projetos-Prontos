var visor = document.getElementById("visor");
let dig = document.getElementsByClassName("digitos");

// for(let i = 0; i <= num.length; i++){
//     // dig[i].addEventListener("mouseover", function () {
//     //     this.style.backgroundColor = "blue";
        
//     // }); 
    
//     // dig[i].addEventListener("mouseout", function(){
//     //     this.style.backgroundColor = "#a8b9a8";
//     // });
    
//     num[i].addEventListener("click", function(){
        
//         visor.innerText = i + 1;s
        
        
//     })
// }


function mostra(n){
    if(visor.innerText === "visor"){
        visor.innerText = '' + n;
    }else{
        visor.innerText += n;
    }

}
