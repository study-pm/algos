namespace Task
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
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Applicant[] applicants = new Applicant[]
            {
                new Applicant(),
                new Applicant("Julius", "Kerby", 1999, 4.65),
                new Applicant("Mark", "Haynes", 2015, 3.28),
                new Applicant("Kathy", "Harris", 2022, 5),
                new Applicant("Mia", "Wilson", 2019, 4.8),
                new Applicant("Raymond", "Flores", 1975, 4.12),
            };

            double meanGrade = 5;

            Console.WriteLine("Applicants with mean grade " + meanGrade);
            Applicant[] applicantsByMeanGrade = GetApplicantsByMeanGrade(applicants, meanGrade);
            PrintApplicants(applicantsByMeanGrade);

            Console.WriteLine(Environment.NewLine);

            meanGrade = 4.2;
            Console.WriteLine("Applicants with mean grade not less than " + meanGrade);
            PrintApplicants(GetApplicantsByMeanGradeNotLessThan(applicants, meanGrade));

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Applicants with highest mean grade");
            PrintApplicants(GetApplicantsByHighestGrade(applicants));
        }
    }
}
