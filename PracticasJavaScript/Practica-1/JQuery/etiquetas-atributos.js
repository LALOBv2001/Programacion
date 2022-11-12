'use strict'
$(document).ready(function (){
    //selector de etiquetas
    var span=$('span');
    span.css('border', '1px solid blue');
    //selector de atributos 
    var atributo=$('[title="Google"]');
    atributo.css('font-size','50px');
    console.log(atributo.text());
 });