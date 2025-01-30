/*

Desafio: Criar um programa que receba 6 nome utilizando arrays. Ao final o programa deve exibir todos os nome digitados

*/

string[] nomes = new string[5];

Console.WriteLine("Digite o nome da nome na posição 0");
nomes[0] = Console.ReadLine();

Console.WriteLine("\"Digite o nome da nome na posição 1");
nomes[1] = Console.ReadLine();

Console.WriteLine("\"Digite o nome da nome na posição 2");
nomes[2] = Console.ReadLine();

Console.WriteLine("\"Digite o nome da nome na posição 3");
nomes[3] = Console.ReadLine();

Console.WriteLine("\"Digite o nome da nome na posição 4");
nomes[4] = Console.ReadLine();


for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Fruta na posição {i}: {nomes[i]}");
}
