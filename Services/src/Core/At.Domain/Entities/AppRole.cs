using At.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At.Domain.Entities
{
    public sealed class AppRole: Entity
    {
        public string Definition { get; set; } = null!;
    }
}
