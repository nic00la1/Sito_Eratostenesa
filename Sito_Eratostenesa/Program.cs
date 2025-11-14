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
        }
    }
}