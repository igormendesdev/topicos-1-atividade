using System.Drawing;

public class Triangulo
{
    public double valorA;
    public double valorB;
    public double valorC;


    public void Calculotrianculo()
    {
        double p = (valorA + valorB + valorC) / 2;

        double resultado = p * (p - valorA) * (p - valorB) * (p - valorC);

        double area = Math.Sqrt(resultado);

        Console.WriteLine("O valor total da area e de: " + area);
    }


    }



