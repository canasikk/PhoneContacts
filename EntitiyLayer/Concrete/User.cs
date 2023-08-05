using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class User
    {
        [Key]
        public int UUID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public int PhoneNumber { get; set; }
        public string EMail { get; set; }
        public string Location { get; set; }
    }
}
