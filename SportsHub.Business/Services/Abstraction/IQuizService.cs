using Quiz_Api.Shared.Entities;

namespace Quiz_Api.Business.Services.Abstraction
{
    public interface IQuizService
    {
        Task<IEnumerable<Question>> GetQuizAsync();
    }
}