using MalQuizer.Models;
using Microsoft.AspNetCore.Mvc;

namespace MalQuizer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuizController : ControllerBase
    {
        private readonly ILogger<QuizController> _logger;

        public QuizController(ILogger<QuizController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("quizzes")]
        public IEnumerable<Quiz> Get()
        {
            return new Quiz[]
            {
                new Quiz { Id = 1, Name = "TestName", Category = QuizCategory.IT }
            };
        }
    }
}