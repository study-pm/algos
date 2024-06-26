﻿namespace Task
{
    internal class Program
    {
        public static Applicant[] GetApplicantsByMeanGrade(Applicant[] items, double meanGrade)
        {
            List<Applicant> found = new List<Applicant>();
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].MeanGrade == meanGrade) found.Add(items[i]);
            }
            return found.ToArray();
        }
        public static Applicant[] GetApplicantsByMeanGradeNotLessThan(Applicant[] items, double meanGrade)
        {
            List<Applicant> found = new List<Applicant>();
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].MeanGrade >= meanGrade) found.Add(items[i]);
            }
            return found.ToArray();
        }
        public static Applicant[] GetApplicantsByHighestGrade(Applicant[] items)
        {
            List<Applicant> found = new List<Applicant>();
            double highestMeanGrade = items[0].MeanGrade;
            for (int i = 1; i < items.Length; i++)
            {
                if (items[i].MeanGrade > highestMeanGrade)
                {
                    found.Clear();
                    highestMeanGrade = items[i].MeanGrade;
                }
                if (items[i].MeanGrade == highestMeanGrade)
                {
                    found.Add(items[i]);
                }
            }
            return found.ToArray();
        }
        public static void PrintApplicants(Applicant[] items)
        {
            foreach (Applicant item in items) item.Print();
            if (items.Length == 0) Console.WriteLine("No applicants by the given criteria have been found.");
        }
        static void Main(string[] args)
        {
            try
            {
                Applicant[] applicants = new Applicant[]
                {
                    new Applicant(),
                    new Applicant("Julius", "Kerby", 1999, 4.65),
                    new Applicant("Mark", "Haynes", 2015, 3.28),
                    new Applicant("Kathy", "Harris", 2022, 4.5),
                    new Applicant("Mia", "Wilson", 2019, 4.8),
                    new Applicant("Raymond", "Flores", 1975, 4.12),
                };

                Console.WriteLine("Adding new applicant.");
                Applicant newby = Applicant.Add();
                Console.WriteLine("Successfully added new applicant.");
                newby.Print();

                Array.Resize(ref applicants, applicants.Length + 1);
                applicants[applicants.Length - 1] = newby;

                Console.WriteLine(Environment.NewLine);

                double meanGrade = 5.0;

                Console.WriteLine("Applicants with mean grade " + meanGrade);
                Applicant[] applicantsByMeanGrade = GetApplicantsByMeanGrade(applicants, meanGrade);
                PrintApplicants(applicantsByMeanGrade);

                Console.WriteLine(Environment.NewLine);

                Console.Write("Enter mean grade: ");
                meanGrade = double.Parse(Console.ReadLine());

                Console.WriteLine("Applicants with mean grade not less than " + meanGrade);
                PrintApplicants(GetApplicantsByMeanGradeNotLessThan(applicants, meanGrade));

                Console.WriteLine(Environment.NewLine);

                Console.WriteLine("Applicants with highest mean grade");
                PrintApplicants(GetApplicantsByHighestGrade(applicants));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid user input.");
            }
        }
    }
}
