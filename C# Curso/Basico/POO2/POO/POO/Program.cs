
// See https://aka.ms/new-console-template for more information
Console.WriteLine("PROGRAMACION ORIENTADA A OBJETO \n");


Circulo miCirculo; // creacion de objeto tipo circulo, variable/objeto

miCirculo = new Circulo(); // instaciar una clase de variable objetio tipo ciruclo

Console.WriteLine("introduce el valor para calcular el area del CIRCULO1");
int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"el area del circulo es {miCirculo.area(numero)}");

// segunda intancia
Circulo miCirculo2 = new Circulo();

Console.WriteLine("introduce el valor para calcular el area CIRCULO2");
int numero2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"el area del circulo es {miCirculo2.area(numero2)}");


//calculando el dinero en bolivares a dolares
var conversor = new ConversonBs_Dolar();
Console.WriteLine($"Ingresar si quiere cambiar Bolivares(BS) o Dolares(DOL)");
string billete_ingresar =Console.ReadLine();
Console.WriteLine($"Ingresar la cantidad");
double dinero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Total a resivir {conversor.Convierte(dinero, billete_ingresar)}");



class Circulo
{


    // propiedad de cla clase circulo. Campo de clase
    private const double pi = 3.1416;

    //metodo de la clase para calcular el area
    public double area(int radio)
    {
        return pi * radio * radio;
    }

}



class ConversonBs_Dolar
{
    double dolar = 5;
    

    public double Convierte(double cantidad, string billete)
    {
        if (billete.ToLower() == "dol")
            return dolar * cantidad ;
        if (billete.ToLower() == "bs")
            return cantidad / dolar;
        else
            return 0;
    }

}