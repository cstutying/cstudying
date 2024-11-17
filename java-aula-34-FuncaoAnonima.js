// FUNÇÃO ANONIMA (FUNÇÃO QUE NÃO POSSUI NOME)

// EXEMPL O1
const showMessage1 = function () {
 return "Ola, Christian";
};
console.log(showMessage1());

// EXEMPL O2
const showMessage2 = function (name) {
 return "Ola, " + name;
};

console.log(showMessage2("Douglas"));

// EXEMPLO 03
const showMessage3 = function (message, name) {
 return message + name;
};
console.log(showMessage3("Ola, ", "Dias"));
