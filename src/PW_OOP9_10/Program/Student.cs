using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Program
{
    /// <summary>
    /// Class for student data
    /// </summary>
    public class Student
    {
        public Person PersonalData { get; set; }
        public string ContactData { get; set; }
        public DateTime EdStartDate { get; set; }

        /// <summary>
        /// Params constructor for initializing all relevant class fields with user provided data
        /// </summary>
        /// <param name="personalData">Personal data (first and last name, date of birth)</param>
        /// <param name="contactData">Contact data (such as address, mail, phone, etc.)</param>
        /// <param name="edStartDate">Date when education began</param>
        public Student(Person personalData, string contactData, DateTime edStartDate)
        {
            PersonalData = personalData;
            ContactData = contactData;
            EdStartDate = edStartDate;
        }
        /// <summary>
        /// No-params constructor for initializing all class fields with default data
        /// </summary>
        public Student()
        {
            PersonalData = new Person();
            ContactData = "n/a";
            EdStartDate = DateTime.Now;
        }
        /// <summary>
        /// Get string representation of all class data
        /// </summary>
        /// <returns>Formatted data string</returns>
        public override string ToString()
        {
            return PersonalData.ToString() + Environment.NewLine + String.Format("Contact data: " + ContactData + "\nEducation start date: " + EdStartDate.ToShortDateString());
        }
        /// <summary>
        /// Get single string containing first and last names only
        /// </summary>
        /// <returns>Short data string</returns>
        public string ToShortString()
        {
            return PersonalData.Surname + " " + PersonalData.Name;
        }
    }
}
