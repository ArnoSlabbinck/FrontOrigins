using frontorigins.Domain.aggregates;
using frontorigins.Domain.common;
using System.ComponentModel.DataAnnotations;
using License = frontorigins.Domain.common.License;

namespace frontorigins.Domain.entities
{
    public class Employee : BaseEntity
    {
        [Required(ErrorMessage = "An Employee needs to have a firstname")]
        private string firstName;

        [Required(ErrorMessage = "An Employee needs to have ")]
        private string lastName;

        private string workEmail;

        private string email;


        private string bankAccountNumber;

        [Required(ErrorMessage = "An Employee needs to have an Identity Number")]
        private string identityNumber;

        [Required(ErrorMessage = "An Employee needs to have a national Register number")]
        private string nationalRegisterNumber;

        private string birthPlace;


        private string mobilePhone;

        private string workPhone;

        private DateTime birthDate;

        private string nationality;
        private string gender;

        private DateTime employmentBeginDate;

        private DateTime? employementEndDate;

        private WorkStatus workstatus;

        private License driverLicense = License.None;

        private bool isCandidate;
        private bool isConsultant;

        [Required(ErrorMessage = "An Employee needs an Address")]
        private Address address;

        private ICollection<Timesheet> timesheets;

        private Departement departement;

        private Position job;

        private ICollection<WorkExperience> previousJobs;

        private LendingEquipment lendingEquipement;

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
        public WorkStatus WorkStatus { get => workstatus; set => workstatus = value; }
        public License DriverLicense { get => driverLicense; set => driverLicense = value; }
        public bool IsCandidate { get => isCandidate; set => isCandidate = value; }
        public bool IsConsultant { get => isConsultant; set => isConsultant = value; }
        public Address Address { get => address; set => address = value; }
        public ICollection<Timesheet> Timesheets { get => timesheets; set => timesheets = value; }
        public Departement Departement { get => departement; set => departement = value; }
        public Position Job { get => job; set => job = value; }
        public ICollection<WorkExperience> Workexperiences { get => previousJobs; set => previousJobs = value; }
        public LendingEquipment LendingEquitment { get => lendingEquipement; set => lendingEquipement = value; }
        public ICollection<Education> Degrees { get => degrees; set => degrees = value; }
        public ICollection<Language> Languages { get => languages; set => languages = value; }
    }

   
}
