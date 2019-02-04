using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Univercity.Domain;

namespace Univercity.Entities
{
    [Table("students")]
    public class Student:DbEntity
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Group Group { get; set; }
    }
}
