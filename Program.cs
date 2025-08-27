using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Calcular Desconto INSS");
        Console.WriteLine("2 - Detalhar Data");
        Console.Write("Opção: ");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                CalcularDescontoINSS();
                break;
            case 2:
                DetalharData();
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }

    public static void CalcularDescontoINSS()
    {
        Console.WriteLine("Digite seu salário: ");
        double Salario = double.Parse(Console.ReadLine());

        double Desconto = 0;
        double DescontoExibido = 0;

        if (Salario <= 1212.00)
        {
            DescontoExibido = 7.5;
            Desconto = Salario * 0.075;
        }
        else if (Salario <= 2427.35)
        {
            DescontoExibido = 9;
            Desconto = Salario * 0.09;
        }
        else if (Salario <= 3641.03)
        {
            DescontoExibido = 12;
            Desconto = Salario * 0.12;
        }
        else if (Salario <= 7087.22)
        {
            DescontoExibido = 14;
            Desconto = Salario * 0.14;
        }

        double SalarioLiquido = Salario - Desconto;

        Console.WriteLine($"Desconto aplicado: {DescontoExibido}%");
        Console.WriteLine($"Desconto do INSS: R${Desconto.ToString("F2")}");
        Console.WriteLine("Salário líquido: R$ " + SalarioLiquido.ToString("F2"));
    }

    public static void DetalharData()
    {
        Console.WriteLine("Digite uma data (ex: 27/08/2025): ");
        DateTime Dia = DateTime.Parse(Console.ReadLine());

        string diaSemana = Dia.ToString("dddd", new CultureInfo("pt-BR"));
        string Mes = Dia.ToString("MMMM", new CultureInfo("pt-BR"));

        if (Dia.DayOfWeek == DayOfWeek.Sunday)
        {
            string Hora = DateTime.Now.ToString("hh:mm:ss");
            Console.WriteLine($"Hora atual: {Hora}");
        }

        Console.WriteLine($"Dia da semana: {diaSemana}");
        Console.WriteLine($"Mês: {Mes}");
    }
}