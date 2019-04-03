using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student : Person
    {
        public Subject CurrentSubject { get; set; }
        public Dictionary<Subject, int> Subjects { get; set; }

        public Student(string firstname,
            string lastname,
            string username,
            string password,
            Subject currentSubject,
            Dictionary<Subject, int> subjects)
            : base(firstname, lastname, username, password, Role.Student)
        {
            this.CurrentSubject = currentSubject;
            this.Subjects = subjects;
        }

        public void Enroll(Subject subject)
        {
            CurrentSubject = subject;
        }

        public string GetInfo()
        {
            string result = "";
            foreach (var item in Subjects)
            {
                result += $"Subject :{item.Key.Name}: Grade:{item.Value} \n";
            }
            return result;
        }
    }
}
