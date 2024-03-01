using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Applicant
    {
        private string firstName;
        private string lastName;
        private int graduationYear;
        private double meanGrade;

        private static double[] gradeRange = new double[] { 0, 5 };
        private static int yearSpan = 75;

        public string FirstName {
            get { return firstName; }
            set {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value)) throw new ArgumentNullException("value");
                firstName = value;
            }
        }
        public string LastName {
            get { return lastName; }
            set {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value)) throw new ArgumentNullException("value");
                lastName = value;
            }
        }
        public int GraduationYear {
            get { return graduationYear; }
            set {
                int currentYear = DateTime.Now.Year;
                if (value > currentYear || value < currentYear - Applicant.yearSpan) throw new ArgumentOutOfRangeException("value");
                graduationYear = value;
            }
        }
        public double MeanGrade {
            get { return meanGrade; }
            set {
                if (value < Applicant.gradeRange[0] || value > Applicant.gradeRange[1]) throw new ArgumentOutOfRangeException("value");
                meanGrade = value;
            }
        }
        public Applicant()
        {
            FirstName = "Anonymous";
            LastName = "Anonymous";
            GraduationYear = DateTime.Now.Year;
            MeanGrade = 0;
        }
        public Applicant(string firstName, string lastName, int graduationYear, double meanGrade)
        {
            FirstName = firstName;
            LastName = lastName;
            GraduationYear = graduationYear;
            MeanGrade = meanGrade;
        }
        public static Applicant Add()
        {
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter graduation year: ");
            int graduationYear = int.Parse(Console.ReadLine());
            Console.Write("Enter mean grade: ");
            double meanGrade = double.Parse(Console.ReadLine());
            return new Applicant(firstName, lastName, graduationYear, meanGrade);
        }
        public void Print()
        {
            Console.WriteLine($"Applicant first name is {firstName}, last name is {lastName}, graduation year is {graduationYear}, mean grade is {meanGrade}.");
        }
    }
}
