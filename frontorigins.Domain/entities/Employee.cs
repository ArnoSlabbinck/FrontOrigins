using frontorigins.Domain.aggregates;
using frontorigins.Domain.common;
using frontorigins.Domain.common.frontorigins.Domain.common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Domain.entities
{
    public class Employee : BaseEntity
    {
       
        private string firstName;

    
        private string lastName;

        private string workEmail;


        private string bankAccountNumber;

       
        private string identityNumber;

        private string nationalRegisterNumber;

        private string birthPlace;

        
        private string workPhone;

        private DateTime birthDate;

        private string nationality;
        private Gender gender;

        private DateTime employmentBeginDate;

        private DateTime? employementEndDate;

        private WorkStatus workstatus = WorkStatus.Fulltime;

        private CarLicense driverLicense = CarLicense.None;

        private bool isCandidate = true;
        private bool isConsultant = false;

        private Address address;

        private  ICollection<Timesheet> timesheets;

        private  Department departement;

        private Position job;

        private ICollection<WorkExperience> workexperiences;

        private LendingEquipment lendingEquipement;

        private ICollection<Degree> degrees;

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
        public Gender Gender { get => gender; set => gender = value; }
        public DateTime EmploymentBeginDate { get => employmentBeginDate; set => employmentBeginDate = value; }
        public DateTime? EmployementEndDate { get => employementEndDate; set => employementEndDate = value; }
        public WorkStatus WorkStatus { get => workstatus; set => workstatus = value; }
        public CarLicense DriverLicense { get => driverLicense; set => driverLicense = value; }
        public bool IsCandidate { get => isCandidate; set => isCandidate = value; }
        public bool IsConsultant { get => isConsultant; set => isConsultant = value; }
        public virtual Address Address { get => address; set => address = value; }
        public virtual ICollection<Timesheet> Timesheets { get => timesheets; set => timesheets = value; }
        public virtual Department Departement { get => departement; set => departement = value; }
        public virtual Position Job { get => job; set => job = value; }
        public virtual ICollection<WorkExperience> WorkExperiences { get => workexperiences; set => workexperiences = value; }
        public virtual LendingEquipment LendingEquipement { get => lendingEquipement; set => lendingEquipement = value; }
        public virtual ICollection<Degree> Degrees { get => degrees; set => degrees = value; }
        public virtual ICollection<Language> Languages { get => languages; set => languages = value; }
    }

    
}
