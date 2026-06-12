Console.Write("Informe o valor total da compra: ");
decimal ValorFinal = decimal.Parse(Console.ReadLine());

decimal desconto = 0;
decimal valorFinal = 0;

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