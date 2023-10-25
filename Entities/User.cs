using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MenagmentSystem.Entities
{
    public class User : IdentityUser
    {
        public int AddressId { get; set; }
        public double Amount { get; set; }
        public string ProfilPicture { get; set; }
        public string City { get; set; }

        [ForeignKey(nameof(AddressId))]
       /* public Address Address { get; set; }*/
        public string Address { get; set; }
        public ICollection<Lecturers> Lecturers { get; set; }
        public int Age { get; internal set; }
        public string LastName { get; internal set; }
        public string Name { get; internal set; }
        
    }
}
