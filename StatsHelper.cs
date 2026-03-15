namespace apbd_cw1_git_s33192;

public class StatsHelper
{
    public static double CalculateAverage(int[] values)
    {
        Console.WriteLine("Obliczanie średniej...");
        if (values.Length == 0)
        {
            Console.WriteLine("Błąd: Nie można obliczyć średniej dla pustej tablicy.");
            return 0;
        }
        return values.Sum() / values.Length;
    }

    public static double CalculateMax(int[] values)
    {
        Console.WriteLine("Obliczanie maksimum...");
        if (values.Length == 0)
        {
            Console.WriteLine("Błąd: Nie można obliczyć maksimum dla pustej tablicy.");
            return 0;
        }
        return values.Max();
    }

    public static double CalculateMin(int[] values)
    {
        return values.Min();
    }
    
    

    
    
}

        

        
    


