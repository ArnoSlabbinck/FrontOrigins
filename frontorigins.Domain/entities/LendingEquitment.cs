using frontorigins.Domain.common;

namespace frontorigins.Domain.entities
{
    public class LendingEquipment : BaseEntity
    {
        private DateTime lendDate;

        private DateTime? expectedReturnDate;

        private DateTime? actualReturnDate;

        private BusinessRequirement BusinessRequirement;
        private Employee employee;

        public LendingEquipment(long id) : base(id)
        {
        }

        public LendingEquipment(long id, DateTime lendDate, DateTime? expectedReturnDate, DateTime? actualReturnDate, BusinessRequirement businessEquitement, Employee employee) : base(id)
        {
            this.lendDate = lendDate;
            this.expectedReturnDate = expectedReturnDate;
            this.actualReturnDate = actualReturnDate;
            BusinessRequirement = businessEquitement;
            this.employee = employee;
        }

        public DateTime LendDate { get => lendDate; set => lendDate = value; }
        public DateTime? ExpectedReturnDate { get => expectedReturnDate; set => expectedReturnDate = value; }
        public DateTime? ActualReturnDate { get => actualReturnDate; set => actualReturnDate = value; }
        public BusinessRequirement BusinessEquitement1 { get => BusinessRequirement; set => BusinessRequirement = value; }
        public Employee Employee { get => employee; set => employee = value; }

        public override bool Equals(object? obj)
        {
            return obj is LendingEquipment equipment &&
                   base.Equals(obj) &&
                   Id == equipment.Id &&
                   CreatedDate == equipment.CreatedDate &&
                   ModifiedDate == equipment.ModifiedDate &&
                   lendDate == equipment.lendDate &&
                   expectedReturnDate == equipment.expectedReturnDate &&
                   actualReturnDate == equipment.actualReturnDate &&
                   EqualityComparer<BusinessRequirement>.Default.Equals(BusinessRequirement, equipment.BusinessRequirement) &&
                   EqualityComparer<Employee>.Default.Equals(employee, equipment.employee);
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(base.GetHashCode());
            hash.Add(Id);
            hash.Add(CreatedDate);
            hash.Add(ModifiedDate);
            hash.Add(lendDate);
            hash.Add(expectedReturnDate);
            hash.Add(actualReturnDate);
            hash.Add(BusinessRequirement);
            hash.Add(employee);
            return hash.ToHashCode();
        }
    }
}