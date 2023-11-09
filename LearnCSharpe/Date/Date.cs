using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    internal class Date
    {
        //Attribute
        private int day;
        private int month;
        private int year;

        //properties
        public int Day
        {
            get { return day; }
            set
            {
                if (value > 0 && day <= 31)
                {
                    day = value;

                }
                else
                {
                    do
                    {
                        Console.WriteLine("Day not valid try again!");
                        value = int.Parse(Console.ReadLine());
                    } while (value <= 0 || value > 31);
                    day = value;
                }
            }
        }
        public int Month
        {
            get { return month; }
            set
            {
                if (value > 0 && value <= 12)
                {
                    month = value;

                }
                else
                {
                    do
                    {
                        Console.WriteLine("Month not valid try again!");
                        value = int.Parse(Console.ReadLine());
                    } while (value <= 0 || value > 12);
                    month = value;
                }
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value > 1990 && value <= 9999)
                {
                    year = value;

                }
                else
                {
                    do
                    {
                        Console.WriteLine("Year not valid try again!");
                        value = int.Parse(Console.ReadLine());
                    } while (value < 1990 || value > 9999);
                    year = value;
                }
            }
        }

        //Constructor
        public Date() { }
        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        //Method
        public int getDay()
        {
            return day;
        }
        public int getMonth()
        {
            return month;
        }
        public int getYear()
        {
            return year;
        }
        public void setDay(int day)
        {
            Day = day;
        }
        public void setMonth(int month)
        {
            Month = month;
        }
        public void setYear(int year)
        {
            Year = year;
        }
        public void setDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public String toString()
        {
            string s = "";
            if (day < 10)
            {
                s += $"0{Day}/";
            }
            else
            {
                s += $"{Day}/";
            }
            if (month < 10)
            {
                s += $"0{Month}/";
            }
            else
            {
                s += $"{Month}/";
            }
            s += $"{Year}";
            return s;
        }
    }
}
