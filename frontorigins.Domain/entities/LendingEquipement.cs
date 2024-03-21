using frontorigins.Domain.common;

namespace frontorigins.Domain.entities
{
    public class LendingEquipment : BaseEntity
    {
        private DateTime lendDate;

        private DateTime? expectedReturnDate;

        private DateTime? actualReturnDate;

        private BusinessEquipement businessRequirement;

        public LendingEquipment(long id) : base(id)
        {
        }

        public DateTime LendDate { get => lendDate; set => lendDate = value; }
        public DateTime? ExpectedReturnDate { get => expectedReturnDate; set => expectedReturnDate = value; }
        public DateTime? ActualReturnDate { get => actualReturnDate; set => actualReturnDate = value; }
        public BusinessEquipement BusinessRequirement { get => businessRequirement; set => businessRequirement = value; }

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
                   EqualityComparer<BusinessEquipement>.Default.Equals(BusinessRequirement, equipment.BusinessRequirement);
                   
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
            return hash.ToHashCode();
        }
    }
}