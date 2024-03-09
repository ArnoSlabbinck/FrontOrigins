using frontorigins.Domain.aggregates;
using frontorigins.Domain.common;

namespace frontorigins.Domain.entities
{
    public class Departement : BaseEntity
    {
        private string sector;

        private Address location;

        public Departement(long id) : base(id)
        {
        }

       

        public string Sector { get => sector; set => sector = value; }
        public Address Location { get => Location; set => Location = value; }

        public override bool Equals(object? obj)
        {
            return obj is Departement departement &&
                   base.Equals(obj) &&
                   Id == departement.Id &&
                   CreatedDate == departement.CreatedDate &&
                   ModifiedDate == departement.ModifiedDate &&
                   sector == departement.sector &&
                   EqualityComparer<Address>.Default.Equals(Location, departement.Location);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Id, CreatedDate, ModifiedDate, sector, Location);
        }
    }
}