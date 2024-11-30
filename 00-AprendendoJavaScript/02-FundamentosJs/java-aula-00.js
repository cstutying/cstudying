// OPERARADORES

// Aritméticos: retornam o resultado de uma operação
//  +  SOMAR
//  -  SUBTRAIR
//  *  MULTIPLICAR
//  /  DIVIDIR
//  %  RESTO DE DIVISÃO

// Comparadores matemãticos: teste lógico, retorno booleano (true / false):
//  <  menor que
//  >  maior que
//  <=  menor ou igual
//  >=  maior ou igual

// Comparadores Logicos: teste logico, retorno booleano (true / faslse):
//  ==  igualdade entre sentenças (valor)
//  !=  diferebnca entre sentenças (valor)
//  === igualdade entre sentenças (valor e tipo)
//  !== diferenca entre sentenças (valor e tipo)

// Operadores da lógica e junção l[ogica
// !  NÃO(NOT)
// &&  E (END)
// || OU (OR)

// As condições logicas são convertidas em numeros binarios:
// true é equivalente a 1
// false é equivalente a 0

function calcularMedia(notas) {
  let soma = 0;
  for (c = 0; c < notas.length; c++) {
    soma += notas[c];
  }
  media = soma / notas.length;
  return media;
}

let media; // escopo global
function aprovacao(notas) {
  let media = calcularMedia(notas); // escopo da função
  let condicao = media >= 8 ? 'aprovado' : 'reprovado';
  return 'Média:' + media + ' - Resultado: ' + condicao;
}

//  Função Recursivas
function contagemRegressiva(numero) {
  console.log(numero);
  let proximoNumero = numero - 1;
  if (proximoNumero > 0) contagemRegressiva(proximoNumero);
}

// contagemRegressiva (50);
document.addEventListener('submit', function (evento) {
  evento.preventDefault();
  evento.stopPropagation();
  let formulario = document.getElementById('formulario-01');
  let dados = new FormData(formulario);
  let objeto = {};
  let notas = [];
  for (let key of dados.keys()) {
    objeto[key] = dados.get(key);

    // adicionar itens no array
    notas.push(parseInt(dados.get(key)));
  }
  console.log(notas);
  console.log(objeto);
  document.getElementById('resultado').innerHTML = aprovacao(notas);
  aprovacao(notas);
});
