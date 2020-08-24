using System;

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

            var splittedValue = text.Split('-');
            int year = int.Parse(splittedValue[0]);
            int month = int.Parse(splittedValue[1]);
            int day = int.Parse(splittedValue[2]);

            DateTime date = new DateTime(year, month, day);

            return date;
        }
    }
}