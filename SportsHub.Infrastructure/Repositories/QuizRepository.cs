using Microsoft.EntityFrameworkCore;
using Quiz_Api.Business.Repositories;
using Quiz_Api.Infrastructure.DBContext;
using Quiz_Api.Shared.Entities;

namespace Quiz_Api.Infrastructure.Repositories
{
    public class QuizRepository : IQuizRepository
    {
        private readonly QuizDbContext _context;

        public QuizRepository(QuizDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Question>> GetQuizAsync()
        {
            return await _context.Questions.ToListAsync();
        }
    }
}
