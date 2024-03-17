using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Program
{
    public class Student : Person
    {
        public Person PersonalData { get; set; }
        public string ContactData { get; set; }
        public DateTime EdStartDate { get; set; }

        public Student(Person personalData, string contactData, DateTime edStartDate)
        {
            PersonalData = personalData;
            ContactData = contactData;
            EdStartDate = edStartDate;
        }
        public Student()
        {
            PersonalData = new Person();
            ContactData = "n/a";
            EdStartDate = DateTime.Now;
        }
        public override string ToString()
        {
            return PersonalData.ToString() + Environment.NewLine + String.Format("Contact data: " + ContactData + "\nEducation start date: " + EdStartDate.ToShortDateString());
        }
    }
}
