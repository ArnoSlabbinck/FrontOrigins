using frontorigins.Domain.common;

namespace frontorigins.Domain.entities
{
    public class Departement : BaseEntitiy
    {
        private string sector { get; set; }

        private Location Location { get; set; }
        public Departement() { }
    }
}