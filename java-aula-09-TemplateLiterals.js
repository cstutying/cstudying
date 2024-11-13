// Template literals (template string, interpolação de string)
let username = 'Christian';
let gmail = 'douglas@gmail.com';

// PASSAR MAIS DE UM PARÂMETRO
console.log(username, gmail, 'Teste');

//CONCATENAR TEXTO (NÃO É´AM ELHOR VERSAO A SER USADA)
let message = 'Ola, ' + username + '. voce conectou com o G-mail ' + gmail;
console.log(message);

// TEMPLATE LITERALS (MELHOR VERSAO A SER USADA)
console.log(`Ola, ${username}, Voce conectou com o G-mail ${gmail}`);
