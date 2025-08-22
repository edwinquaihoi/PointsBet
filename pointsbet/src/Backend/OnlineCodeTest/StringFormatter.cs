using System.Text;
namespace PointsBet.Backend.OnlineCodeTest;

/*
Improve a block of code as you see fit in C#.
You may make any improvements you see fit, for example:
    - Cleaning up code
    - Removing redundancy
    - Refactoring / simplifying
    - Fixing typos
    - Any other light-weight optimisation
*/
public class StringFormatter
{

    //Code to improve
    public static string ToCommaSeparatedString(string[] items)
    {
        return DelimitWith(items, ",");
    }

    public static string DelimitWith(String[] items, String delimiter)
    {
        if (items?.Length == 0) return "";

        if (items.Length == 1) return items.First();

        return string.Join(delimiter, items);
    }
}

