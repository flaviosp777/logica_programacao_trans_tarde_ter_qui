Console.WriteLine("Nome completo do aluno: ");

string n = Console.ReadLine();

Console.WriteLine("Nota 1: ");

double nota1 = Double.Parse(Console.ReadLine());

Console.WriteLine("Nota 2: ");

double nota2 = Double.Parse(Console.ReadLine());

Console.WriteLine("Nota 3: ");

double nota3 = Double.Parse(Console.ReadLine());

double media = (nota1 + nota2 + nota3) / 3;

if (media >= 7)

{

    Console.WriteLine("Aprovado!");

}

else if (media >= 4)

{

    Console.WriteLine("Recuperação!");

}

else if (media < 4)

{

    Console.WriteLine("Reprovado!");

}
