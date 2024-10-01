string[] vetdiasemana = new string[]
{
    "Segunda-feira",//index 0 posição 1
    "Terça-feira",  //index 1 posição 2
    "Quarta-feira", //index 2 posição 3
    "Quinta-feira", //index 3 posição 4
    "Sexta-feira",  //index 4 posição 5
    "Sábado",       //index 5 posição 6
    "Domingo",      //index 6 posição 7
};
string[] tarefas = new string[7];

for (int i = 0; i < tarefas.Length; i++)
{
    Console.WriteLine($"insira as tarefas para {vetdiasemana[i]}");
    tarefas[i] = Console.ReadLine();
}


Console.WriteLine("tarefas para a semana:");
for (int i = 0; i < vetdiasemana.Length; i++)
{
    Console.WriteLine($"\n{vetdiasemana[i]}: {tarefas[i]}");
}


Console.ReadKey();