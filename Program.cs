using System;

namespace Calculadora
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();

      Console.WriteLine("Escolha uma das operações matemática: ");
      Console.WriteLine("1 = Soma.");
      Console.WriteLine("2 - Substração.");
      Console.WriteLine("3 - Multiplicação.");
      Console.WriteLine("4 - Divisão.");
      Console.WriteLine("5 - Sair.");

      int escolha = Convert.ToInt32(Console.ReadLine());

      switch (escolha)
      {
        case 1:
          Soma();
          break;

        case 2:
          Subtracao();
          break;

        case 3:
          Multiplicacao();
          break;

        case 4:
          Divisao();
          break;

        case 5:
          Console.WriteLine("\nAté mais...\n");
          System.Environment.Exit(0);
          break;

        default:
          Menu();
          break;
      }
    }
    static void Soma()
    {
      Console.Clear();
      Console.WriteLine("Digite o primeiro valor:");
      double primeiroValor = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Digite o segundo valor:");
      double segundoValor = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine($"\nO Resultado da soma é: {primeiroValor + segundoValor}");

      Console.WriteLine("\nAperte Enter para continuar!");
      Console.ReadKey();
      Menu();
    }

    static void Subtracao()
    {
      Console.Clear();
      Console.WriteLine("Digite o primeiro valor:");
      double primeiroValor = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Digite o segundo valor:");
      double segundoValor = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine($"\nO Resultado da subtração é: {primeiroValor - segundoValor}");

      Console.WriteLine("Aperte Enter para continuar!");
      Console.ReadKey();
      Menu();
    }

    static void Multiplicacao()
    {
      Console.Clear();
      Console.WriteLine("Digite o primeiro valor:");
      double primeiroValor = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Digite o segundo valor:");
      double segundoValor = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine($"\nO Resultado da multiplicação é: {primeiroValor * segundoValor}");

      Console.WriteLine("Aperte Enter para continuar!");
      Console.ReadKey();
      Menu();
    }

    static void Divisao()
    {
      Console.Clear();
      Console.WriteLine("Digite o primeiro valor:");
      double primeiroValor = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Digite o segundo valor:");
      double segundoValor = Convert.ToDouble(Console.ReadLine());

      if (segundoValor == 0)
      {
        Console.WriteLine("\nNão existe divisão por 0");
      }
      else
      {
        Console.WriteLine($"\nO Resultado da divisão é: {primeiroValor / segundoValor}");

        Console.WriteLine("Aperte Enter para continuar!");
        Console.ReadKey();
        Menu();
      }
    }
  }
}
