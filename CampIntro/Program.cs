
//type safety
String kategoriEtiketi = "Kategori";
Console.WriteLine(kategoriEtiketi);

bool sistemeGirisYapmisMi = true;
double dolarDun = 7.45;
double dolarBugun = 7.35;

if (dolarDun > dolarBugun)
{
    Console.WriteLine("Azalis butonu");
}
else if (dolarDun < dolarBugun)
{
    Console.WriteLine("Artis Butonu");
}
else
{
    Console.WriteLine("Degismedi Butonu");
}

if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("Hosgeldin");
}
else
{
    Console.WriteLine("Giris Yap");
}