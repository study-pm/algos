using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Group
    {
        private string _name;
        private int _formationYear;
        private Student[] _studentList = Array.Empty<Student>();
        public Group(string name, int formationYear)
        {
            _name = name;
            _formationYear = formationYear;
        }
        public Group()
        {
            _name = "DefaultGroup";
            _formationYear = DateTime.Now.Year;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Year
        {
            get { return _formationYear; }
            set {_formationYear = value; }
        }
        public Student[] Students
        {
            get { return _studentList; }
            set { _studentList = value; }
        }
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
        public void AddStudents(Student[] students) {
            int length = _studentList.Length;
            Array.Resize(ref _studentList, _studentList.Length + students.Length);
            for (int i = 0, j = length; i < students.Length; i++, j++)
            {
                _studentList[j] = students[i];
            }
        }
        public override string ToString()
        {
            string[] studentList = new string[Students.Length];
            for (int i = 0; i < Students.Length; i++) studentList[i] = i+1 + ". " + Students[i].ToShortString();
            return $"Group name: {_name}, year of formation: {_formationYear}.\nList of students:{(_studentList.Length == 0 ? " (empty)" : Environment.NewLine + String.Join("\n", studentList))}";
        }
        public virtual string ToShortString()
        {
            return $"Group name: {_name}, year of formation: {_formationYear}, number of students: {_studentList.Length}";
        }
    }
}
