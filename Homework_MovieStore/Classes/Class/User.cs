using Classes.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Class
{
    public class User : Member
    {
        public int MemberNumber { get; set; }
        public SubscriptionType TypeOfSubscription { get; set; }

        public List<Movie> Movies { get; set; }


        public User(int id, SubscriptionType subscr, List<Movie> movies, string name, string surname, string username, string pass) : base(Roles.User)
        {
            MemberNumber = id;
            TypeOfSubscription = subscr;
            Movies = movies;
            FirstName = name;
            LastName = surname;
            UserName = username;
            Password = pass;
            Role = Roles.User;
        }

        public void Login(User user, List<User> members)
        {
            if (members.IndexOf(user) != -1)
            {
                IsLogedIn = true;
                Console.WriteLine($"Welcome {user.FirstName}");
            }
        }

        public void RentMovie(Movie film, User user, List<Movie> allrented, List<User> members)
        {

            if (members.IndexOf(user) != -1)
            {
                if (user.IsLogedIn == true)
                {
                    int index = allrented.IndexOf(film);
                    if (index == -1)
                    {
                        user.Movies.Add(film);
                        allrented.Add(film);
                    }
                    else
                    {
                        Console.WriteLine($"The movie {film.Title} is not avaliable");
                    }
                }
                else
                {
                    Console.WriteLine($"You are not logged in");
                }
            }
            else
            {
                Console.WriteLine($"The user with ID number {user.MemberNumber} does not exist anymore");
            }
        }

        public void SeeInfo(User user, List<User> members)
        {

            if (members.IndexOf(user) != -1)
            {
                if (user.IsLogedIn == true)
                {
                    DateTime now = DateTime.Today;
                    double daysLeft;
                    Console.WriteLine($"Type of subscription: {user.TypeOfSubscription}");
                    switch (user.TypeOfSubscription)
                    {
                        case SubscriptionType.Monthly:
                            daysLeft = 30 - now.Subtract(user.DateOfRegistration).TotalDays;
                            if (daysLeft > 0)
                                Console.WriteLine($"Your membership expires in {daysLeft} days!");
                            else Console.WriteLine($"Your membership has expired");
                            break;
                        case SubscriptionType.Annually:
                            daysLeft = 365 - now.Subtract(user.DateOfRegistration).TotalDays;
                            if (daysLeft > 0)
                                Console.WriteLine($"Your membership expires in {daysLeft} days!");
                            else Console.WriteLine($"Your membership has expired");
                            break;
                        default:
                            daysLeft = 3650 - now.Subtract(user.DateOfRegistration).TotalDays;
                            if (daysLeft > 0)
                                Console.WriteLine($"Your membership expires in {daysLeft} days!");
                            else Console.WriteLine($"Your membership has expired");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"You are not logged in");
                }
            }
            else
            {
                Console.WriteLine($"The user with ID number {user.MemberNumber} does not exist anymore");
            }

        }

        public void SeeRented(User user, List<User> members)
        {
            if (members.IndexOf(user) != -1)
            {
                if (user.IsLogedIn == true)
                {
                    Console.WriteLine("List of movies you have to return:");
                    foreach (Movie film in user.Movies)
                    {
                        Console.WriteLine(film.Title);
                    }
                }
                else
                {
                    Console.WriteLine($"You are not logged in");
                }
            }
            else
            {
                Console.WriteLine($"The user with ID number {user.MemberNumber} does not exist anymore");
            }

        }
    }
}
