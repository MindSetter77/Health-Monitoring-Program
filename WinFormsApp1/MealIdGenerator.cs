using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class MealIdGenerator
    {
        public static string MakeMealId(DateTime time)
        {
            int[] desiredPositions = { 0, 1, 3, 4, 6, 7, 8, 9 };
            string result = "";

            string originalString = time.ToString();

            foreach (var position in desiredPositions)
            {
                if (position < originalString.Length) // Sprawdź, czy pozycja nie wykracza poza długość stringa
                {
                    result += originalString[position]; // Dodaj znak z danej pozycji do wyniku
                }
            }

            return result;
        }
    }
}
