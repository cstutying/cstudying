// DOM

// VISUALIZAR O CONTEÚDO DO DOCUMENT
// console.log(document);

// OBTER O TITLE DA PAGINA
console.log(document.title);

// ACESSAR O ELEMENTO PELO ID (SELETOR ID)
const guest = document.getElementById("guest-2");
console.log(guest);

// MOSTRA AS PROPRIEDADES DO OBJETOS
console.dir(guest);

// ACESSAR ELEMENTO COM CLASS (SELETOR CLASS)
const guestsByClass = document.getElementsByClassName("guest");
console.log(guestsByClass);

// EXIBIR O PRIMEIRO ELEMENTO DA LISTA
console.log(guestsByClass.item(0)); // É POSSÍVEL USAR ESSA OPÇÃO 1
console.log(guestsByClass[0]); // OU ESSA OPÇÃO 2

// SELECIONAR LISTA DE ELEMENTO PELA TAG
const guestsTag = document.getElementsByTagName("li");
console.log(guestsTag);
