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

        private string? notes;

        public Skill(long id) : base(id)
        {
        }


        public string Name { get => name; set => name = value; }
        public string Notes { get => notes; set => notes = value; }
    }
}
