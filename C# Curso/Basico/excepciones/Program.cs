//using Internal;
using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Excepciones \n");


Random numero = new Random();

int aleatorio= numero.Next(0 , 10);
int mi_numero;
int intentos=0;

Console.WriteLine("Introduce un numero entre 0 y 10");

do{
    intentos++;
    
    //excepcion intenta ejecutar

    try {

        mi_numero=int.Parse(Console.ReadLine());

    //PADRE DE LAS EXCEPCIONES
    }catch(Exception e){
        //e.Message (captura el mensaje de error y lo muestra)
        Console.WriteLine($"Por favor introduzca un Numero Valido \n {e.Message}\n");
        mi_numero=0;
    }
    
    //HIJO DE LAS EXCEPCIONES O HERENCIA
    /*catch(FormatException ex){

        Console.WriteLine("Por favor introduzca un Numero");
        mi_numero=0;
    }catch(OverflowException ex){
        Console.WriteLine("Por Favor introduzca un Numero mas pequeño entre 0 y 10");
        mi_numero=0;
    }*/

    //continua si introduce un numero

    if (mi_numero > aleatorio)
    {
        Console.WriteLine("el numero es mas bajo");
    }
     if (mi_numero < aleatorio)
    {
        Console.WriteLine("el numero es mas alto");
    }

}while (aleatorio!=mi_numero);

     {
         Console.WriteLine($"Correcto has necesitado {intentos} intentos");
     }

Console.WriteLine("continuara la prueba");



