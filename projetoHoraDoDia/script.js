function carregar(){
    var msg = document.getElementById("mensagem");
    var img = document.getElementById("foto");
    var data = new Date();
    var hora = data.getHours();
    var minutos = data.getMinutes();
    
    msg.innerHTML = `Agora são ${hora}h e ${minutos}min.`
    hora = 20;
    if(hora >= 0 && hora < 12){
        //bom dia;
        img.src = "imagem-manha.png"
        document.body.style.backgroundColor = "#e2cd9f"
        

    }else if(hora >= 12 && hora <= 18){
        img.innerHTML = '<img src = "imagens/imagem-tarde.png" alt="Foto Tarde" title="Foto Tarde" height="280" width="280">';
        document.body.style.backgroundColor = "#b9846f"

    }else{
        img.innerHTML = '<img src = "imagens/imagem-noite.png" alt="Foto noite" title="Foto Noite" height="280" width="280">';
        document.body.style.backgroundColor = "#515154"
       
    }
}

