using Microsoft.Extensions.DependencyInjection;
using Quiz_Api.Business.Services.Abstraction;
using Quiz_Api.Business.Services.Implementation;


namespace Quiz_Api.Business.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            services.AddScoped<IQuizService, QuizService>();

            return services;
        }
    }
}
