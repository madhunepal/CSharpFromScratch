using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee tony = new Employee();
            maddy.Income = 150000;
            maddy.YearsOfService = 8;
            maddy.SetRating(Employee.Rating.excellent);
            maddy.CalculateRaise();
        }
    }
    public class Employee
    {
        public enum Rating
        {
            poor;
            good;
            excellent;
        }
        private Rating rating;
        public double Income { get; set; }
        public int YearOfService { get; set; }
        public void SetRating(Rating rating)
        {
            this.rating = rating;
        }
        public void CalculateRaisee()
        {
            double baseRaise = Income * .05;
            double bonus = YearOfService * 1000;
            Income += baseRaise + bonus;
            switch (rating)
            {
                case Rating.poor:
                    Income -= YearOfService * 2000;
                    break;
                case Rating.good:
                    break;
                case Rating.excellent:
                    Income += YearOfService * 500;
                    break;
            }
        }
    } 

}
