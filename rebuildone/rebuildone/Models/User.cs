using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace rebuildone.Models
{
  public class User : Microsoft.AspNetCore.Identity.IdentityUser
    {
        public string Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interest { get; set; }
        public string City { get; set; }
        public ICollection<Photos> Photos { get; set; }
        public User()
        {
            Photos = new Collection<Photos>();
        }
  }

}
