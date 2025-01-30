/*
Objetivo: Criar um array que armazene 5 nomes de frutas e, em seguida, imprimir cada nome na tela.
 
Instruções:
- Crie um array de strings para armazenar os nomes das frutas.
- Preencha o array com 5 frutas diferentes.
- Use um loop para iterar sobre o array e imprimir cada fruta.
*/

/*
frutas[0] = "Maça";
frutas[1] = "Tomate";
frutas[2] = "Laranja";
frutas[3] = "Uva";
frutas[4] = "Goiaba";

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Fruta na posição {i}: {frutas[i]}");
}

for (int i = 0; i < frutas.Length; i++)
{
    Console.WriteLine($"Fruta na posição {i}: {frutas[i]}");
}
*/


/*string[] frutas = new string[5];

Console.WriteLine("Digite o nome da fruta na posição 0");
frutas[0] = Console.ReadLine();

Console.WriteLine("Digite o nome da fruta na posição 1");
frutas[1] = Console.ReadLine();

Console.WriteLine("Digite o nome da fruta na posição 2");
frutas[2] = Console.ReadLine();

Console.WriteLine("Digite o nome da fruta na pos~ição 3");
frutas[3] = Console.ReadLine();

Console.WriteLine("Digite o nome da fruta na posição 4");
frutas[4] = Console.ReadLine();


for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Fruta na posição {i}: {frutas[i]}");
}*/


string[] frutas = new string[5];

for(int i = 0; i < frutas.Length; i++) 
{
    Console.Write($"Digite o nome da {i + 1}º fruta");
    frutas[i] = Console.ReadLine();
}
Console.Clear();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Fruta na posição {i}: {frutas[i]}");
}


Console.WriteLine("==========================");
Console.WriteLine("===Frutas digitadas=======");
Console.WriteLine("==========================");

int index = 0;

foreach(string fruta in frutas)
{
    Console.WriteLine($"Fruta na posição {index}: {fruta}");
    index++;
}
