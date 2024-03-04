using nutrifood;

internal class Program
{
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


        Console.WriteLine(kata[2]);
    }

    private static void Main(string[] args)
    {
        // AngkaTerbesar();
        // UrutAngka();
        HurufTerbanyak();

    }
}