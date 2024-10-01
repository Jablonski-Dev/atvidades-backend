Console.WriteLine("escolha o mês de 1 a 12");
int mesescolhido = int.Parse(Console.ReadLine());

switch (mesescolhido)
{
    case 1:
        Console.WriteLine("Janeiro, verão");
        break;

    case 2:
        Console.WriteLine("Fevereiro, verão");
        break;

    case 3:
        Console.WriteLine("Março, Outono");
        break;

    case 4:
        Console.WriteLine("Abril, Outono");
        break;

    case 5:
        Console.WriteLine("Maio, Outono");
        break;

    case 6:
        Console.WriteLine("Junho, Inverno");
        break;

    case 7:
        Console.WriteLine("Julho, Inverno");
        break;

    case 8:
        Console.WriteLine("Agosto, Inverno");
        break;

    case 9:
        Console.WriteLine("Setembro, Primavera");
        break;

    case 10:
        Console.WriteLine("Outubro, Primavera");
        break;

    case 11:
        Console.WriteLine("Novembro, Primavera");
        break;

    case 12:
        Console.WriteLine("Dezembro, Verão");
        break;


    default:
        Console.WriteLine("o numero escolhido não é permitido");
        break;

}

Console.WriteLine("digite uma tecla para encerrar");
Console.ReadKey();