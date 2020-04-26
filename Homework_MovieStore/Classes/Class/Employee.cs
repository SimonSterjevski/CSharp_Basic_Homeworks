using Classes.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Class
{
    public class Employee : Member
    {
        private int Salary { get; set; }
        public int HoursPerMonth { get; set; }
        private int? Bonus { get; set; }
        public void SetBonus()
        {
            if (HoursPerMonth > 160)
            {
                Bonus = 30 / 100;
            }
            else
            {
                Bonus = null;
            }
        }
        public void SetSalary()
        {
            if (Bonus.HasValue)
            {
                Salary += HoursPerMonth * Bonus.Value;
            }
            else
            {
                Salary = Salary;
            }

        }
        public Employee(string name, string surname, string username, string pass) : base(Roles.Employee)
        {
            FirstName = name;
            LastName = surname;
            UserName = username;
            Password = pass;
            Role = Roles.Employee;

        }

        public void AddMember(User user, List<User> members)
        {
            DateTime now = DateTime.Today;
            members.Add(user);
            user.DateOfRegistration = now;
        }

        public void DeleteMember(User user, List<User> members)
        {
            foreach (Movie usermovies in user.Movies)
            {
                user.Movies.Remove(usermovies);
            }
            members.Remove(user);
        }

        public void SeeMembers(List<User> members)
        {
            Console.WriteLine("List od registered members:");
            foreach (User user in members)
            {
                Console.WriteLine($"{user.FirstName} {user.LastName} ID number: {user.MemberNumber}");
            }

        }

        public void SeeAvaliableMovies(Movie[] all, List<Movie> rented)
        {
            Console.WriteLine("List od avaliable movies:");
            foreach (Movie film in all)
            {
                int index = rented.IndexOf(film);
                if (index == -1)
                {
                    Console.WriteLine(film.Title);
                }
            }

        }

    }
}
