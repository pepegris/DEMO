// See https://aka.ms/new-console-template for more information
Console.WriteLine("Constructores \n");


Carro Carro1 = new Carro(); //instancear el objeto
Carro Carro2 = new Carro(1900,1); //instancear el objeto

Console.WriteLine(Carro1.getInfo());
Console.WriteLine(Carro2.getInfo());
Carro2.setExtras(true,"rosada");
Console.WriteLine(Carro2.getExtras());
Console.WriteLine(Carro1.getExtras());


class Carro
{

    public Carro() 
    {
        ruedas = 4;
        largo = 2300.5;
        ancho = 0.8;
        climatizador = false;
        tapiceria = "Tela";

    }
    public Carro(double get_largo, double get_ancho)
    {
        ruedas = 4;
        largo= get_largo;
        ancho = get_ancho;

    }

    public String getInfo()
    {
        return $"Informacion del carro: \nRuedas= {ruedas} \nLargo= {largo} \nAncho= {ancho}";
    }

    public void setExtras(bool set_climatizador,String set_tapiceria)
    {

        climatizador = set_climatizador;
        tapiceria = set_tapiceria;

    }
    public String getExtras()
    {
        return $"Extras del carro: \nClimatizador= {climatizador} \nTapiceria= {tapiceria}";
    }

    private int ruedas;
    private double largo;
    private double ancho;
    private bool climatizador;
    private String tapiceria;




}


