

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora de IMC (Índice de Massa Corporal)");

        // Solicitar ao usuário que insira o peso em quilogramas
        Console.Write("Digite o seu peso (em quilogramas): ");
        double peso = Convert.ToDouble(Console.ReadLine());

        // Solicitar ao usuário que insira a altura em metros
        Console.Write("Digite a sua altura (em metros): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        // Calcular o IMC
        double imc = peso / (altura * altura);

        // Exibir o resultado
        Console.WriteLine($"Seu IMC é: {imc:F2}");

        // Interpretar o resultado
        if (imc < 18.5)
        {
            Console.WriteLine("Você está abaixo do peso.");
        }
        else if (imc >= 18.5 && imc < 24.9)
        {
            Console.WriteLine("Você está com peso normal.");
        }
        else if (imc >= 25 && imc < 29.9)
        {
            Console.WriteLine("Você está com sobrepeso.");
        }
        else
        {
            Console.WriteLine("Você está com obesidade.");
        }
    }
}


