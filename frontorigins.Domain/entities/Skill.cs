using frontorigins.Domain.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontorigins.Domain.entities
{
    public class Skill : BaseEntity
    {
        private string name;

        private string category;

        private string notes;

        private string level;

        public Skill(long id) : base(id)
        {
        }

        public Skill(long id, string name, string category, string notes, string level) : base(id)
        {
            this.name = name;
            this.category = category;
            this.notes = notes;
            this.level = level;
        }

        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }
        public string Notes { get => notes; set => notes = value; }
        public string Level { get => level; set => level = value; }
    }
}
