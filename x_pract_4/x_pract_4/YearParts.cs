using System;
using System.Collections.Generic;
using System.Text;

namespace x_pract_4
{    
    class YearParts
    {
        Dictionary<string, string> monthYear = new Dictionary<string, string>();

        public YearParts()
        {
            monthYear.Add("September", "Autumn ");
            monthYear.Add("October", "Autumn ");
            monthYear.Add("November", "Autumn ");
            monthYear.Add("December", "Winter");
            monthYear.Add("Yanuarн", "Winter");
            monthYear.Add("February", "Winter");
            monthYear.Add("March", "Spring");
            monthYear.Add("April", "Spring");
            monthYear.Add("May", "Spring");
            monthYear.Add("June", "Summer");
            monthYear.Add("July", "Summer");
            monthYear.Add("August", "Summer");
        }

        public string GivePart(string month)
        {
            if(month != "")
            {
                return monthYear[month];                
            }
            else
            {
                return "Введите масяц";
            }
        }
    }
}
