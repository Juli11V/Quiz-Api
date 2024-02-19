using Quiz_Api.Shared.Entities;

namespace Quiz_Api.Shared.Models
{
    public class QuestionModel
    {
        public Guid Id { get; set; }
        public string QuestionText { get; set; }
        public string Options { get; set; }
        public int CorrectOptionIndex { get; set; }
        public int Points { get; set; }
    }

}
