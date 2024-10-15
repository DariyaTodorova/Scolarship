using System;
using Scolarship.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scolarship.View
{
    public class Display
    {
        public double Income { get; set; }
        public double AverageGrade { get; set; }
        public double MinWage { get; set; }
        public string Result { get; set; }

        public void Input()
        {
            Console.Write("Vuvedi suma: ");
            double income = double.Parse(Console.ReadLine());
            Income = income;
            Console.WriteLine("Vuvedi sreden uspeh: ");
            double averagegrade = double.Parse(Console.ReadLine());
            AverageGrade = averagegrade;
            Console.WriteLine("Vuvedi rabotna zaplata: ");
            double minwage = double.Parse(Console.ReadLine());
            MinWage = minwage;

        }
        public void DisplayResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
