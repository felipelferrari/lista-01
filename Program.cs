Console.WriteLine("informe anota final do estudante");
if (double.TryParse(Console.ReadLine(), out double notaFinal))
{
    if (notaFinal >= 7.0)
    {
        Console.WriteLine("Aprovado");
    }
    else if (notaFinal >= 5.0)
    {
        Console.WriteLine("Recuperação");
    }
    else
    {
        Console.WriteLine("Reprovado");
    }
}
else
{
    Console.WriteLine("Valor inválido. Por favor, insira um número.");
}