Console.WriteLine("Rüya Manavında fiyatlar çok uygun!");

// Burada meyve fiyatlarını int metoduyla depoluyorum ki istediğim zaman veriyi buradan çekebileyim.
int elma = 2;
int armut = 3;
int çilek = 2;
int muz = 3;
int diğer = 4;

Console.WriteLine($"Elma = {elma} TL\nArmut = {armut} TL\nÇilek = {çilek} TL\nMuz = {muz} TL\nDiğer = {diğer} TL\n");

Console.Write("Hangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer): ");
string meyve = Console.ReadLine();

// Girilen metnin büyük ve küçük harf duyarlılığını ortadan kaldırmak için hepsini ToLower metoduyla küçültüyorum ki bir sonraki adımda eşleyebileyim.
string lowerCase = meyve.ToLower();

// Burada girilen metnin eşitlik durumunu kontrol ediyorum ve if yapısıyla fiyat verisini çekiyorum. 
if (lowerCase == "elma")
{
    Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {elma} TL");
}
else if (lowerCase == "armut")
{
    Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {armut} TL");
}
else if (lowerCase == "çilek")
{
    Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {çilek} TL");
}
else if (lowerCase == "muz")
{
    Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {muz} TL");
}
else
{
    Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {diğer} TL");
}

// Buradaki karar verme yapısını switch-case yöntemiyle kurdum.
switch (lowerCase)
{
    case "elma":
        Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {elma} TL");
        break;

    case "armut":
        Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {armut} TL");
        break;
    
    case "çilek":
        Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {çilek} TL");
        break;

    case "muz":
        Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {muz} TL");
        break;

    default:
        Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {diğer} TL");
        break;
}
/* İki karar yapısını da kullandım tam emin olmamakla birlikte burada switch-case karar yapısı daha uygun gözüküyor.
 * Çünkü tek bir koşul kontrol ediliyor ve başka karmaşık ifadeler yok o yüzden kodun okunurluğu ve basitliği için switch-case karar yapısı daha uygun.
 * Daha karmaşık koşullar olsaydı if-else yapısı daha uygun diyebilirdik.
 * Ayrıca tek koşul verildiğinden hızlı çalışması için de switch-case karar yapısı daha uygun.
 */