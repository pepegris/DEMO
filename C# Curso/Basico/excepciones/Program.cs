using Internal;
using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Excepciones");


Random numero = new Random();

int aleatorio= numero.Next(0 , 10);
int mi_numero;
int intentos=0;

Console.WriteLine("Introduce un numero entre 0 y 10");

do{
    intentos++;
    mi_numero=int.Parse(Console.ReadLine());

    if (mi_numero > aleatorio)
    {
        Console.WriteLine("el numero es mas bajo");
    }
     if (mi_numero < aleatorio)
    {
        Console.WriteLine("el numero es mas alto");
    }
}

