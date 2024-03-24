using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    /// <summary>
    /// Class for personal data
    /// </summary>
    public class Person
    {
        private string _name;       // first name
        private string _surname;    // last name
        private DateTime _birth;    // birth date

        /// <summary>
        /// Three-params constructor for initializing all class fields with user provided data
        /// </summary>
        /// <param name="name">First name</param>
        /// <param name="surname">Last name</param>
        /// <param name="birth">Date of birth</param>
        public Person(string name, string surname, DateTime birth)
        {
            _name = name;
            _surname = surname;
            _birth = birth;
        }

        /// <summary>
        /// No-params constructor for initializing all class fields with default data
        /// </summary>
        public Person() : this("UknonwnName", "UnknownSurname", DateTime.Now)
        {
        }

        public DateTime Birth { get { return _birth; } set {  _birth = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Surname { get { return _surname; } set { _surname = value; } }
        /// <summary>
        /// Get year of birth
        /// </summary>
        public int Year {
            get
            {
                return _birth.Year;
            }
            set
            {
                // Creating new date with provided and previous data
                _birth = new DateTime(value, _birth.Month, _birth.Day);
            }
        }
        /// <summary>
        /// Get string representation of all class data
        /// </summary>
        /// <returns>Formatted data string</returns>
        public override string ToString()
        {
            return String.Format("First name: {0}\nLast name: {1}\nDate of birth: {2}", _name, _surname, _birth.ToShortDateString());
        }
        /// <summary>
        /// Get string containing first and last names only
        /// </summary>
        /// <returns>Formatted data string</returns>
        public virtual string ToShortString()
        {
            return String.Format("First name: {0}\nLast name: {1}", _name, _surname);
        }
    }
}
