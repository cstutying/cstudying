// EXERCÍCIO 24
// EXERCÍCIO
// 
//  --------------------------------------------------------------------
const CONSUMO_VEICULO = 12;

function gastoCombustivel(tempoGasto, velocidadeMedia) {
 const distancia = velocidadeMedia * tempoGasto;
 const consumoFinal = distancia / CONSUMO_VEICULO;
 return consumoFinal.toFixed(3);
}

console.log(gastoCombustivel(10, 85));
console.log(gastoCombustivel(2, 92));
console.log(gastoCombustivel(22, 67));