try // denenecek kod
{
Console.WriteLine("Bir sayı giriniz:");
int sayi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("girdigin sayi"+sayi);
 
}
catch(Exception ex) // hata yakalanırsa ne yapılsın
{
Console.WriteLine("Hata:" +ex.Message.ToString());
}
finally // koşulsuz olarak çalıştır gerek yok try catch yeter
{
    Console.WriteLine("İslem Tamamlandi");
}
//parse string --> int
try
{
    //int a = int.Parse(null);
    //int a = int.Parse("test");
    int a =int.Parse("50000000000");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Bos deger girdiniz.");
    Console.WriteLine(ex);
}

catch(FormatException exx)
{
    Console.WriteLine("Veri tipi uygun değil");
    Console.WriteLine(exx);
}

catch(OverflowException exxx)
{
    Console.WriteLine("Çok büyük bir deger girdiniz");
    Console.WriteLine(exxx);
}

finally
{
    Console.WriteLine("İşlem Başarı ile tamamlandi");
}

//try{ Hataya sebebiyet verme ihtimali olan kod }

//catch { Hata ile karşılaşıldığında ne yapılacağı buraya yazılır }

//finally{ Hata olsun olmasın mutlaka yapılmasını istediğimiz işler varsa buraya yazarız }