namespace apbd_cw1_git_s33470;

public class StatisticsHelper
{
    public static int GetTextLenght(string text)
    {
        return text.Length;
    }

    public static string GetText(string text)
    {
        return text;
    }

    public static int HexToInt(string hex)
    {
        return Convert.ToInt32(hex, 16);
    }

    public static double CalculateAverage(int[] numbers)
    {
        double sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum / numbers.Length;
    }
    
    public static int CalculateMax(int[] numbers)
    {
        int max = int.MinValue;
        foreach (int number in numbers)
        {
            if (number > max) 
            {
                 max = number;
            }
        }
        return max;
    }
    
    public static int CalculateMin(int[] numbers)
    {
        int min = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number < min) 
            {
                min = number;
            }
        }
        return min;
    }
}