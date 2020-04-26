using Classes.Class;
using Classes.Enum;
using System;
using System.Collections.Generic;

namespace MovieApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie gladiator = new Movie("Gladiator", "Epic historical action drama", 2000, MovieGenre.Historical);
            Movie theBestOffer = new Movie("The Best Offer", "Italian psychological thriller", 2013, MovieGenre.Thriller);
            Movie theNakedGun = new Movie("The Naked Gun", "Crime comedy film", 1988, MovieGenre.Comedy);
            Movie theSunsetLimited = new Movie("The Sunset Limited", "Philosophical drama", 2011, MovieGenre.Drama);
            Movie braveheart = new Movie("Braveheart", "Epic war drama", 1995, MovieGenre.Historical);
            Movie interstellar = new Movie("Interstellar", "Epic sciense fiction", 2014, MovieGenre.ScienceFiction);
            Movie[] allMovies = { gladiator, theBestOffer, theNakedGun, theSunsetLimited, braveheart, interstellar };
            List<Movie> rentedMovies = new List<Movie> { };
            List<User> registeredMembers = new List<User> { };
            User user1 = new User(1, SubscriptionType.GoldenMember, new List<Movie> { }, "Toni", "Kukoc", "toni", "tk");
            User user2 = new User(2, SubscriptionType.Monthly, new List<Movie> { }, "Dino", "Radza", "dino", "dr");
            User user3 = new User(3, SubscriptionType.Annually, new List<Movie> { }, "Arijan", "Komazec", "arijan", "ak");
            Employee employee1 = new Employee("Goran", "Goranov", "goran", "gg");

            employee1.AddMember(user1, registeredMembers);
            employee1.AddMember(user2, registeredMembers);
            employee1.AddMember(user3, registeredMembers);
            //employee1.DeleteMember(user2, registeredMembers);
            employee1.SeeMembers(registeredMembers);
            Console.WriteLine("----------------");
            user2.Login(user2, registeredMembers);
            Console.WriteLine("----------------");
            user3.Login(user3, registeredMembers);
            user2.RentMovie(braveheart, user2, rentedMovies, registeredMembers);
            user3.RentMovie(gladiator, user3, rentedMovies, registeredMembers);
            user3.RentMovie(theNakedGun, user3, rentedMovies, registeredMembers);
            Console.WriteLine("----------------");
            user3.RentMovie(braveheart, user3, rentedMovies, registeredMembers);
            Console.WriteLine("----------------");
            employee1.SeeAvaliableMovies(allMovies, rentedMovies);
            Console.WriteLine("----------------");
            user3.SeeInfo(user3, registeredMembers);
            Console.WriteLine("----------------");
            user3.SeeRented(user3, registeredMembers);
            Console.WriteLine("----------------");
            user1.SeeRented(user1, registeredMembers);
            Console.ReadLine();
        }
    }
}
