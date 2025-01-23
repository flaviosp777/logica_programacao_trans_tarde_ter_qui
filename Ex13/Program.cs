// Descrição : Crie um programa que gera a tabuada de um número escolhido pelo usuário.
//for

using System.Runtime.CompilerServices;

Console.WriteLine("Digite um número para ver a tabuada");
int numero = int.Parse(Console.ReadLine());

for (int contador = 1; contador <=10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");

}
