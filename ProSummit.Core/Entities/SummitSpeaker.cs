namespace ProSummit.Core.Entities
{
    public sealed class SummitSpeaker : BaseEntity
    {
        public SummitSpeaker(string name,
                       string talkTitle,
                       string description,
                       string linkedin,
                       Guid summitEventId) : base()
        {
            Name = name;
            TalkTitle = talkTitle;
            Description = description;
            Linkedin = linkedin;
            IsDeleted = false;
            SummitEventId = summitEventId;
        }

        public string Name { get; private set; }
        public string TalkTitle { get; private set; }
        public string Description { get; private set; }
        public string Linkedin { get; private set; }
        public bool IsDeleted { get; private set; }
        public Guid SummitEventId { get; private set; }
        public SummitEvent? Event { get; set; }


        public void Update(string newName, string newTalkTitle, string newDescription, string newLinkedin)
        {
            Name = newName;
            TalkTitle = newTalkTitle;
            Description = newDescription;
            Linkedin = newLinkedin;
        }

        public void Delete()
        {
            IsDeleted = true;
        }

    }
}