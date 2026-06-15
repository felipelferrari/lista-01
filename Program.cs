Console.WriteLine("Informe a quantidade de tarefas concluídas:");
int tarefasConcluidas = int.Parse(Console.ReadLine());
int Meta = 50;
if (tarefasConcluidas >= Meta)
{
    Console.WriteLine("Meta atingida.");
    Console.WriteLine($"Tarefas concluídas: {tarefasConcluidas}");
}

else
{
    Console.WriteLine("Meta não atingida.");
    Console.WriteLine($"Faltaram {Meta - tarefasConcluidas} tarefas.");
}