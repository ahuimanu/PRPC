using System;
using PRPCRepositoryLib.Models;

namespace PRPCRepositoryLib
{
    public class PRPCRepository
    {

        public PRPCRepositoryDbContext Context {get; set;}

        public PRPCRepository()
        {
            Context = new PRPCRepositoryDbContext();
        }

        public string Hello()
        {
            return "Hello World from PRPCRepository";
        }
    }
}
