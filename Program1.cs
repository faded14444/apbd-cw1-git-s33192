using System;
using apbd_cw1_git_s33192;

namespace ApbdCw1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Witaj w branchu main!");
            Console.WriteLine("Wprowadź ciąg liczb oddzielonych spacją:");
            
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Błąd: Nie wprowadzono żadnych danych. Zamykam program.");
                return;
            }

            string[] stringParts = input.Split(' ');
            int[] numbers = new int[stringParts.Length];

            for (int i = 0; i < stringParts.Length; i++)
            {
                if (int.TryParse(stringParts[i], out int number))
                {
                    numbers[i] = number;
                }
            }

            Console.WriteLine("Dane zostały poprawnie wczytane i przygotowane do obliczeń.");
            
        }
        StatsHelper statsHelper = new StatsHelper();
    }
}