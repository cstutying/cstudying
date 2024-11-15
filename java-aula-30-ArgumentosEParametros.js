/* 
Parametros: é a variável (escopo da função) que irá receber um valor em uma função
Argumentos: é o valor que é passado para a função
*/

// PASSANDO O PARAMETRO USERNAME.
function message(username) {
 console.log('Ola', username);
}

// PASSANDO O ARGUMENTOS
message('Christian');
message('Ana');

function sum(a, b) {
 console.log(a + b);
}
sum(10, 20);
sum(7, 3);

// CONSEGUI DEFININDO UM VALOR (ARGUMENTO) PADRÃO.
function joinText(text1 = '', text2 = '', text3 = '') {
 console.log(text1, text2, text3);
 //            1      2      3
}
joinText('Christian', 'Douglas', 'Dias');
//           1           2          3
joinText('Douglas', 'Christian', 'Dias'); // A ORDEM IMPORTA
//           2           1          3
joinText('Christian', 'Douglas');
//           1           2
