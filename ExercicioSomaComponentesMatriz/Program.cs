int[,] matriz = new int[5, 5];
int col, row, primDiag = 0, secDiag = 0;
Random random = new Random();


for (row = 0; row < 5; row++)
{
    for (col = 0; col < 5; col++)
    {
        matriz[row, col] = random.Next(100);
    }
}

for(row =  0; row < 5; row++)
{
    primDiag += matriz[row, row];
}

for (row = 0; row < 5; row++)
{
    secDiag += matriz[row, 4 - row];
}

for (row = 0; row < 5; row++)
{
    for (col = 0; col < 5; col++)
    {
        Console.Write($"{matriz[row, col],3} |");
    }
    Console.WriteLine();
}

Console.WriteLine("\nA soma da diagonal principal é: " + primDiag);
Console.WriteLine("A soma da diagonal secundária é: " + secDiag);
Console.WriteLine("\nA soma da linha 0 é: " + sumLine(0));
Console.WriteLine("A soma da linha 1 é: " + sumLine(1));
Console.WriteLine("A soma da linha 2 é: " + sumLine(2));
Console.WriteLine("A soma da linha 3 é: " + sumLine(3));
Console.WriteLine("A soma da linha 4 é: " + sumLine(4));
Console.WriteLine("\nA soma da coluna 0 é: " + sumCol(0));
Console.WriteLine("A soma da coluna 1 é: " + sumCol(1));
Console.WriteLine("A soma da coluna 2 é: " + sumCol(2));
Console.WriteLine("A soma da coluna 3 é: " + sumCol(3));
Console.WriteLine("A soma da coluna 4 é: " + sumCol(4));


int sumCol(int col){
    int soma = 0;

    for(int i = 0; i < 5; i++)
    {
        soma += matriz[i, col];
    }

    return soma;
}

int sumLine(int row)
{
    int soma = 0;

    for (int i = 0; i < 5; i++)
    {
        soma += matriz[row, i];
    }

    return soma;
}

/*int RandomNumber()
{
    Random random = new Random();
    int rnd = random.Next(100);
    return rnd;
}*/