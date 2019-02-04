using System;
using System.Collections.Generic;
using System.Text;
using Univercity.Domain;

namespace Univercity.Entities
{
    public class Spec:DbEntity
    {
        public string Name { get; set; }
        public List<Group> Groups { get; set; }
    }
}
