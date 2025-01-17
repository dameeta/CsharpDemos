namespace OopsDemo
{
    internal class Oopsr
    {
        class Student
        {
            public int Id = 223;
            public string Name = "Swami Saranam";
            public string course = "Oracle";

            public Student()
            {
                Console.WriteLine("Default constructor");
            }
            public Student(int id, string name, string course)
            {
                this.Id = id;
                this.Name = name;
                this.course = course;

            }
            public Student(int id, string name)
            {
                this.Id=id;
                this.Name = name;

            }

            public Student(string name,string course)
            { this.Name = name;
              this.course = course;

             }


            public void getDetailsofStudent()
            {
                Console.WriteLine("id is :" + Id);
                Console.WriteLine("Name is :" + Name);
                Console.WriteLine("couurse is :" + course);

            }
            public void Attendexam()
            { Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine();
            Student student = new Student();
            student.getDetailsofStudent();
            Student student1 = new Student(1001, "Krishna", "Veda");
            student1.getDetailsofStudent();
            Student student2 = new Student(201, "Ram");
            student2.getDetailsofStudent();
            Student student3 = new Student("Hari", "Java");
             student3.getDetailsofStudent();


            }
    }
}
