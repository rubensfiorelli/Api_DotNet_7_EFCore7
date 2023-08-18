using System.ComponentModel.DataAnnotations;

namespace ProSummit.Core.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            Id = Guid.NewGuid();

        }

        //private List<Notification>? _notifications;

        [Key]
        public Guid Id { get; protected set; }

        private DateTime _dateInsert;

        public DateTime CreateAt
        {
            get { return _dateInsert; }
            set { _dateInsert = DateTime.UtcNow; }
        }

        private DateTime? _dateUpdate;

        public DateTime? UpdateAt
        {
            get { return _dateUpdate; }
            set { _dateUpdate = value; }
        }

        //public abstract bool Validate();


        //[NotMapped]
        //public IReadOnlyCollection<Notification>? Notifications => _notifications;

        //protected void SetNotifications(List<Notification> notifications)
        //{
        //    _notifications = notifications;
        //}
    }
}
