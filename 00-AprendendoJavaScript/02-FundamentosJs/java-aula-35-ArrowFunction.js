// ARROW FUNCTION (FUNÇÃO DE SETA)
const showMessage1 = () => {
 console.log("Ola");
};
console.log(showMessage1);
showMessage1();

const showMessage2 = (username, email) => {
 console.log("Ola,", username, ". Seu Email é", email); //EXEMPLO 01
 console.log(`Ola, ${username}. Seu email é: ${email}.`); //EXEMPLO 02
};

showMessage2("Douglas", "login@gmail.com");
