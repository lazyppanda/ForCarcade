using System;
using System.Globalization;

namespace ForCarcade.Helpers
{
    public class InputWebFormsDateHelper
    {

        internal DateTime ConvertDateStringToDateTime(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return DateTime.MinValue;
            }
            
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime date = DateTime.ParseExact(text,"yyyy-MM-dd", provider);

            return date;
        }
    }
}