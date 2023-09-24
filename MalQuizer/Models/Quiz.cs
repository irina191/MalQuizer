using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace MalQuizer.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public QuizCategory Category { get; set; }

        public List<Question> Questions { get; set; }
    }
}
