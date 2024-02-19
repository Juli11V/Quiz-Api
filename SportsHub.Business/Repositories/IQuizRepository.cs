using Quiz_Api.Shared.Entities;

namespace Quiz_Api.Business.Repositories
{
    public interface IQuizRepository
    {
        Task<IEnumerable<Question>> GetQuizAsync();
    }
}
