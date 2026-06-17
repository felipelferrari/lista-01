 Console.Write("Informe a idade do passageiro: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Informe o valor normal da passagem: ");
        double valor = double.Parse(Console.ReadLine());

        double valorFinal;

        if (idade <= 5)
            valorFinal = 0;
        else if (idade >= 60)
            valorFinal = valor / 2;
        else
            valorFinal = valor;

        Console.WriteLine("Valor normal da passagem: R$ " + valor);
        Console.WriteLine("Valor a pagar: R$ " + valorFinal);