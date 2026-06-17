Console.Write("Informe a quantidade de clientes atendidos: ");
int clientes = int.Parse(Console.ReadLine());

double tempoTotal = 0;

for (int i = 1; i <= clientes; i++)
{
    Console.Write("Informe o tempo do atendimento: ");
    double tempo = double.Parse(Console.ReadLine());
    tempoTotal = tempoTotal + tempo;
}

double tempoMedio = tempoTotal / clientes;

Console.WriteLine("Tempo total de atendimento: " + tempoTotal + " minutos");
Console.WriteLine("Tempo médio por cliente: " + tempoMedio + " minutos");