Console.Write("Informe o valor total da compra: ");
double ValorFinal = double.Parse(Console.ReadLine());

double desconto = 0;
double valorFinal = 0;

if (ValorFinal >= 200)
{
    
    desconto = ValorFinal * 0.10m;
}
else
{
    
    desconto = 0;
}

valorFinal = ValorFinal - desconto;

Console.WriteLine(); 

Console.WriteLine("Valor original: R$ " + ValorFinal);
Console.WriteLine("Desconto aplicado: R$ " + desconto);
Console.WriteLine("Valor final: R$ " + valorFinal); 