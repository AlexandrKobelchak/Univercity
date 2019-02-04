using System;
using System.Collections.Generic;
using System.Text;
using Univercity.Domain;

namespace Univercity.Entities
{
    public class Group:DbEntity
    {
        public string Name { get; set; }
        public Spec Spec { get; set; }
        public List<Student> Students { get; set; }
    }
}
