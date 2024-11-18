using System.Globalization;

namespace Tip03.RemoveParameter
{
    internal class StringConverter
    {
        public static string ConvertToString(int num, int num2)
        {
            return num.ToString(CultureInfo.InvariantCulture);
        }
    }
}