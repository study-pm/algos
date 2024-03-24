using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    /// <summary>
    /// Class for group data
    /// </summary>
    public class Group
    {
        private string _name;
        private int _formationYear;
        private Student[] _studentList = Array.Empty<Student>();
        /// <summary>
        /// Params constructor for initializing all relevant class fields with user provided data
        /// </summary>
        /// <param name="name"></param>
        /// <param name="formationYear"></param>
        public Group(string name, int formationYear)
        {
            _name = name;
            _formationYear = formationYear;
        }
        /// <summary>
        /// No-params constructor for initializing all class fields with default data
        /// </summary>
        public Group()
        {
            _name = "DefaultGroup";
            _formationYear = DateTime.Now.Year;
        }
        /// <summary>
        /// Get/set group name or title
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// Get/set group formation year
        /// </summary>
        public int Year
        {
            get { return _formationYear; }
            set {_formationYear = value; }
        }
        /// <summary>
        /// Get/set list of students
        /// </summary>
        public Student[] Students
        {
            get { return _studentList; }
            set { _studentList = value; }
        }
        /// <summary>
        /// Get youngest student in group
        /// </summary>
        public Student YoungestStudent {
            get {
                Student youngestStudent = _studentList[0];
                foreach(Student student in _studentList)
                {
                    if (DateTime.Compare(student.PersonalData.Birth, youngestStudent.PersonalData.Birth) > 0)
                    {
                        youngestStudent = student;
                    }
                }
                return youngestStudent;
            }
        }
        /// <summary>
        /// Add any number of students to student list
        /// </summary>
        /// <param name="students">Students to add</param>
        public void AddStudents(Student[] students) {
            int length = _studentList.Length;
            Array.Resize(ref _studentList, _studentList.Length + students.Length);
            for (int i = 0, j = length; i < students.Length; i++, j++)
            {
                _studentList[j] = students[i];
            }
        }
        /// <summary>
        /// Get string representation of all class data
        /// </summary>
        /// <returns>Formatted data string</returns>
        public override string ToString()
        {
            string[] studentList = new string[Students.Length];
            for (int i = 0; i < Students.Length; i++) studentList[i] = i+1 + ". " + Students[i].ToShortString();
            return $"Group name: {_name}, year of formation: {_formationYear}.\nList of students:{(_studentList.Length == 0 ? " (empty)" : Environment.NewLine + String.Join("\n", studentList))}";
        }
        /// <summary>
        /// Get single string containing first and last names only
        /// </summary>
        /// <returns>Shoft data string</returns>
        public virtual string ToShortString()
        {
            return $"Group name: {_name}, year of formation: {_formationYear}, number of students: {_studentList.Length}";
        }
    }
}
