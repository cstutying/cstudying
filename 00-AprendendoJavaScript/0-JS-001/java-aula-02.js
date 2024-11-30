console.log(10 + 5 + 3 + 4); // Soma de +

console.log(50 - 10 - 5); // Soma de -

console.log(5 * 5); // Soma de de *

console.log(10 / 2); // Soma de de /

console.log(20 ** 10); // Soma de de **

var a = 10;
var b = 18;

console.log(a + b);

console.log(10 % 2);

console.log(10 % 3);

console.log(10 % 4);

var a = 1;
a = a + 1;
console.log(a);



let carro = {
 marca: 'VW',
 preco: 1000,
 andar: function () {
  return console.log('andou');
 }
}
let nome = 'andre';
console.log(nome.toUpperCase());
function $(nome) {
 return {
  hide() {
   console.log('Esconder o ' + nome);
  }
 }
}

$('rafael').hide();