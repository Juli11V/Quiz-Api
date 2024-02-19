using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quiz_Api.Shared.Entities
{
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string QuestionText { get; set; }
        public string Options { get; set; }
        public int CorrectOptionIndex { get; set; }
        public int Points { get; set; }
    }
}
