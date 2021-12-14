using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RepairShop
{
    internal class Contacts
    {
        public string Name { get; set; }    
        public string LastName { get; set; }    
        public string Email { get; set; }   
        public string Number { get; set; }   
        public string Post { get; set; }
        public string Subdivision { get; set; }        
        public string Birth { get; set; }

        public Contacts(string name, string lastname, string email, string number, string post, string subdivision, string birth)
        {
            Name = name;
            LastName = lastname;
            Email = email;
            Number = number;
            Post = post;
            Subdivision = subdivision;
            Birth = birth;
        }
    }
}
