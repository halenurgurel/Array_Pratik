using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // 1 ile 10 adet tam sayı verisi alacak bir dizi tanımlıyoruz.

        int[] numbers = new int[10];

        //Dizinin elemanlarını kullanıcıdan alııyoruz.

        for (int i =0; i<numbers.Length; i++)
        {
            Console.Write($"Lütfen {i+1}. sayıyı girin: ");
            numbers[i] = Convert.ToInt32( Console.ReadLine() );

        }
        Console.WriteLine(" ");

        //foreach ile diziyi yazdırdık.

        Console.WriteLine("\nGirilen sayılar: ");
        foreach (int i in numbers)
        {
            Console.WriteLine(i); //girilen sayıları yazdırdık
        }

        Console.WriteLine(" ");
        //Diziye kullanıcıdan aldığımız 11. değeri ekliyoruz.

        Console.Write("Yeni bir sayı girin (11. sayı): ");
        int newNumber = Convert.ToInt32( Console.ReadLine() );

        //Diziyi listeye çevirdik çünkü diziye doğrudan eleman ekleyemiyoruz.

        List<int> numbersList = new List<int>(numbers);
        numbersList.Add(newNumber); //11. elemanı ekledik.

        //Listeyi büyükten küçüğe doğru sıralıyoruz

        numbersList.Sort(); //Küçükten büyüğe sıralar
        numbersList.Reverse(); //Büyükten küçüğe çevirir.

        Console.WriteLine(" ");
        Console.WriteLine("Büyükten küçüğe doğru sıralanmış sayılarınız: ");

        foreach (int i1 in numbersList)
        {
            Console.WriteLine(i1); //11. elemanın eklendiği diziyi büyükten küçüğe çevirdikten sonra yazdırdık.
        }
    }
}