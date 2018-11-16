using System;

namespace PRPCRepository.Models
{
    public class User
    {
        public int UserID {get; set;}
        public string RequestId { get; set; }
        public string firstName {get; set;}
        public string lastName {get; set;}
        public string password {get; set;}
        public string email {get; set;}
        public int phoneNumber {get; set;}
    }
}