<?php

class Coche
{
    public $ruedas;
    public $color;
    public $marca;
    public $estado;

    function __construct($dato1,$dato2)
    {
        $this->ruedas=4; 
        $this->color=$dato1;
        $this->marca=$dato2;
        $this->estado=false;

        
    } 

    function info()
    {
        if ($this->estado==true) {
            return "datos del carro $this->ruedas, $this->color, $this->marca, encendido <br> ";
        }else {
            return "datos del carro $this->ruedas, $this->color, $this->marca, apagado <br> ";
        }
    }

    function encender()
    {
        $this->estado=true;
        return "arrancando el carro <br>";
    }
    function apagar()
    {
        $this->estado=false;
        return "apagando el carro <br>";
    }
    function acelerar()
    {
        return "acelerando el carro <br>";
    }
    function frenar()
    {
        return "frenando el carro <br>";
    }

    

}

$toyota= new Coche('azul','toyota');

echo $toyota->info();
echo $toyota->encender();
echo $toyota->info();

