namespace Sito_Eratostenesa
{
    public class Program
    {
        static bool[] tablica;

        static void WypelnijTablice(int wielkosc)
        {
            tablica = new bool[wielkosc];
            for(int i = 2; i < wielkosc; i++)
            {
                tablica[i] = true;
            }
        }

        public static void Main(string[] args)
        {
            int n = 100;

            WypelnijTablice(n);

            for(int i = 2; i * i < n; i++)
            {
                if (tablica[i])
                {
                    for(int j = 2 * i; j * n < n; j++)
                    {
                        tablica[j * i] = false;
                    }
                }
            }

            for(int i = 2; i < n; i++)
            {
                if (tablica[i])
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}