'use strict'
var n1=prompt('INgresa una palabra','Debes de colocar algo aqui');
var n2=prompt('INgresa otra  palabra','Debes de colocar algo aqui');

function UnirPalabras(n1,n2,n3=false)
{
    if (n3==false)
     {
     console.log(n1+' '+n2);   
    }
    else
    {
        document.write(n1+' '+n2);
    }
}

UnirPalabras(n1,n2,true);