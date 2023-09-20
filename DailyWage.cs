using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class DailyWage
    {
        public static void wage()
        {
            int wagePerHour = 20;
            int fullDayHours = 8;

            int dailyWage = wagePerHour * fullDayHours;

            Console.WriteLine("Daily Employee Wage: $" + dailyWage);
        }
    }
}
