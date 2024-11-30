// EXERCICIO 11

// DOMINANDO ARRAYS no JavaScript
// Map (Mapear item por item do Array)
// - Criar um novo array com a mesma quantidade de itens do array original.
// - O novo array você pode alterar o que quiser em relação ao array original.
// - Você tem acesso a 3 dados:
//    -Item por Item do array
//    -Posiçãõ atual do rray
//    -Array Completo
//  --------------------------------------------------------------------

// CRIADO UM NOVO ARRAY FORMANDO A MOEDA E DANDO DESCONTO AOS CLIENTES
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

const novosProdutos = produtos.map(produto => {
 const novoPreco = produto.temDesconto ? produto.preco * 0.9 : produto.preco
 // Ternario = IF/ Else            ? = if / : else

 return {
  id: produto.id,
  nome: produto.nome,
  preco: novoPreco.toLocaleString('pt-br', {
   style: 'currency', currency: 'BRL'
  }),
  quantidade: produto.quantidade
 }

});
console.log(novosProdutos);






// EX#1
// const numeros = [1, 2, 3, 4, 5,]
// const dobro = numeros.map((numero, index, arrayCompleto) => {
// return numero * 4;
// console.log(arrayCompleto)
// })
// console.log(dobro);