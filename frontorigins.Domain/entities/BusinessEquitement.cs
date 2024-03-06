using frontorigins.Domain.common;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace frontorigins.Domain.entities
{
    public class BusinessRequirement : BaseEntity
    {
        private string name;

        private string description;

        private DateTime purchaseDate;

        private bool isAvailable;

        private EquipmentCondition condition;

        private LendingEquipment lending;

        public BusinessRequirement(long id) : base(id)
        {
        }

        public BusinessRequirement(long id, string name, string description, DateTime purchaseDate, bool isAvailable, EquipmentCondition condition, LendingEquipment lending) : base(id)
        {
            this.name = name;
            this.description = description;
            this.purchaseDate = purchaseDate;
            this.isAvailable = isAvailable;
            this.condition = condition;
            this.lending = lending;
        }

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public DateTime PurchaseDate { get => purchaseDate; set => purchaseDate = value; }
        public bool IsAvailable { get => isAvailable; set => isAvailable = value; }
        public LendingEquipment Lending { get => lending; set => lending = value; }
        internal EquipmentCondition Condition { get => condition; set => condition = value; }

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