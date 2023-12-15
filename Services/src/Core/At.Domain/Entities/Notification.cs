using At.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At.Domain.Entities
{
    public sealed class Notification : Entity
    {
        public string Description { get; set; }
        public bool State { get; set; }
        public int AppUserId { get; set; }
    }
}
