using frontorigins.Domain.common;

namespace frontorigins.Domain.entities
{
    public class Departement : BaseEntity
    {
        private string sector;

        private Location Location;

        public Departement(long id) : base(id)
        {
        }

        public string Sector { get => sector; set => sector = value; }
        public Location Location1 { get => Location; set => Location = value; }
    }
}