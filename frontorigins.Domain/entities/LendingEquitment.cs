using frontorigins.Domain.common;

namespace frontorigins.Domain.entities
{
    public class LendingEquipment : BaseEntity
    {
        private DateTime lendDate;

        private DateTime? expectedReturnDate;

        private DateTime? actualReturnDate;

        private BusinessRequirement BusinessEquitement;
        private Employee employee;

        public LendingEquipment(long id) : base(id)
        {
        }

        public DateTime LendDate { get => lendDate; set => lendDate = value; }
        public DateTime? ExpectedReturnDate { get => expectedReturnDate; set => expectedReturnDate = value; }
        public DateTime? ActualReturnDate { get => actualReturnDate; set => actualReturnDate = value; }
        public BusinessRequirement BusinessEquitement1 { get => BusinessEquitement; set => BusinessEquitement = value; }
        public Employee Employee { get => employee; set => employee = value; }
    }
}