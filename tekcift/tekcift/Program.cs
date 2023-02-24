// See https://aka.ms/new-console-template for more information
int sayi;
Console.Write("Bir Sayı Giriniz... : ");
sayi = Convert.ToInt32(Console.ReadLine());

if (sayi % 2 == 0)
{
    Console.WriteLine($"{sayi} sayısı çifttir");
}
else
{
    Console.WriteLine($"{sayi} sayısı tektir.. ");
}
Console.ReadKey();
