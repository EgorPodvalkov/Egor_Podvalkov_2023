namespace DAL.Entities
{
    public class Question : BaseEntity
    {
        public string Text { get; set; }

        public Guid TestID { get; set; }

        public virtual Test Test { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
