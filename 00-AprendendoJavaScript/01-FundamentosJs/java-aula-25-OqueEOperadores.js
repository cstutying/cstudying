// EXERCÍCIO 25
// oque é um OPERADORES
// 
// + SOMA
// - Subtração
// / Divisão
// * Multiplicação
// % Resto
// ** Elevado
//  --------------------------------------------------------------------
// console.log(11 ** 2)
const QUANTIDADE = 6;
function numeroImpares(valor) {
 let contar = 0
 let novoValor = valor;

 while (contar < QUANTIDADE) {
  if (novoValor % 2 !== 0) {
   console.log(novoValor)
   contar++;
  }
  novoValor++;
 }

}
numeroImpares(41);