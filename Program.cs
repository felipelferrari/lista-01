Console.Write("Informe a quantidade inicial em estoque: ");
int estoque = int.Parse(Console.ReadLine());
int operacao = 0;

while (operacao != 4)
{
    Console.Write("\n1-Entrada, 2-Saída, 3-Consultar, 4-Encerrar: ");
    operacao = int.Parse(Console.ReadLine());

    if (operacao == 1 || operacao == 2)
    {
        Console.Write("Informe a quantidade: ");
        int qtd = int.Parse(Console.ReadLine());

        if (operacao == 1) 
        {
            estoque += qtd;
            Console.WriteLine("Entrada registrada. Atual: " + estoque);
        }
        else if (qtd <= estoque) 
        {
            estoque -= qtd;
            Console.WriteLine("Saída registrada. Atual: " + estoque);
        }
        else 
        {
            Console.WriteLine("Quantidade insuficiente.");
        }
    }
    else if (operacao == 3) 
    {
        Console.WriteLine("Estoque atual: " + estoque);
    }
}
Console.WriteLine("Estoque final: " + estoque);