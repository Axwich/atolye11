// See https://aka.ms/new-console-template for more information
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(" ");
    }
    for (int z = 0; z < (4 - i) * 2 - 1; z++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.ReadKey();
