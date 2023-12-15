using At.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At.Domain.Entities
{
    public sealed class AppTask : Entity
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; }
        public int AppUserId { get; set; }
        public int PriorityId { get; set; }
        public bool State { get; set; }


        #region NavigationProperties
        public AppUser? AppUser { get; set; }
        public Priority Priority { get; set; }
        public List<TaskReport> TaskReports { get; set; }
        #endregion

    }
}
