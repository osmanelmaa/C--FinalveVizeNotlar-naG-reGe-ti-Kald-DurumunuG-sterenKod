

using System.ComponentModel;

Console.WriteLine("Lütfen Vize Notunuzu Giriniz:");
int vize = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen Final Notunuzu Giriniz:");
int final = Convert.ToInt32(Console.ReadLine());


double sonuc = (vize * 0.4) + (final * 0.6);
Console.WriteLine("Ortalama {0}", sonuc);

if (sonuc > 60)
{
    Console.WriteLine("Tebrikler Dersi Geçtiniz");
}
else
{
    Console.WriteLine("Maalesef Dersten Kaldınız");
}



