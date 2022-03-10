using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomapperEx.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public string UserName{ get; set; }
        public string Password{ get; set; }
        public string JobExpression{ get; set; }
        public string Email{ get; set; }
        public string Adress{ get; set; }
        public string University{ get; set; }
        public List<Firm> WorkedFirms { get; set; }
    }
}
