using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_OPP
{
    public class HiringDate
    {
        private int day;
        private int month;
        private int year;
        
        public HiringDate(int day, int month ,int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;

        }
        public int Day
        {
            get => day;
            set
            {
                if (value > 0 && value <= 31)
                    day = value;
                else
                    Console.WriteLine("Invalid day. It must be between 1 and 31.");
            }
        }

        public int Month
        {
            get => month;
            set
            {
                if (value > 0 && value <= 12)
                    month = value;
                else
                    Console.WriteLine("Invalid month. It must be between 1 and 12.");
            }
        }

        public int Year
        {
            get => year;
            set
            {
                if (value >= 2000 && value <= 2100)
                    year = value;
                                else
                    Console.WriteLine("Invalid year. It must be between 2000 and 2100.");
            }
        }

        public void Display()
        {
            Console.WriteLine($"Hiring Date: {Day}/{Month}/{Year}");
        }
        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
































    }
}