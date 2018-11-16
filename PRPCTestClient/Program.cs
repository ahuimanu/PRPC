using System;
using System.Linq;
using System.Collections.Generic;
using PRPCRepositoryLib;
using PRPCRepositoryLib.Models;

namespace PRPCTestClient
{
    class Program
    {
        static void Main(string[] args)
        {

            PRPCRepository repo = new PRPCRepository();

            using(repo.Context = new PRPCRepositoryDbContext())
            {

                repo.Context.Database.EnsureCreated();

                if(!repo.Context.Users.Any())
                {
                    List<User> users = new List<User>()
                    {
                        new User()
                        {
                            Email = "test@test.com",
                            FirstName = "Test1",
                            LastName = "Tester1",
                            Password = "secret1",
                            PhoneNumber = "808-555-5555",
                            RequestId = "stuff1"
                        },
                                                                                    
                    };
                    
                    repo.Context.Users.AddRange(users);  

                    repo.Context.SaveChanges();
                    
                } 
                else
                {
                    User user = new User();
                    user.Email = "test@test.com";
                    user.FirstName = "Test";
                    user.LastName = "Tester";
                    user.Password = "secret";
                    user.PhoneNumber = "808-555-5555";
                    user.RequestId = "stuff";

                    repo.Context.Users.Add(user);
                    repo.Context.SaveChanges();
                    Console.WriteLine(repo.Hello());                        

                }
            }
        }
    }
}
