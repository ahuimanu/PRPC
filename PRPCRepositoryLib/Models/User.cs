using System;

namespace PRPCRepositoryLib.Models
{
    public class User
    {
        public int UserID {get; set;}
        public string RequestId { get; set; }
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Password {get; set;}
        public string Email {get; set;}
        public string PhoneNumber {get; set;}
    }
}