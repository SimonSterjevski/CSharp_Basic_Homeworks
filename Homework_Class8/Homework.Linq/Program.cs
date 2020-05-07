using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework.Linq
{
	public class Person
	{
		public Person(string firstName, string lastName, int age, char gender)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			Gender = gender;
		}

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }

		public char Gender { get; set; }

	}
	class Program
	{
		static void Main(string[] args)
		{

			List<Person> people = new List<Person>()
			{
			new Person("Bill", "Smith", 41, 'M'),
			new Person("Sarah", "Jones", 22, 'F'),
			new Person("Stacy","Baker", 21, 'F'),
			new Person("Vivianne","Dexter", 19, 'F' ),
			new Person("Bob","Smith", 49, 'M' ),
			new Person("Brett","Baker", 51, 'M' ),
			new Person("Mark","Parker", 19, 'M'),
			new Person("Alice","Thompson", 18, 'F'),
			new Person("Evelyn","Thompson", 58, 'F' ),
			new Person("Mort","Martin", 58, 'M'),
			new Person("Eugene","deLauter", 84, 'M' ),
			new Person("Gail","Dawson", 19, 'F' ),
			};

			// Task 01
			// all people aged 50 or more
			List<Person> olderThan50 = people
									   .Where(person => person.Age >= 50)
									   .ToList();
			olderThan50.ForEach(person => Console.WriteLine($"{person.FirstName} {person.LastName} age:{person.Age} gender:{person.Gender}"));
			Console.WriteLine("-----------------------------------------");

			// Task 02
			// all people name starts with B
			List<Person> nameStartsWithB = people
										   .Where(person => person.FirstName.StartsWith('B'))
										   .ToList();
			nameStartsWithB.ForEach(person => Console.WriteLine($"{person.FirstName} {person.LastName} age:{person.Age} gender:{person.Gender}"));
			Console.WriteLine("-----------------------------------------");

			// Task 03
			// first person whose surname starts with T
			Person firstSurnameWithT = people
									   .Where(person => person.LastName.StartsWith('T'))
									   .First();
			Console.WriteLine($"{firstSurnameWithT.FirstName} {firstSurnameWithT.LastName} age:{firstSurnameWithT.Age} gender:{firstSurnameWithT.Gender}");
			Console.WriteLine("-----------------------------------------");

			// Task 04
			// find youngest and oldest person
			//List<Person> sortedByAge = people
			//						   .OrderBy(person => person.Age)
			//						   .ToList();
			//Console.WriteLine($"{sortedByAge.First().FirstName} {sortedByAge.First().LastName} " +
			//	$"age:{sortedByAge.First().Age} gender:{sortedByAge.First().Gender}");
			//Console.WriteLine($"{sortedByAge.Last().FirstName} {sortedByAge.Last().LastName} " +
			//	$"age:{sortedByAge.Last().Age} gender:{sortedByAge.Last().Gender}");
			Person youngestPerson = people
									   .OrderBy(person => person.Age)
									   .First();
			Console.WriteLine($"{youngestPerson.FirstName} {youngestPerson.LastName} age:{youngestPerson.Age} gender:{youngestPerson.Gender}");
			Console.WriteLine("-----------------------------------------");
			Person oldestPerson = people
									   .OrderByDescending(person => person.Age)
									   .First();
			Console.WriteLine($"{oldestPerson.FirstName} {oldestPerson.LastName} age:{oldestPerson.Age} gender:{oldestPerson.Gender}");
			Console.WriteLine("-----------------------------------------");

			// Task 05
			// find all male people aged 45 or more
			List<Person> allMaleOver45 = people
										 .Where(person => person.Gender == 'M' && person.Age >= 45)
										 .ToList();
			allMaleOver45.ForEach(person => Console.WriteLine($"{person.FirstName} {person.LastName} age:{person.Age} gender:{person.Gender}"));
			Console.WriteLine("-----------------------------------------");

			// Task 06
			// find all females whose name starts with V
			List<Person> allFemaleNameWithV = people
											  .Where(person => person.Gender == 'F' && person.FirstName.StartsWith('V'))
											  .ToList();
			allFemaleNameWithV.ForEach(person => Console.WriteLine($"{person.FirstName} {person.LastName} age:{person.Age} gender:{person.Gender}"));
			Console.WriteLine("-----------------------------------------");

			// Task 07
			// find last female person older than 30 whose name starts with p
			Person lastFemaleOver30NameWithP = people
											   .Where(person => person.Gender == 'F' && person.Age > 30 && person.FirstName.StartsWith('P'))
											   .LastOrDefault();
			Console.WriteLine(lastFemaleOver30NameWithP == null ? "No such person found" : $"{lastFemaleOver30NameWithP.FirstName} {lastFemaleOver30NameWithP.LastName} " +
				$"age: {lastFemaleOver30NameWithP.Age} gender:{lastFemaleOver30NameWithP.Gender}");
			Console.WriteLine("-----------------------------------------");

			// Task 08
			// find first male younger than 40
			Person firstMaleBellow40 = people
									   .Where(person => person.Gender == 'M' && person.Age < 40)
									   .FirstOrDefault();
			Console.WriteLine(firstMaleBellow40 == null ? "No such person found" : $"{firstMaleBellow40.FirstName} " +
				$"{firstMaleBellow40.LastName} age:{firstMaleBellow40.Age} gender:{firstMaleBellow40.Gender}");
			Console.WriteLine("-----------------------------------------");

			// Task 09
			// print the names of the male persons that have firstName longer than lastName
			List<string> maleWithLongerFirstName = people
												   .Where(person => person.Gender == 'M' && person.FirstName.Length > person.LastName.Length)
												   .Select(person => person.FirstName)
												   .ToList();
			if (maleWithLongerFirstName.Count > 0)
			{
				maleWithLongerFirstName.ForEach(Console.WriteLine);
			} else
			{
				Console.WriteLine("No such person found");
			}
			Console.WriteLine("-----------------------------------------");

			// Task 10
			// print the lastNames of the female persons that have odd number of ages
			List<string> femaleWithOddNumberOfAge = people
													.Where(person => person.Gender == 'F' && person.Age % 2 != 0)
													.Select(person => person.LastName)
													.ToList();
			if (femaleWithOddNumberOfAge.Count > 0)
			{
				femaleWithOddNumberOfAge.ForEach(Console.WriteLine);
			}
			else
			{
				Console.WriteLine("No such person found");
			}
			Console.WriteLine("-----------------------------------------");
			Console.ReadLine();
		}
	}
}
