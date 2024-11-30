// EXPLICAÇÃO DE VARIAVEIS
var idade = 22;
console.log(idade)

var total = idade + 10
console.log(total)

total = total + 50;
console.log(total);

// EXPLICAÇÃO DE EXTRINGS
var nome = 'Programador a bordo';
console.log(nome);  /* retorna o nome */

console.log(nome.length); /* retorna o tamanho do texto */

console.log('programador'.length); /* retorna 11 */

console.log(nome.toLocaleUpperCase()); /* converte os texto em MAIUSCULO */

console.log(nome.toLowerCase()); /* converte os texto em minusculo */

console.log(nome.indexOf('dor')); /* retorna a posição do texto

console.log(nome.indexOf('teste')); /* retorna -1 se o texto nao existir */

console.log(nome.replace('Programador', 'Desenvolvedor')); /* substitui o texto */

console.log(nome.slice(3, 8)); /* corta o texto (ex: grama)*/


var canalYoutube = '    programador a bordo     ';
console.log(canalYoutube);
console.log(canalYoutube.trim()); /* remove os espaços do texto */

var autor = 'airton senna';
console.log('o canal do Youtube ' + canalYoutube.trim() + ' foi criado por ' + autor); /* concatena o texto */

console.log(`O canal do Youtube ${canalYoutube.trim()} foi criado por ${autor}`); /* concatena o texto #2*/
