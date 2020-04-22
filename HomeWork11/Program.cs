using System;

namespace HomeWork11
{
    class Program
    {
        static void Main(string[] args)
        {
			Student student = new Student();
			HeadOfDepartment headOfDepartment = new HeadOfDepartment();
			var equals = headOfDepartment.Equals(student);

			Console.WriteLine(equals);




		}
    }
    public abstract class Person
    {
        public abstract void Work();
        public string Name { get; set; }
		public string Surname { get; set; }
		public string Department { get; set; }

    }

	public class Student : Person
	{
		public override void Work()
		{
            Console.WriteLine("Я студент");
		}
	}
	public class Teacher: Person
	{
		public override void Work()
		{
			Console.WriteLine("Я преподаватель");
		}
	}
	public class HeadOfDepartment : Person
	{
		public override void Work()
		{
			Console.WriteLine("Я заведующий");
		}
		public override bool Equals(object obj)
		{
			if (obj.GetType() != this.GetType()) return false;

			Person person = (Person)obj;
			return this.Name == person.Name;
		}
	}
}