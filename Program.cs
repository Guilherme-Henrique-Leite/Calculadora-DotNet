using System;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    public static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Menu");
        Console.WriteLine("1- Para soma");
        Console.WriteLine("2- Para subtração");
        Console.WriteLine("3- Para divisão");
        Console.WriteLine("4- Para multiplicação");
        Console.WriteLine("0- Para sair");

        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Somar();
                break;
            case "2":
                Subtrair();
                break;
            case "3":
                Dividir();
                break;
            case "4":
                Multiplicar();
                break;
            case "0":
                break;
            default:
                Menu();
                break;
        }
    }

    public static void Somar()
    {
        double valorsoma1, valorsoma2;

        Console.WriteLine("Insira o primeiro valor para somar:");
        valorsoma1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira o segundo valor para somar:");
        valorsoma2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"O valor da soma é: {valorsoma1 + valorsoma2}");
        Console.ReadLine();
        Console.WriteLine("Pressione Enter para voltar ao Menu");
        Console.ReadLine();
        Menu();
    }
    public static void Subtrair()
    {
        double valorsubtrair1, valorsubtrair2;

        Console.WriteLine("Insira o primeiro valor para subtrair:");
        valorsubtrair1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira o segundo valor para subtrair:");
        valorsubtrair2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"O valor da subtração é: {valorsubtrair1 - valorsubtrair2}");
        Console.ReadLine();
        Console.WriteLine("Pressione Enter para voltar ao Menu");
        Console.ReadLine();
        Menu();
    }
    public static void Dividir()
    {
        double valordivisao1, valordivisao2;

        Console.WriteLine("Insira o primeiro valor para dividir:");
        valordivisao1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira o segundo valor para dividir:");
        valordivisao2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"O valor da divisão é: {valordivisao1 / valordivisao2}");
        Console.ReadLine();
        Console.WriteLine("Pressione Enter para voltar ao Menu");
        Console.ReadLine();
        Menu();
    }
    public static void Multiplicar()
    {
        double valorMultiplicacao1, valorMultiplicacao2;

        Console.WriteLine("Insira o primeiro valor para multiplicar:");
        valorMultiplicacao1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira o segundo valor para multiplicar:");
        valorMultiplicacao2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"O valor da multiplicação é: {valorMultiplicacao1 * valorMultiplicacao2}");
        Console.ReadLine();
        Console.WriteLine("Pressione Enter para voltar ao Menu");
        Console.ReadLine();
        Menu();
    }
    



}
