using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkTest.Data;

namespace EntityFrameworkTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentsDB())
            {
                var students_count = db.Students.Count();
                Console.WriteLine("Количество студентов в БД {0}", students_count);
            }

            using (var db = new StudentsDB())
                if (db.Groups.Count() == 0)
                {
                    var students_n = 1;
                    for (var i = 1; i <= 10; i++)
                    {
                        var group = new Group
                        {
                            Name = $"Группа {i}",
                            Students = new List<Student>()
                        };

                        for (var j = 0; j < 10; j++)
                        {
                            var student = new Student
                            {
                                Name = $"Имя {students_n}",
                                SurName = $"Фамилия {students_n}",
                                Patronymic = $"Отчество {students_n}",
                                Birthday = DateTime.Now.Subtract(TimeSpan.FromDays(365 / 4 * (students_n + 10)))
                            };
                            students_n++;

                            group.Students.Add(student);
                        }

                        db.Groups.Add(group);
                    }

                    db.SaveChanges();
                }

            using (var db = new StudentsDB())
            {
                var students_count = db.Students.Count();
                Console.WriteLine("Количество студентов в БД {0}", students_count);
            }

            Console.ReadLine();
        }
    }
}
