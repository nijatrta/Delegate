namespace StudentFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
           {
               new Student {Name="Elnur", Grade=85, Age=19},
               new Student {Name="Aysel", Grade=90, Age=21},
               new Student {Name="Semaye", Grade=65, Age=18},
               new Student {Name="Namiq", Grade=75, Age=20},
               new Student {Name="Azer", Grade=55, Age=22},
               new Student {Name="Leyla", Grade=95, Age=17},
               new Student {Name="Kamran", Grade=45, Age=23},
           };

            Predicate<Student> gradePredicate = s => s.Grade > 70;
            Predicate<Student> agePredicate = s => s.Age < 20;
            Predicate<Student> namePredicate = s => s.Name.StartsWith("A");

            Func<Student, string> studentInfo = s => $"Name: " +
            $"{s.Name}, Age: " +
            $"{s.Age}, Grade: " +
            $"{s.Grade}";

            Action<List<Student>> print = s =>
            {
                if (s.Count == 0)
                {
                    Console.WriteLine("Melumat yoxdur");
                    return;
                }
                foreach (var student in s)
                {
                    Console.WriteLine(studentInfo(student));
                }
            };
            Console.WriteLine("Qiymeti 70-den yuxari olan telebeler:");
            print(Filter(students, gradePredicate));
            Console.WriteLine("\nYashi 20-den kicik olan telebeler:");
            print(Filter(students, agePredicate));
            Console.WriteLine("\nAdi 'A' herfi ile baslayan telebeler:");
            print(Filter(students, namePredicate));


        }
        static List<Student> Filter(
            List<Student> list,
            Predicate<Student> predicate)
        {
            return list.Where(s => predicate(s)).ToList();
        }
    }
   
}
