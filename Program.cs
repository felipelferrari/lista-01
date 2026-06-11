Console.WriteLine("idade do visitante");
int idade = int.Parse(Console.ReadLine());

if (idade < 16)
{
    Console.WriteLine("Entrada liberada somente com responsável");
}
else
{
    Console.WriteLine("Entrada liberada");
}
