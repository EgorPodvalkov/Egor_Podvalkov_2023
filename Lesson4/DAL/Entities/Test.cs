namespace DAL.Entities
{
    public class Test : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Guid CreatedForUserID { get; set; }

        public virtual User CreatedForUser { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
