using At.Domain.Abstractions;

namespace At.Domain.Entities
{
    public sealed class AppUser : Entity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string AppRoleId { get; set; }

        #region Navigation Properties
        public AppRole? Role { get; set; }
        public List<AppTask>? Tasks { get; set; }
        public List<Notification>? Notifications { get; set; }
        #endregion
    }
}
