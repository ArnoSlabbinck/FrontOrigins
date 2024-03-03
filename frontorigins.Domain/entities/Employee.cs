using frontorigins.Domain.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Domain.entities
{
    public class Employee : BaseEntity
    {
        private string firstName;

        private string lastName;

        private string workEmail;

        private string email;

        private string bankAccountNumber;

        private string identityNumber;

        private string nationalRegisterNumber;

        private string birthPlace;


        private string mobilePhone;

        private string workPhone;

        private DateTime birthDate;

        private string nationality;
        private string gender;

        private DateTime employmentBeginDate;

        private DateTime? employementEndDate;

        private string status;

        private string driverLicense;

        private bool isCandidate;
        private bool isConsultant;


        private Location address;

        private ICollection<Timesheet> timesheets;

        private Departement departement;

        private Position Job;

        private ICollection<JobHistory> previousJobs;

        private LendingEquipment lendingEquitment;

        private ICollection<Education> degrees;

        private ICollection<Language> languages;

        public Employee(long id) : base(id)
        {
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string WorkEmail { get => workEmail; set => workEmail = value; }
        public string Email { get => email; set => email = value; }
        public string BankAccountNumber { get => bankAccountNumber; set => bankAccountNumber = value; }
        public string IdentityNumber { get => identityNumber; set => identityNumber = value; }
        public string NationalRegisterNumber { get => nationalRegisterNumber; set => nationalRegisterNumber = value; }
        public string BirthPlace { get => birthPlace; set => birthPlace = value; }
        public string MobilePhone { get => mobilePhone; set => mobilePhone = value; }
        public string WorkPhone { get => workPhone; set => workPhone = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime EmploymentBeginDate { get => employmentBeginDate; set => employmentBeginDate = value; }
        public DateTime? EmployementEndDate { get => employementEndDate; set => employementEndDate = value; }
        public string Status { get => status; set => status = value; }
        public string DriverLicense { get => driverLicense; set => driverLicense = value; }
        public bool IsCandidate { get => isCandidate; set => isCandidate = value; }
        public bool IsConsultant { get => isConsultant; set => isConsultant = value; }
        public Location Address { get => address; set => address = value; }
        public ICollection<Timesheet> Timesheets { get => timesheets; set => timesheets = value; }
        public Departement Departement { get => departement; set => departement = value; }
        public Position Job1 { get => Job; set => Job = value; }
        public ICollection<JobHistory> PreviousJobs { get => previousJobs; set => previousJobs = value; }
        public LendingEquipment LendingEquitment { get => lendingEquitment; set => lendingEquitment = value; }
        public ICollection<Education> Degrees { get => degrees; set => degrees = value; }
        public ICollection<Language> Languages { get => languages; set => languages = value; }
    }

    
}
