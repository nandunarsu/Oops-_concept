using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    class Baseclass
    {
    
        string Name { get; }
        string Email { get; }
        public Baseclass(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
