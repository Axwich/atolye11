// See https://aka.ms/new-console-template for more information
for (int i = 1; i < 10; i++)
{
    for (int j = 1; j < 10; j++)
    {
        Console.Write($"{i}x{j}={i * j}\t");
    }
    Console.Write("\n");
}
Console.ReadKey();
