// Ex.05 - Solicitar dois numeros e apresentar a soma 

Console.WriteLine("Digite o 1º numero: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o 2° número: ");
int num2 = int.Parse(Console.ReadLine());

Console.Clear();

Console.WriteLine("======================");
Console.WriteLine("===SOMA DE NÚMEROS====");
Console.WriteLine("======================");

Console.WriteLine($"A soma é: {num1 + num2} ");
