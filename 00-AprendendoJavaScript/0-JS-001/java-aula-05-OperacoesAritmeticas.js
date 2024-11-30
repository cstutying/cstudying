// EXERCICIO 5
// Página 45 do livro lógica de programação e Algoritmos com JavaScript de Edécio Iepsen
// Elaborar um programa para uma loja, o qual leia o preço de um produto e informe as opções de pagamento da loja.
// Calcule e infome o valor para pagamento á vista com 10% de desconto e o valor em 3x.
// EXEMPLO:
// Preço: R$60,00
// Á vista: R$60,00
// Ou 3x de: R$20,00
// ---------------------------------------------------------------------------

let preco = 100;
let aVista = 10;
let totalAVista = 0;

totalAVista = (preco - (aVista / 100) * preco);

console.log(`Preço: R$${preco},00`);
console.log(`Á vista: R$${totalAVista},00`);
console.log(`Ou 3x de: R$${preco / 3},00`);
