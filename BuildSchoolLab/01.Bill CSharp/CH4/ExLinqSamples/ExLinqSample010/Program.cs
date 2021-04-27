using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample010
{
    class Program
    {
        static void Main(string[] args)
        {
            var teachers = CreateTeachers();
            var students = CreateStudents();
            var result =
                from t in teachers
                join s in students
                on t.ClassName equals s.ClassName
                select
                new ResultInfo { ClassName = t.ClassName, Teacher = t.Teacher, Student = s.Student };

            foreach (var item in result)
            {
                Console.WriteLine($"{item.ClassName}:{item.Teacher, 10}:{item.Student.PadLeft (GetWidth(item.Student, 10), '0')}");
            }

            Console.ReadLine();
        }

        private static int GetWidth(string student, int length)
        {          
            return length - student.Length;
        }

        static List<TeacherInfo> CreateTeachers()
        {
            var list = new List<TeacherInfo>()
            {
            new TeacherInfo () { ClassName ="1A" , Teacher ="Bill" },
            new TeacherInfo () {ClassName ="1B", Teacher ="David" }
            };
            return list;
        }

        static List<StudentInfo> CreateStudents()
        {
            var list = new List<StudentInfo>()
            {
            new StudentInfo () { ClassName ="1A" , Student ="魯夫" },
            new StudentInfo () { ClassName ="1A" , Student ="索隆" },
            new StudentInfo () {ClassName ="1B", Student  ="櫻木" },
            new StudentInfo () { ClassName ="1A" , Student ="香吉士" },
            new StudentInfo () {ClassName ="1B", Student  ="流川楓" }
            };
            return list;
        }
    }

      
}
