using At.Domain.Abstractions;

namespace At.Domain.Entities
{
    public sealed class TaskReport: Entity
    {
        public string Definition { get; set; }
        public string Detail { get; set; }
        public int AppTaskId { get; set; }
    }
}
