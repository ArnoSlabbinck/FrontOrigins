using frontorigins.Domain.common;

namespace frontorigins.Domain.entities
{
    public class Language : BaseEntity
    {
        public Language(long id) : base(id)
        {
        }

        public Language(long id, string name, string level, ICollection<Employee> employees) : base(id)
        {
            this.Name = name;
            this.Level = level;
            this.Employees = employees;
        }

        private string name;

        private string level;

        private ICollection<Employee> employees;

        public string Name { get => name; set => name = value; }
        public string Level { get => level; set => level = value; }
        public ICollection<Employee> Employees { get => employees; set => employees = value; }

        public override bool Equals(object? obj)
        {
            return obj is Language language &&
                   base.Equals(obj) &&
                   Id == language.Id &&
                   CreatedDate == language.CreatedDate &&
                   ModifiedDate == language.ModifiedDate &&
                   Name == language.Name &&
                   Level == language.Level &&
                   EqualityComparer<ICollection<Employee>>.Default.Equals(Employees, language.Employees);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Id, CreatedDate, ModifiedDate, Name, Level, Employees);
        }
    }
}