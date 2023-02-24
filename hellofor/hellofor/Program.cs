// See https://aka.ms/new-console-template for more information
int toplam = 0;
Console.WriteLine("Bir sayı giriniz. :");
int deger = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= deger; i++)
{
    toplam = toplam + i;
}
Console.WriteLine($"Toplam sonucu {toplam}");
Console.ReadKey();
