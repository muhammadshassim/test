using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTask1New
{
    class Module
    {

        [Required]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int CreditHours { get; set; }

        [Required]
        public int WeeklyClassHours { get; set; }

        [Required]
        public int NoOfWeeks { get; set; }

        public int OverallStudyHoursRemaining { get; set; }

        [Required]
        public DateTime ModuleStartDate { get; set; }


        public List<Log> AllMyLogs = new List<Log>();

        public bool TotalAlreadyCalculated { get; set; }
        // PROG =====> List<Log> AllMyLogs ==> Multiple logs
        // Bank Account ====> List<Transaction> History =====> Multiple payments or purchases
    }

}
