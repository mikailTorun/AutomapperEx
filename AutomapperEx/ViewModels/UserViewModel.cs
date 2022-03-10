using AutomapperEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomapperEx.ViewModels
{
    public class UserViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobExpression { get; set; }
        public List<Firm> WorkedFirms { get; set; }
    }
}
