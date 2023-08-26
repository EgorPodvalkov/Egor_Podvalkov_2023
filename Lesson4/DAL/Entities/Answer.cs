namespace DAL.Entities
{
    public class Answer : BaseEntity
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }

        public Guid QuestionID { get; set; }

        public virtual Question Question { get; set; }
    }
}
