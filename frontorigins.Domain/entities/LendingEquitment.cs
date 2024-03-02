using frontorigins.Domain.common;

namespace frontorigins.Domain.entities
{
    public class LendingEquitment : BaseEntitiy
    {
        private DateTime lendDate { get; set; }

        private DateTime? expectedReturnDate { get; set; }

        private DateTime? actualReturnDate { get; set; }

        private BusinessEquitement BusinessEquitement { get; set; }
        private Employee employee { get; set; }
        public LendingEquitment() { }
    }
}