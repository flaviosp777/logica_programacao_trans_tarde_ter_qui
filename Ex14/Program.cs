// Descrição: Crie um programa que gera a tabuada de um número escolhido pelo usuário.
//for 

Console.WriteLine("Digite um número para ver a tabuada");
int numero = int.Parse(Console.ReadLine());
int contador = 1;

do
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador++;
}
while (contador <= 10);




