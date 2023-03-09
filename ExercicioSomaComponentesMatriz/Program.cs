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

//Diagonal principal
for (row = 0; row < 5; row++)
{
    primDiag += matriz[row, row];
}

//Diagonal secundaria
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
Console.WriteLine();
sumLine();
Console.WriteLine();
sumCol();

void sumCol()
{
    for (int column = 0; column < 5; column++)
    {
        int soma = 0;
        for (int i = 0; i < 5; i++)
        {
            soma += matriz[i, column];
        }
        Console.WriteLine("A soma da coluna " + column + " é: " + soma);
    }
}

void sumLine()
{
    for (int line = 0; line < 5; line++)
    {
        int soma = 0;
        for (int i = 0; i < 5; i++)
        {
            soma += matriz[line, i];
        }
        Console.WriteLine("A soma da linha " + line + " é: " + soma);
    }
}
