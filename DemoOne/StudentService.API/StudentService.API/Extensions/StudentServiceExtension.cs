using StudentService.Core.Interfaces;


namespace StudentService.API.Extensions
{
    public static class StudentServiceExtension
    {
        public static IServiceCollection AddStudentServiceExtension(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IStudentService, Core.Services.StudentService>();
            return services;
        }
    }
}
