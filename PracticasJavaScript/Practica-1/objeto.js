'use strict'

function Persona(edad,altura,peso) {
    this.edad=edad;
    this.altura=altura;
    this.peso=peso;
    this.caminar=()=>{
        console.log('esta persona de '+edad+' anios camina')
    }
    this.sentarse=()=>{
        console.log('se acaba de sentar');
    }
}
var Manuel=new Persona(20,1.83,80);
console.log(Manuel.caminar());