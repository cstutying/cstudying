// EXERCÍCIO 28
// oque é um STRING#2
//
//  --------------------------------------------------------------------
const mensagem = 'lOwer';
const mensagem2 = 'mensagem2';

console.log('Tamanho', mensagem.length);
console.log('Concat', mensagem.concat(mensagem2));
console.log('Concat +', 'Escreva algo' + '' + mensagem + '' + mensagem2);
console.log('ES:', `1231211 ${mensagem} ${mensagem2}`);
console.log('Quebrar em array', mensagem.split(' '));

console.log('UP:', mensagem.toLocaleUpperCase());
console.log('DOWN:', mensagem.toLocaleLowerCase());
console.log('Replace:', mensagem.replace('nuv', 'JULIO'));
