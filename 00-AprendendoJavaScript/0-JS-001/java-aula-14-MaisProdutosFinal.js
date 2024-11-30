// EXERCÍCIO 14
// Adicionar + 10 em cada produto
// Filtrar só os em promoção
// Saber qual é o faturamento se vendermos totos em promoção
//  --------------------------------------------------------------------

// ADICIONAR MAIS 10 PRODUTOS EM PROMOÇÃO E CALCULAR FATURAMENTO TOTAL SE VENDERMOS OS PRODUTOS EM PROMOÇÃO
const produtos = [
  {
    id: 1,
    nome: 'Smartphone Galaxy S21',
    preco: 3999.91,
    temDesconto: true,
    quantidade: 1,
  },
  {
    id: 2,
    nome: 'Geladeira',
    preco: 2991.17,
    temDesconto: false,
    quantidade: 3,
  },
  {
    id: 3,
    nome: 'Notebook Dell',
    preco: 1296.91,
    temDesconto: true,
    quantidade: 5,
  },
  {
    id: 4,
    nome: 'Smart TV',
    preco: 3949.22,
    temDesconto: false,
    quantidade: 2,
  },
  {
    id: 5,
    nome: 'Fone de Ouvido',
    preco: 3955.35,
    temDesconto: true,
    quantidade: 1,
  },
  { id: 6, nome: 'TableT', preco: 3992.48, temDesconto: false, quantidade: 8 },
  {
    id: 7,
    nome: 'Console PlayStation 5',
    preco: 1329.52,
    temDesconto: true,
    quantidade: 2,
  },
  {
    id: 8,
    nome: 'Smartwatch',
    preco: 7999.81,
    temDesconto: false,
    quantidade: 7,
  },
  {
    id: 9,
    nome: 'Impressora',
    preco: 3891.14,
    temDesconto: true,
    quantidade: 5,
  },
  {
    id: 10,
    nome: 'Caixa de Som Portatil',
    preco: 3198.49,
    temDesconto: false,
    quantidade: 3,
  },
];

const faturamentoTotal = produtos
  .map((produto) => {
    return { ...produto, quantidade: produto.quantidade + 10 };
  })
  .filter((produto) => produto.temDesconto)
  .reduce(
    (acumulador, produto) => acumulador + produto.quantidade * produto.preco,
    0
  );

console.log(
  faturamentoTotal.toLocaleString('pt-br', {
    style: 'currency',
    currency: 'BRL',
  })
);
