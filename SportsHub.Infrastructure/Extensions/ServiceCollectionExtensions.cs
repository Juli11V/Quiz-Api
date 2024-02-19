using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Quiz_Api.Business.Repositories;
using Quiz_Api.Infrastructure.DBContext;
using Quiz_Api.Infrastructure.Repositories;

namespace Quiz_Api.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration сonfiguration)
        {
            services.AddDbContext<QuizDbContext>(options =>
                options.UseSqlServer(сonfiguration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IQuizRepository, QuizRepository>();

            return services;
        }
    }
}
