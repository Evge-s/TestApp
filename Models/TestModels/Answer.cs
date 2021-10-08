namespace TestApp.Models.TestModels
{
    public class Answer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public string Text { get; set; }
        public bool Result { get; set; }

        public Answer() { }
    }
}
