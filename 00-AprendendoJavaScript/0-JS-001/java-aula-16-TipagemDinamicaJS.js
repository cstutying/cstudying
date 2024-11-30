// EXERCÍCIO 16
// Tipagem Dinâmica
//  --------------------------------------------------------------------

// let pessoa = {
//  nome: 'Rafael',
//  idade: '245',
//  estaAprovado: 'true',
//  sobrenome: 'de souza',
// };
// console.log(pessoa);

// Arrays
// let familia = [26, 25, 24, 23];
// console.log(familia.length);
// console.log(familia[0]);

// Funções / verbo + substantivo
// let corSite = "azul";
// function resetCor(cor, tonalidade) {
//  corSite = cor + " " + tonalidade;
// };
// console.log(corSite);
// resetCor("verde", "claro");
// console.log(corSite);


// Tipos de Funções 
function dizerNome() {
 console.log('Douglas');
}

/* Realizar uma tarefa, não devolve nada */
dizerNome();

/* Faz um calculo ou operação e retorna Algo */
function multiplicarPorDois(valor) {
 return valor * 2;
}
/* console.log(multiplicarPorDois(5)); */
let resultado = multiplicarPorDois(5);
console.log(resultado);