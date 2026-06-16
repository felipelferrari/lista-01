Console.WriteLine("Informe a primeira pontuação:");
int primeiraPontuacao = int.Parse(Console.ReadLine()!);

Console.WriteLine("Informe a segunda pontuação:");
int segundaPontuacao = int.Parse(Console.ReadLine()!);

Console.WriteLine("Informe a terceira pontuação:");
int terceiraPontuacao = int.Parse(Console.ReadLine()!);

int maiorPontuacao = primeiraPontuacao;

if (primeiraPontuacao == segundaPontuacao && segundaPontuacao == terceiraPontuacao)
{
    Console.WriteLine("As três pontuações são iguais.");
}
else 

if (segundaPontuacao > maiorPontuacao)
{
    maiorPontuacao = segundaPontuacao;
}

if (terceiraPontuacao > maiorPontuacao)
{
    maiorPontuacao = terceiraPontuacao;
}
Console.WriteLine($"A maior pontuação é: {maiorPontuacao}");