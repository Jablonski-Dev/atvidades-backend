int nota;
Console.Write("informe a sua nota:");
int.TryParse(Console.ReadLine(), out nota);


if (nota > 89 && nota < 101)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("A");
}
else if (nota >79 && nota <90)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("B");
}

else if (nota > 69 && nota < 80)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("C");
}

else if (nota > 59 && nota < 70)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("D");
}

else if (nota < 60)
{
    Console.ForegroundColor = ConsoleColor.Red
        ;
    Console.WriteLine("F");
}

Console.WriteLine("programa encerra");
Console.ReadKey();