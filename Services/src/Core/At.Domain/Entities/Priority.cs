using At.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At.Domain.Entities
{
    public sealed class Priority: Entity
    {
        public string Definition { get; set; }

        #region  Navigation Properties
        public List<AppTask> AppTasks { get; set; }

        #endregion

    }
}
