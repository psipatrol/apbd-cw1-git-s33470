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
}