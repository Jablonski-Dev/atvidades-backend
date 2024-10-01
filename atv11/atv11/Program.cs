try
{
    Console.Write("digite um numerador: "); //"5" == 5
    int numerador = int.Parse(Console.ReadLine());

    Console.Write("Digite o denominador: ");
    int denominador = int.Parse(Console.ReadLine());

    int resultado = numerador + denominador;
    Console.WriteLine($"O resultado de divisão é: {resultado}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Erro: não é possivel dividir por zero");
}
catch (FormatException)
{
    Console.WriteLine("Erro: Por favor, digite numeros valídos");
}
catch (OverflowException)
{
    Console.WriteLine("Erro: Por favor, digite um numero maior que zero");
}

Console.ReadKey();
