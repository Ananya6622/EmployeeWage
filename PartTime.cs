using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class PartTime
    {
        public static void partTime()
        {
            int wagePerHour = 20;
            int partTimeHours = 4; // Assuming part-time work is 4 hours

            int dailyWage = wagePerHour * partTimeHours;

            Console.WriteLine("Daily Part-time Employee Wage: $" + dailyWage);
        }
    }
}
