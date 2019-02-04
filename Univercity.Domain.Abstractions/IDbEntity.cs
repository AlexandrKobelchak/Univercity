using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Univercity.Domain
{
    public interface IDbEntity
    {
        [Key]
        Guid Id { get; set; }
    }
}
