// EXEMPLO #1
/* 
try {
 // TENTA EXECUTAR ALGO.
 console.log(result);
} catch (error) {
 // CAPTURA O ERRO PARA TRATAR.
 console.log(
  'Não foi possivel executar o seu pedido. Tente novamente mais tarde!'
 ); 
 console.log(error);
} finally {
 console.log('Fim');
}
*/

// EXEMPLO #2
let result = 0;

try {
 if (result === 0) {
  throw new Error("O Valor é igual a zero.");
 }
} catch (error) {
 console.log(error);
} finally {
 console.log("Fim");
}
