// See https://aka.ms/new-console-template for more information
for (int i = 1; i < 6; i++)
{
    for (int j = 0; j < 6 - i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.ReadKey();
