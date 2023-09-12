using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    internal class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public PersonModel()
        {
            
        }

        public PersonModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }


        public PersonModel(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public void GenerateEmail()
        {
            Email = $"{FirstName}.{LastName}@aol.com";
        }

        public void GenerateEmail(string domain) 
        {
            GenerateEmail("aol.com", false);
        }

        public void GenerateEmail(bool firstInitialMethod)
        {
            GenerateEmail("aol.com", firstInitialMethod);
            
        }

        public void GenerateEmail(string domain, bool firstInitialMethod)
        {
            if (firstInitialMethod)
            {
                Email = $"{FirstName.Substring(0, 1)}.{LastName}@{domain}";
            }
            else
            {
                Email = $"{FirstName}.{LastName}@{domain}";
            }

        }


    }
}
