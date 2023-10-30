using System;
using System.Collections;
using System.Collections.Generic;

namespace _9section1._7
{
	class Program
	{
		static void Main(string[] args)
		{
			runApp();
			Console.ReadLine();
		}

		public static void runApp()
		{

			string[] arrSubjects = { "English Literature", "English Language", "Maths", "Geography", "History", "Physics", "Chemistry", "Biology" };
			string[] arrSubjectShorts = { "ELIT", "ELANG", "MATH", "GEOG", "HIST", "PHY", "CHEM", "BIO" };


			string[] arrStudents = { "Rahul Gandhi", "Vijay Mallya", "Lady Gaga", "Arun Jaitley", "MS Dhoni", "Kim Kardashian" };
			List<Student> listStudents = new List<Student>();
			List<Subject> listSubjects = new List<Subject>();

			for (int i = 0; i < arrSubjects.Length; i++)
			{
				Subject subject = new Subject();
				subject.Name = arrSubjects[i];
				subject.ShortName = arrSubjectShorts[i];
				listSubjects.Add(subject);
			}

			for (int i = 0; i < arrStudents.Length; i++)
			{
				Student student = new Student();
				student.Name = arrStudents[i];
				student.Address = "Some address";
				student.ContactNumber = "124567";
				student.GuardianName = "ramu";
				listStudents.Add(student);
			}

			Teacher classTeacher = new Teacher();
			classTeacher.Name = "Mr.Shyam";
			classTeacher.DateOfJoining = Convert.ToDateTime("2010-09-11 00:00:00");
			classTeacher.ContactAddress = "Some address";

			CClass class1A = new CClass();
			class1A.Name = "1A";
			class1A.Students = listStudents;
			class1A.Subjects = listSubjects;
			class1A.ClassTeacher = classTeacher;
			foreach (Student student in listStudents) 
			{ Console.WriteLine(student.Name); 
			  Console.WriteLine(student.ContactNumber);
			  Console.WriteLine(student.GuardianName);

			}
		}
	}
}
