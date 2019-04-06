using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Subject> Subjects = new List<Subject>
            {
               new Subject("C#"),
               new Subject("C#Advanced"),
               new Subject("JavaScript"),
               new Subject("HTML"),
               new Subject("JavaScriptAdvanced")
            };

            var subjectGrades = new Dictionary<Subject, int>()
            {
                [Subjects[0]] = 3,
                [Subjects[2]] = 5,
                [Subjects[3]] = 4,
                [Subjects[4]] = 5,

            };
            var subjectGrades1 = new Dictionary<Subject, int>()
            {
                [Subjects[4]] = 1,
                [Subjects[2]] = 2,

            };
            var subjectGrades2 = new Dictionary<Subject, int>()
            {
                [Subjects[4]] = 5,
                [Subjects[2]] = 2,
                [Subjects[0]] = 4,
                [Subjects[1]] = 3,

            };

            List<Person> users = new List<Person>
            {
                new Student("Goran","Kuzmanoski","goki_pp","goki",Subjects[1],subjectGrades ),
                new Student("Jovan","Jovannoski","jovan","joco",Subjects[0],subjectGrades1 ),
                new Student("Vladimir","Poposki","vlado","vlade",Subjects[3],subjectGrades2 ),
                new Trainer("Trajan","Stevkoski","Trajan","12345"),
                new Admin("Wekoslav", "Stefanoski","weko","1x29")
            };
            while (true)
            {

                #region Login
                Person User;
                while (true)
                {
                    Console.WriteLine("Enter username");
                    string inputUsername = Console.ReadLine();
                    User = users.Where(x => x.Username == inputUsername).FirstOrDefault();
                    if (User == null)
                    {
                        Console.WriteLine("Try again");
                        continue;
                    }
                    Console.WriteLine("Enter Password");
                    string inputPassword = Console.ReadLine();
                    if (User.ValidPassword(inputPassword))
                    {
                        Console.WriteLine("Correct password");
                        break;
                    }
                    else
                    {

                        continue;
                    }
                }

                #endregion
                #region Admin
                while (true)
                {

                    if (User.Role == Role.Admin)
                    {
                        Console.WriteLine("1.Add; 2.Remove");
                        string adminOption = Console.ReadLine();

                        while (adminOption == "1")
                        {
                            Console.WriteLine("1.Add trainer; 2.Add admin; 3.Add student");
                            string addOption = Console.ReadLine();
                            while (addOption == "1")
                            {
                                //adding trainer
                                Console.WriteLine("Enter trainer first name:");
                                string trainerName = Console.ReadLine();
                                Console.WriteLine("Enter trainer last name:");
                                string trainerLastName = Console.ReadLine();
                                Console.WriteLine("Enter trainer username:");
                                string trainerUsername = Console.ReadLine();
                                Console.WriteLine("Enter trainer password:");
                                string trainerPassword = Console.ReadLine();
                                users.Add(new Trainer(trainerName, trainerLastName, trainerUsername, trainerPassword));
                                Console.WriteLine($"You added new trainer {trainerName} , {trainerLastName}");
                                Console.WriteLine($"-----------------------");
                                Console.WriteLine($"Do you want to add another trainer Y/N");
                                string addTrainerCheck = Console.ReadLine().ToLower();
                                if (addTrainerCheck == "n")
                                {
                                    Console.WriteLine("Thank you for adding new trainer");
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            while (addOption == "2")
                            {
                                //adding admin
                                Console.WriteLine("Enter admin first name:");
                                string adminName = Console.ReadLine();
                                Console.WriteLine("Enter admin last name:");
                                string adminLastName = Console.ReadLine();
                                Console.WriteLine("Enter admin username:");
                                string adminUsername = Console.ReadLine();
                                Console.WriteLine("Enter admin password:");
                                string adminPassword = Console.ReadLine();
                                users.Add(new Admin(adminName, adminLastName, adminUsername, adminPassword));
                                Console.WriteLine($"You added new Admin {adminName} , {adminLastName}");
                                Console.WriteLine($"-----------------------");
                                Console.WriteLine($"Do you want to add another Admin Y/N");
                                string addAdminCheck = Console.ReadLine().ToLower();
                                if (addAdminCheck == "n")
                                {
                                    Console.WriteLine("Thank you for adding new admin");
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            while (addOption == "3")
                            {
                                //adding student
                                Console.WriteLine("Enter student first name:");
                                string studentName = Console.ReadLine();
                                Console.WriteLine("Enter student last name:");
                                string studentLastName = Console.ReadLine();
                                Console.WriteLine("Enter student username:");
                                string studentUsername = Console.ReadLine();
                                Console.WriteLine("Enter student password:");
                                string studentPassword = Console.ReadLine();

                                Console.WriteLine($"Choose current subject: ");
                                foreach (var subject in Subjects)
                                {
                                    Console.WriteLine(subject.Name);
                                }

                                string studentCurrentSubject = Console.ReadLine();
                                Subject studentCurrentSubject1 = new Subject(studentCurrentSubject);
                                if (studentCurrentSubject == "C#")
                                {
                                    studentCurrentSubject1 = Subjects[0];
                                }
                                else if (studentCurrentSubject == "C#Advanced")
                                {
                                    studentCurrentSubject1 = Subjects[1];
                                }
                                else if (studentCurrentSubject == "JavaScript")
                                {
                                    studentCurrentSubject1 = Subjects[2];
                                }
                                else if (studentCurrentSubject == "HTML")
                                {
                                    studentCurrentSubject1 = Subjects[3];
                                }
                                else if (studentCurrentSubject == "JavaScriptAdvanced")
                                {
                                    studentCurrentSubject1 = Subjects[4];
                                }

                                Console.WriteLine("Add passed subject");


                                foreach (var subject in Subjects)
                                {
                                    Console.WriteLine(subject.Name);
                                }

                                string studentPassedSubject = Console.ReadLine();
                                Console.WriteLine("Add grade");
                                int studentPassedSubjectGrade = int.Parse(Console.ReadLine());
                                Dictionary<Subject, int> NewSubjectGrades1 = new Dictionary<Subject, int>();
                                if (studentPassedSubject == "C#")
                                {
                                    Dictionary<Subject, int> NewSubjectGrades = new Dictionary<Subject, int>()
                                    {
                                        [Subjects[0]] = studentPassedSubjectGrade,
                                    };
                                    NewSubjectGrades1 = NewSubjectGrades;
                                }
                                else if (studentPassedSubject == "C#Advanced")
                                {
                                    Dictionary<Subject, int> NewSubjectGrades = new Dictionary<Subject, int>()
                                    {
                                        [Subjects[1]] = studentPassedSubjectGrade,
                                    };
                                    NewSubjectGrades1 = NewSubjectGrades;
                                }
                                else if (studentPassedSubject == "JavaScript")
                                {
                                    Dictionary<Subject, int> NewSubjectGrades = new Dictionary<Subject, int>()
                                    {
                                        [Subjects[2]] = studentPassedSubjectGrade,
                                    };
                                    NewSubjectGrades1 = NewSubjectGrades;
                                }
                                else if (studentPassedSubject == "HTML")
                                {
                                    Dictionary<Subject, int> NewSubjectGrades = new Dictionary<Subject, int>()
                                    {
                                        [Subjects[3]] = studentPassedSubjectGrade,
                                    };
                                    NewSubjectGrades1 = NewSubjectGrades;
                                }
                                else if (studentPassedSubject == "JavaScriptAdvanced")
                                {
                                    Dictionary<Subject, int> NewSubjectGrades = new Dictionary<Subject, int>()
                                    {
                                        [Subjects[4]] = studentPassedSubjectGrade,
                                    };
                                    NewSubjectGrades1 = NewSubjectGrades;
                                }
                                else
                                {
                                    Console.WriteLine("Try again!");
                                }
                                users.Add(new Student(studentName, studentLastName, studentUsername, studentPassword, studentCurrentSubject1, NewSubjectGrades1));
                                Console.WriteLine($"You added new student {studentName} {studentLastName}");
                                Console.WriteLine($"-----------------------");
                                Console.WriteLine($"Do you want to add another student Y/N");
                                string addStudentCheck = Console.ReadLine().ToLower();
                                if (addStudentCheck == "n")
                                {
                                    Console.WriteLine("Thank you for adding student");
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            Console.WriteLine($"-----------------------");
                            Console.WriteLine($"Do you want to choose another person(admin,trainer or student to add) Y/N");
                            string addMorePeople = Console.ReadLine().ToLower();
                            if (addMorePeople == "n")
                            {
                                Console.WriteLine("You choose not to add more people");
                                break;
                            }
                            else
                            {
                                continue;
                            }

                        }
                        while (adminOption == "2")
                        {
                            Console.WriteLine("1.Remove trainer; 2.Remove admin; 3.Remove student");
                            string removeOption = Console.ReadLine();

                            while (removeOption == "1")
                            {
                                //remove trainer
                                Console.WriteLine("Please enter the username of the trainer you want to remove:");
                                foreach (var user in users.Where(u => u.Role == Role.Trainer))
                                {
                                    Console.WriteLine($"Trainer first name: {user.Firstname} , trainer last name: {user.Lastname}");
                                }
                                string username = Console.ReadLine();
                                Person found = users.Where(x => x.Username == username).FirstOrDefault();
                                bool removed = users.Remove(found);
                                if (found != null && found.Role == Role.Trainer)
                                {
                                    users.Remove(users.Where(x => x.Username == username).FirstOrDefault());
                                }
                                if (removed) Console.WriteLine($"Trainer {found.Firstname} has been removed!");
                                else
                                {
                                    Console.WriteLine("There was no such user!");
                                    Console.WriteLine("Please try again");
                                    continue;
                                }
                                Console.WriteLine($"-----------------------");
                                Console.WriteLine($"Do you want to remove another trainer Y/N");
                                string removeTrainer = Console.ReadLine().ToLower();
                                if (removeTrainer == "n")
                                {
                                    Console.WriteLine("You choose not to remove more trainers");
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            while (removeOption == "2")
                            {
                                //remove admin
                                Console.WriteLine("Please enter the username of the admin you want to remove:");
                                foreach (var user in users.Where(u => u.Role == Role.Admin))
                                {
                                    Console.WriteLine($"Admin first name: {user.Firstname} , Admin last name: {user.Lastname}");
                                }
                                string username = Console.ReadLine();
                                Person found = users.Where(x => x.Username == username).FirstOrDefault();
                                bool removed = users.Remove(found);
                                if (found != null && found.Role == Role.Admin)
                                {
                                    users.Remove(users.Where(x => x.Username == username).FirstOrDefault());
                                }
                                if (removed) Console.WriteLine($"Admin {found.Firstname} has been removed!");
                                else
                                {
                                    Console.WriteLine("There was no such user!");
                                    Console.WriteLine("Please try again");
                                    continue;
                                }
                                Console.WriteLine($"-----------------------");
                                Console.WriteLine($"Do you want to remove another Admin Y/N");
                                string removeAdmin = Console.ReadLine().ToLower();
                                if (removeAdmin == "n")
                                {
                                    Console.WriteLine("You choose not to remove more admins");
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            while (removeOption == "3")
                            {
                                //remove student
                                Console.WriteLine("Please enter the username of the student you want to remove:");
                                foreach (var user in users.Where(u => u.Role == Role.Student))
                                {
                                    Console.WriteLine($"Student first name: {user.Firstname} , Student last name: {user.Lastname}");
                                }
                                string username = Console.ReadLine();
                                Person found = users.Where(x => x.Username == username).FirstOrDefault();
                                bool removed = users.Remove(found);
                                if (found != null && found.Role == Role.Student)
                                {
                                    users.Remove(users.Where(x => x.Username == username).FirstOrDefault());
                                }
                                if (removed) Console.WriteLine($"Student {found.Firstname} has been removed!");
                                else
                                {
                                    Console.WriteLine("There was no such user!");
                                    Console.WriteLine("Please try again");
                                    continue;
                                }

                                Console.WriteLine($"-----------------------");
                                Console.WriteLine($"Do you want to remove another student from this list: Y/N");
                                foreach (var user in users.Where(u => u.Role == Role.Student))
                                {
                                    Console.WriteLine($"Student first name: {user.Firstname} , Student last name: {user.Lastname}");
                                }
                                string removeStudent = Console.ReadLine().ToLower();
                                if (removeStudent == "n")
                                {
                                    Console.WriteLine("You choose not to remove more admins");
                                    break;
                                }
                                else
                                {
                                    continue;
                                }

                            }
                            Console.WriteLine($"-----------------------");
                            Console.WriteLine($"Do you want to remove more people Y/N");
                            string removePerson = Console.ReadLine().ToLower();
                            if (removePerson == "n")
                            {
                                Console.WriteLine("You choose not to remove more people(admin,student or trainer)");
                                break;
                            }
                            else
                            {
                                continue;
                            }


                        }
                        Console.WriteLine($"-----------------------");
                        Console.WriteLine($"Do you want to logout as admin Y/N");
                        string logOut = Console.ReadLine().ToLower();
                        if (logOut == "y")
                        {
                            Console.WriteLine("Please log in with another user");
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    #endregion
                #region Trainer

                    if (User.Role == Role.Trainer)
                    {
                        Trainer trainer = (Trainer)User;
                        Console.WriteLine("Choose an option 1.List all students; 2.List all subjects");
                        string trainerChoice = Console.ReadLine();

                        while (trainerChoice == "1")
                        {
                            Console.WriteLine("Choose a student to see his grades");
                            foreach (var user in users.Where(u => u.Role == Role.Student))
                            {
                                Console.WriteLine($"Student first name: {user.Firstname} , Student last name: {user.Lastname}");
                            }
                            string studentName = Console.ReadLine();
                            var found = users.Where(x => x.Firstname == studentName).FirstOrDefault();

                            if (found != null && found.Role == Role.Student)
                            {
                                Student choosenStudent = (Student)users.Where(x => x.Firstname == studentName).FirstOrDefault();
                                Console.WriteLine(choosenStudent.GetInfo());
                            }
                            Console.WriteLine($"-----------------------");
                            Console.WriteLine($"Do you want to choose another student to see his grades Y/N");
                            string seeMoreStudents = Console.ReadLine().ToLower();
                            if (seeMoreStudents == "n")
                            {
                                Console.WriteLine("You choose not to see more students");
                                break;
                            }
                            else
                            {
                                continue;
                            }

                        }
                        while (trainerChoice == "2")
                        {
                            //List all subjects
                            foreach (var subject in Subjects)
                            {
                                int studentsOfSubject = 0;
                                foreach (var user in users.Where(u => u.Role == Role.Student))
                                {
                                    Student currentStudent = (Student)user;
                                    if (subject == currentStudent.CurrentSubject)
                                    {
                                        studentsOfSubject += 1;
                                    }
                                }
                                Console.WriteLine($"Name of the subject: {subject.Name} ({studentsOfSubject}).");
                            }
                            Console.WriteLine($"-----------------------");
                            Console.WriteLine($"Do you want to go back one step  Y/N");
                            string back = Console.ReadLine().ToLower();
                            if (back == "y")
                            {
                                Console.WriteLine();
                                break;
                            }
                            else
                            {
                                continue;
                            }

                        }
                        Console.WriteLine($"-----------------------");
                        Console.WriteLine($"Do you want to logout as trainer Y/N");
                        string logOut = Console.ReadLine().ToLower();
                        if (logOut == "y")
                        {
                            Console.WriteLine("Please log in with another user");
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    #endregion
                #region User
                    if (User.Role == Role.Student)
                    {
                        Student student = (Student)User;
                        Console.WriteLine("1.Enroll; 2.List all grades");
                        string option = Console.ReadLine();

                        while (option == "1")
                        {
                            foreach (var subject in Subjects)
                            {
                                if (!student.Subjects.ContainsKey(subject))
                                {
                                    Console.WriteLine(subject.Name);
                                }
                            }

                            string chosenSubject = Console.ReadLine();
                            foreach (var subject in Subjects)
                            {
                                if (subject.Name == chosenSubject)
                                {
                                    Subject sub = Subjects.FirstOrDefault(x => x.Name == chosenSubject);
                                    student.Enroll(sub);
                                    //Subjects.Remove(subject);
                                    Console.WriteLine($"You enroled in {sub.Name}!");
                                }

                            }
                            Console.WriteLine($"-----------------------");
                            Console.WriteLine($"Do you want to enroll in more subjects Y/N");
                            string seeMoreStudents = Console.ReadLine().ToLower();
                            if (seeMoreStudents == "n")
                            {
                                Console.WriteLine("You choose not to enrol in more subjects");
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }

                        while (option == "2")
                        {
                            Console.WriteLine(student.GetInfo());
                            Console.WriteLine($"-----------------------");
                            Console.WriteLine($"do you want to choose different option Y/N");
                            string seeMoreStudents = Console.ReadLine().ToLower();
                            if (seeMoreStudents == "y")
                            {
                                Console.WriteLine("You choose to go back one step");
                                break;
                            }
                            else
                            {
                                continue;
                            }


                        }
                        Console.WriteLine($"-----------------------");
                        Console.WriteLine($"Do you want to log out as student Y/N");
                        string studentlogout = Console.ReadLine().ToLower();
                        if (studentlogout == "y")
                        {
                            Console.WriteLine("You loged out as student.");
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    #endregion
                }
            }
        }
           
    }
}

