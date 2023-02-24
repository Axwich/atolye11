// See https://aka.ms/new-console-template for more information
for (int i = 1; i < 6; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(" ");
    }
    for (int a = 0; a < 6 - i; a++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.ReadKey();
