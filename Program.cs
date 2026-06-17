Console.Write("Informe o primeiro valor: ");
double v1 = double.Parse(Console.ReadLine());

Console.Write("Informe o segundo valor: ");
double v2 = double.Parse(Console.ReadLine());

Console.Write("Informe o terceiro valor: ");
double v3 = double.Parse(Console.ReadLine());

Console.Write("Informe o quarto valor: ");
double v4 = double.Parse(Console.ReadLine());

Console.Write("Informe o quinto valor: ");
double v5 = double.Parse(Console.ReadLine());

double soma = v1 + v2 + v3 + v4 + v5;
double media = soma / 5;

Console.WriteLine("Soma dos valores: " + soma);
Console.WriteLine("Média dos valores: " + media);