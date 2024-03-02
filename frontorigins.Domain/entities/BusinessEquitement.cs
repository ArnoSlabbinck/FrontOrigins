using frontorigins.Domain.common;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace frontorigins.Domain.entities
{
    public class BusinessEquitement : BaseEntitiy
    {
        private string name;

        private string description;

        private DateTime purchaseDate;

        private bool isAvailable;

        private EquimentCondition condition;

        private LendingEquitment lending;
        public BusinessEquitement() { }

        public BusinessEquitement(string name, string description, DateTime purchaseDate, bool isAvailable, EquimentCondition condition, LendingEquitment lending)
        {
            Name = name;
            Description = description;
            PurchaseDate = purchaseDate;
            IsAvailable = isAvailable;
            Condition = condition;
            Lending = lending;
        }

        public string Name { get => name; set => name = value; }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}