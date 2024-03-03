using frontorigins.Domain.common;

namespace frontorigins.Domain.entities
{
    public class Language : BaseEntity
    {
        public Language(long id) : base(id)
        {
        }

        private string name { get; set; }

        private string level { get; set; }

        private ICollection<Employee> employees { get; set; }
    }
}