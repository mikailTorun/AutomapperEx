using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomapperEx.Models
{
    public class Firm
    {
        public int Id { get; set; }
        public string FirmName{ get; set; }
        public string TaxNumber{ get; set; }
        public string Adress{ get; set; }
        public int PersonCount{ get; set; }
        public List<Employee> Employee { get; set; }
    }
}