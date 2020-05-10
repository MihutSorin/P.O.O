using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

namespace clasa_elevi
{
    public class Elev
    {
        private string firstName;
        private string lastName;
        private int numberOffGrades;
        private string[] grades;
        private double average;
        public string Name => lastName + firstName;
        public double Average => average;
        public string[] Grades => grades;
        public Elev()
        {

        }
        public Elev(string lastName, string firstName, string numberOffGrades, string[] grades)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.numberOffGrades = int.Parse(numberOffGrades);
            this.grades = grades;
        }

        public Elev(string lastName, string firstName, double average)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.average = average;
        }

        public double GetAverage(string[] grades)
        {
            double average = 1;
            foreach (var grade in grades)
            {
                average =average+int.Parse(grade);
            }
            average /= grades.Length;

            return average;
        }
        public override string ToString()
        {
            return $"{this.Name} - average: {this.average}";
        }
    }
}
