using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLAB.Models
{
    public class SalaryEmployee
    {
        public string IDEmp { get; set; }
        public string NameEmp { get; set; }
        public double? TotalHours { get; set; }
        public int? Rewards { get; set; }
        public int? TotalSalary { get; set; }
    }
}
