// Ex.06 - Calcular que recebe 2 numeros e apresentar + - /

using System;

Console.WriteLine("Digite o 1º numero: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o 2° número: ");
int num2 = int.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine("+ : " + (num1 + num2));
Console.WriteLine("- : " + (num1 - num2));
Console.WriteLine("* : " + (num1 * num2));

if (num2 != 0)
{

    Console.WriteLine("/ : " + (num1 / num2));

}
else
{
    Console.WriteLine("/ : DIVISÃO POR ZERO NÃO É PERMITIDA");
}

Console.WriteLine("======================");
Console.WriteLine("Os números são iguais? " + (num1 == num2));
Console.WriteLine("Número 1 é maior que o Número 2?" + (num1 > num2));
Console.WriteLine("Número 1 é menor que o Número 2?" + (num1 < num2));
Console.WriteLine("Número 1 é maior igaul que o Número 2?" + (num1 >= num2));
Console.WriteLine("Número 1 é maior que o Número 2?" + (num1 <= num2));
