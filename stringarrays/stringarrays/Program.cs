// See https://aka.ms/new-console-template for more information
String[] arabalar = { "BMW", "Mercedes", "Audi", "Porsche", "Togg", "volksWagen", "Tesla" };
Console.WriteLine($"Listede {arabalar.Length} adet araba vardır");
for (int i = 0; i < arabalar.Length; i++)
{
    Console.WriteLine(arabalar[i]);

}
Console.WriteLine("----------- Sıralı Liste ------------");
Array.Sort(arabalar);
for (int i = 0; i < arabalar.Length; i++)
{
    Console.WriteLine(arabalar[i]);

}
Console.ReadKey();
