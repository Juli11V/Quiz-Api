using Microsoft.EntityFrameworkCore;
using Quiz_Api.Business.Repositories;
using Quiz_Api.Business.Services.Abstraction;
using Quiz_Api.Shared.Entities;

namespace Quiz_Api.Business.Services.Implementation
{
    public class QuizService : IQuizService
    {
        private readonly IQuizRepository _quizRepository;

        public QuizService(IQuizRepository quizRepository)
        {
            _quizRepository = quizRepository ?? throw new ArgumentNullException(nameof(quizRepository));
        }

        public async Task<IEnumerable<Question>> GetQuizAsync()
        {
            var quiz = await _quizRepository.GetQuizAsync();
        
            return quiz;
        }
    }
}
