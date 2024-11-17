// CALLBACK FUNCTION (FUNÇÃO DE CALLBACK): é uma função passada para outra função como um argumento.

function execute(taskName, callback) {
 console.log("Executando a tarefa: ", taskName);
 callback();
}

function callback() {
 console.log("Tarefa finalizada.");
}

// PASSANDO PARA A FUNÇÃO O CALLBACK
execute("Download do arquivo...", callback);

// CRIANDO A FUNÇÃO NO PRÓPRIO PARÂMETRO (FUNÇÃO ANONIMA)
execute("Upload do arquivo...", function () {
 console.log("Função de callback com uma função anonima");
});

//UTILIZANDO ARROW FUNCTION
execute("Ecluindo arquivo", () => {
 console.log("Arquivo excluido com sucesso");
});

// FORMA ENCURTADA PARA EXECUTAR APENAS UMA LINHA DE CÓDIGO
execute("Salvando Arquivo", () => console.log("Arquivo Salvo!"));
