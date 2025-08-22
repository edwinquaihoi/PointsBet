using System.Diagnostics.CodeAnalysis;
using System.Text;
namespace PointsBet.Backend.OnlineCodeTest;

/// <summary>
/// A Utility for various CSV operations
/// </summary>
public class StringFormatter
{

    //Code to improve
    public static string ToCommaSeparatedString(string[] items)
    {
        return DelimitWith(items, ",");
    }

    /// <summary>
    /// Produces a delimited string  of the elements in the provided array of strings.
    /// </summary>
    /// <param name="items">A array of strings to be delimited</param>
    /// <param name="delimiter">The character seqeunce to use to delimit items</param>
    /// <returns></returns>
    public static string DelimitWith([NotNull] String[] items, String delimiter)
    {
        if (items?.Length == 0) return "";

        if (items?.Length > 1) return string.Join(delimiter, items);

        return items.First();
    }
}

