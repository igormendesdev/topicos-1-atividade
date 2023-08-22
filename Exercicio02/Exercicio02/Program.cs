using System.Threading.Channels;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite 1 para exercio triangulo ou 2 para o do circulo");
        int op = Convert.ToInt32(Console.ReadLine());

        if(op == 1)
        {
            exercicio2();
        }
        if (op == 2)
        {
            exercicio3();
        }

       
    }

    public static void exercicio2()
    {
        Triangulo valores = new Triangulo();

        Console.WriteLine("Digite o valor de A: ");
        valores.valorA = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor de B: ");
        valores.valorB = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor de C: ");
        valores.valorC = Convert.ToDouble(Console.ReadLine());

        valores.Calculotrianculo();

       

    }

    public static void exercicio3()
    {
       Circulo valor = new Circulo();
        

        Console.WriteLine("Digite o valor do Raio: ");
        valor.raio = Convert.ToDouble(Console.ReadLine());

        valor.CalcularCirculo();

        
    }
}