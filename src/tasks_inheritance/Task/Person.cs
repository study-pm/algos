using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    /// <summary>
    /// Base class for personal data
    /// </summary>
    internal class Person
    {
        private string _firstName;
        private string _lastName;
        private DateTime _birthDate;
        /// <summary>
        /// Instatiate new item initialized with provided values
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthDate"></param>
        public Person(string firstName, string lastName, DateTime birthDate)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthDate = birthDate;
        }
        /// <summary>
        /// Insantiated new item initialized with default values
        /// </summary>
        public Person()
        {
            _firstName = "Default";
            _lastName = "Anonymous";
            _birthDate = DateTime.Now;
        }
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public DateTime BirthDate { get { return _birthDate; } set { _birthDate = value; } }
        /// <summary>
        /// Get item data
        /// </summary>
        /// <returns>String representation of item data</returns>
        public virtual string ToString()
        {
            return $"First name: {FirstName}, last name: {LastName}, date of birth: {BirthDate.ToString("dd MMMM yyyy")}";
        }
    }
}
