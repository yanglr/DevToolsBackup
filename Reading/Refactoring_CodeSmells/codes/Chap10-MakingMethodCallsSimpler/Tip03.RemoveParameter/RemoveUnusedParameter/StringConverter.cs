using System.Globalization;

namespace Tip03.RemoveParameter.RemoveUnusedParameter
{
    internal class StringConverter
    {
        public static string ConvertToString(int num)
        {
            return num.ToString(CultureInfo.InvariantCulture);
        }
    }
}