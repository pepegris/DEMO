// See https://aka.ms/new-console-template for more information
Console.WriteLine("PROGRAMACION ORIENTADA A OBJETO \n");


Circulo miCirculo; // creacion de objeto tipo circulo, variable/objeto

miCirculo=new Circulo(); // instaciar una clase de variable objetio tipo ciruclo

Console.WriteLine("introduce el valor para calcular el area del CIRCULO1");
int numero=int.Parse(Console.ReadLine());
Console.WriteLine($"el area del circulo es {miCirculo.area(numero)}");

// segunda intancia
Circulo miCirculo2=new Circulo();

Console.WriteLine("introduce el valor para calcular el area CIRCULO2");
int numero2=int.Parse(Console.ReadLine());
Console.WriteLine($"el area del circulo es {miCirculo2.area(numero2)}");

class Circulo
{
    // propiedad de cla clase circulo. Campo de clase
    const double pi=3.1416;

    //metodo de la clase para calcular el area
    public double area(int radio)
    {
        return pi * radio * radio;
    }
    
}

