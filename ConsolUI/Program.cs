using System;
using Business.Concrete;
using DataAccess.Concrete.Entity_Framework;
using Entities.Concrete;

namespace ConsolUI
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new EfUserDal());

            userManager.Add(new User()
            {
                
                TelephoneNumber = "53847763"
            });
        }
    }
}
