/* 
FALSY quando um valor é considerado falso (false)
TRUTHY quando um valor é considerado verdadeiro (true) em conterxtos onde um boolean é obrigatório (condicionais e loops).
*/

console.log('### EXEMPLOS CONSIDERADOS FALSY (FALSE) ###');
console.log(false ? 'VERDADEIRO ' : 'FALSO');
console.log(0 ? 'VERDADEIRO ' : 'FALSO');
console.log(-0 ? 'VERDADEIRO ' : 'FALSO');
console.log('' ? 'VERDADEIRO ' : 'FALSO');
console.log(null ? 'VERDADEIRO ' : 'FALSO');
console.log(undefined ? 'VERDADEIRO ' : 'FALSO');
console.log(NaN ? 'VERDADEIRO ' : 'FALSO');

console.log('### EXEMPLOS CONSIDERADOS TRUTHY (TRUE) ###');
console.log(true ? 'VERDADEIRO' : 'FALSO');
console.log({} ? 'VERDADEIRO' : 'FALSO');
console.log([] ? 'VERDADEIRO' : 'FALSO');
console.log(1 ? 'VERDADEIRO' : 'FALSO');
console.log(3.23 ? 'VERDADEIRO' : 'FALSO');
console.log('0' ? 'VERDADEIRO' : 'FALSO');
console.log(' ' ? 'VERDADEIRO' : 'FALSO');
console.log('Christian' ? 'VERDADEIRO' : 'FALSO');
console.log('false' ? 'VERDADEIRO' : 'FALSO');
console.log('-1' ? 'VERDADEIRO' : 'FALSO');
console.log(Infinity ? 'VERDADEIRO' : 'FALSO');
console.log(-Infinity ? 'VERDADEIRO' : 'FALSO');
