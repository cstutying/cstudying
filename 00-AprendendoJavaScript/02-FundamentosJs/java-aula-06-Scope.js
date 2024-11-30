// console.log (user)
// var  user = "Rodrigo"

// Hoisting
// var user
// console.log(user);

var email = 'christian@gmail.com';
{
  // Escopo de bloco.
  console.log(email);
}
{
  var age = 18;
}
console.log(age);

{
  address = 'Rua X';
  console.log(address);
}
