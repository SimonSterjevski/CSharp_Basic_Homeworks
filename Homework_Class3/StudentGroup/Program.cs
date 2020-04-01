using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = { "Mark", "Joe", "Rudy", "Bob", "Bam" };
            string[] studentsG2 = { "Damjan", "Jovan", "Robert", "Petar", "Branko" };
            Console.WriteLine("Please enter the student group (1 or 2)");
            string groupNumber = Console.ReadLine();

            if (groupNumber == "1")
            {
                Console.WriteLine("Students in group 1 are:");
                for (int i = 0; i < studentsG1.Length; i++)
                {
                    Console.WriteLine(studentsG1[i]);
                }
            } else if (groupNumber == "2")
            {
                Console.WriteLine("Students in group 2 are:");
                for (int j = 0; j < studentsG2.Length; j++)
                {
                    Console.WriteLine(studentsG2[j]);
                }
            } else
                {
                    Console.WriteLine("There are no student in the group you entered");
                }
            Console.ReadLine();
        }
        }
    }

