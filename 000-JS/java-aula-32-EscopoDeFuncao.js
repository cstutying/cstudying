showMessage('Olá, Christian');

function showMessage(message) {
 console.log(message);
 endLine();
 function endLine() {
  console.log('-------------');
 }
}

showMessage('Tudo Bem');

// NAO EXISTE NESSE ESCOPO A FUNÇÃO.
// endLine();
