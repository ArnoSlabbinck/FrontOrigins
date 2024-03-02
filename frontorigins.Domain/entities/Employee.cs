using frontorigins.Domain.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Domain.entities
{
    public class Employee : BaseEntitiy
    {
        private string firstName { get; set; }

        private string lastName { get; set; }

        private string workEmail { get; set; }

        private string email { get; set; }

        private string bankAccountNumber { get; set; }

        private string identityNumber { get; set; }

        private string nationalRegisterNumber { get; set; }

        private string birthPlace { get; set; }


        private string mobilePhone { get; set; }

        private string workPhone { get; set; }

        private DateTime birthDate { get; set; }

        private string nationality { get; set; }

        private string gender { get; set; }

        private double salary { get; set; }

        private DateTime employmentBeginDate { get; set; }

        private DateTime? employementEndDate { get; set; }

        private string status { get; set; }

        private string driverLicense { get; set; }

        private bool isCandidate { get; set; } = false;

        private bool isConsultant { get; set; } = false;

        private bool isEmployed
        {
            get
            {
                if (employementEndDate == null)
                    return true;
                return false;
            }
        }


        private Location address { get; set; }

        private ICollection<Timesheet> timesheets { get; set; }

        private Departement departement { get; set; }

        private Job Job { get; set; }

        private ICollection<JobHistory> jobHistories { get; set; }

        private ICollection<Language> languages { get; set; }

        private LendingEquitment lendingEquitment { get; set; }

        private ICollection<Education> Degrees { get; set; }

        public Employee() { }
    }

    
}
