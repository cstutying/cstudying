// EXERCICIO 13

// DOMINANDO FILTER no JavaScript
// Filter (Filtrar o array)
//  -Criar um novo array filtrando os valores desejados do array Original
//  -Você tem acess a 3 dados:
//    -Item por Item do array
//    -Posição atual do Array
//    -Array Completo
//    -Resultado
//  --------------------------------------------------------------------

// FILTRAR SOMENTE OS PRODUTOS EM PROMOÇÃO
const produtos = [
 { id: 1, nome: "Smartphone Galaxy S21", preco: 3999.91, temDesconto: true, quantidade: 1, },
 { id: 2, nome: "Geladeira", preco: 2991.17, temDesconto: false, quantidade: 3, },
 { id: 3, nome: "Notebook Dell", preco: 1296.91, temDesconto: true, quantidade: 5, },
 { id: 4, nome: "Smart TV", preco: 3949.22, temDesconto: false, quantidade: 2, },
 { id: 5, nome: "Fone de Ouvido", preco: 3955.35, temDesconto: true, quantidade: 1, },
 { id: 6, nome: "TableT", preco: 3992.48, temDesconto: false, quantidade: 8, },
 { id: 7, nome: "Console PlayStation 5", preco: 1329.52, temDesconto: true, quantidade: 2, },
 { id: 8, nome: "Smartwatch", preco: 7999.81, temDesconto: false, quantidade: 7, },
 { id: 9, nome: "Impressora", preco: 3891.14, temDesconto: true, quantidade: 5, },
 { id: 10, nome: "Caixa de Som Portatil", preco: 3198.49, temDesconto: false, quantidade: 3, },
];

const promocao = produtos.filter((produto) => produto.temDesconto)

console.log(promocao)

// EX#3
// const numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
// const pares = numeros.filter(numeros => {
// return numeros % 2 === 0; /* EX - 01 */
// return numeros > 6; /* EX - 02 */

// });
// console.log(pares)
