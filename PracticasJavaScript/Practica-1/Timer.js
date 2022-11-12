'use strict'

if(typeof (storage))
{
 console.log('Disponible');
}
else 
{
 console.log('No disponible ');
}
localStorage.setItem('Clave ','texto o valor ');
localStorage.setItem('Edad ','37');

var valor = localStorage.getItem('Clave');
console.log(valor);