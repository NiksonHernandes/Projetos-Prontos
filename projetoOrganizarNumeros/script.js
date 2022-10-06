let num = document.querySelector("input#fnum");
let lista = document.querySelector("select#listar");
let resultado = document.querySelector("div#res");
let valores = [];

const form = document.querySelector("form");
//alterar tema
function cinza(){
    document.body.style.backgroundColor = "gray";
}

function azul(){
    document.body.style.backgroundColor = "#70d8dc";
}

function isNumero(x) {
    if (Number(x) >= 1 && Number(x) <= 100) {
        return true;
    } else {
        return false;
    }
}

function inLista(n, l) {
    if (l.indexOf(Number(n)) != -1) {
        return true;
    } else {
        return false;
    }
}

function mostraRes(x) {
    let item = document.createElement("option");
    item.text = `Valor ${x} adicionado.`
    lista.appendChild(item);
}

function adicionar() {
    if (isNumero(num.value) && !inLista(num.value, valores)) {
        valores.push(Number(num.value));
        mostraRes(num.value);
        resultado.innerHTML = ''

    } else {
        alert("Valores inválidos ou já encontrados na lista")
    }

    num.value = ''
    num.focus();
}

function organizar() {
    if (valores.length == 0) {
        resultado.innerHTML = "<br>" + "Lista vazia! Adicione um número!"
    } else {
        valores.sort(function (a, b) { return a - b }); //ficou pra sair corretamente- pesquisar no W3Schools
        lista.innerHTML = '';
        for (let posi in valores) {
            mostraRes(valores[posi])
        }
    }
    num.focus();
}