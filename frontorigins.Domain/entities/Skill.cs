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

       

        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }
        public string Notes { get => notes; set => notes = value; }
        public string Level { get => level; set => level = value; }
    }
}
