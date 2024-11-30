// EXERCICIO 7 HACKERANK
// Página 47 do livro lógica de programação e Algoritmos com JavaScript de Edécio Iepsen
// Elaborar um programa que leia um vetor de 6 elementos inteiros e mostre-os na ordem inversa.
// EXEMPLO:
// Vetor: 1 2 3 4 5 6
// ---------------------------------------------------------------------------

function simpleArraySum(ar) {
 let soma = 0;
 for (let index = 0; index < ar.length; index += 1) {
  soma = soma + ar[index];
 }
 return soma;
};

console.log(simpleArraySum([1, 2, 3, 10]));