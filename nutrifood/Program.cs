using nutrifood;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    static void BanyakKata()
    {
        Console.WriteLine("Masukkan kalimat : ");
        string kalimat = Console.ReadLine();

        char[] chars = { ' ', '.', ',', ';', ':', '?', '\n', '\r' };
        string[] words = kalimat.Split(chars);

        Console.WriteLine("Jumlah kata : "+words.Count());
    }

    static void AngkaTerbesar()
    {
        Console.WriteLine("Masukkan jumlah angka: ");

        int jml = Convert.ToInt32(Console.ReadLine());

        int[] tot = new int[jml];
        int tampung = 0;

        Console.WriteLine("Masukkan angka: ");

        for (int i = 0; i < tot.Length; i++)
        {
            tot[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < tot.Length ; i++)
        {
            if (tampung < tot[i])
            {
                tampung = tot[i];
            }

        }

        Console.WriteLine("Angka terbesar: " + tampung);

    }

    static void UrutAngka()
    {
        Console.WriteLine("Masukkan jumlah angka: ");
        int jml = Convert.ToInt32(Console.ReadLine());
        int[] tot = new int[jml];

        Console.WriteLine("Masukkan angka: ");
        for (int i = 0; i < tot.Length; i++)
        {
            tot[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(tot);

        for (int i = 0; i < tot.Length; i++)
        {
            Console.WriteLine(tot[i]);
        }
    }

    static void HurufTerbanyak()
    {
        Console.WriteLine("Masukkan Kata: ");
        String kata = Console.ReadLine();

        int[] hitung = new int[256];
        int max = 0;
        Char hasil = Char.MinValue;

        Array.Clear(hitung, 0, hitung.Length - 1);

        foreach (Char i in kata)
        {
            if (++hitung[i] > max)
            {
                max = hitung[i];
                hasil = i;
            }
        }

        Console.WriteLine("Kata Terbanyak adalah : ");

        Console.WriteLine(hasil);

    }

    static void Palindrom() 
    {
        Console.WriteLine("Masukkan Kata : ");
        string kata = Console.ReadLine();
        char[] huruf = new char[kata.Length];
        int index = 0;
        bool palindrom = false;

        for (int i = 0; i < huruf.Length; i++) 
        {
            huruf[i] = kata[i];
        }

        for(int i = huruf.Length-1;i > 0; i--)
        {
            if (huruf[i] != huruf[index])
            {
                palindrom = false;
                break;
            }
            else
            {
                index++;
                palindrom = true;
            }
        }

        if (palindrom==true)
        {
            Console.WriteLine("Palindrom");
        }
        else
        {
            Console.WriteLine("Tidak Palindrom");
        }
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Mencari Banyak Kata dalam Kalimat");
        BanyakKata();
        Console.WriteLine("Mencari Angka Terbesar");
        AngkaTerbesar();
        Console.WriteLine("Mengurutkan Angka");
        UrutAngka();
        Console.WriteLine("Mencari Huruf Terbanyak dalam Kata");
        HurufTerbanyak();
        Console.WriteLine("Mencari Suatu Huruf Dapat Dikatakan Polindrom");
        Palindrom();

    }
}