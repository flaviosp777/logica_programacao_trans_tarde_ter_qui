// Descrição: Crie um programa que gera a tabuada de um número escolhido pelo usuário do While

Console.WriteLine("Digite um número para ver a tabuada");
int contador = int.Parse(Console.ReadLine());

do
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador++;
}
while (contador <= 10);