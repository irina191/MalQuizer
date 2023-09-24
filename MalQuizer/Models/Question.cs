using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace MalQuizer.Models
{
    public class Question
    {
        public int Id { get; set; }
        public int QuizId { get; set; }
        public string Problem { get; set; }
        public string Answer { get; set; }

        internal string _variants;

        [NotMapped]
        public List<string> Variants
        {
            get
            {
                if (_variants == null)
                {
                    return new List<string>();
                }

                return JsonConvert.DeserializeObject<List<string>>(_variants);
            }

            set => _variants = JsonConvert.SerializeObject(value);
        }

        public Quiz Quiz { get; set; }
    }
}