using Microsoft.AspNetCore.Authentication.JwtBearer;
using PersonsApp.Database;
using PersonsApp.Entities;

namespace PersonsApp.Extensions
{
    public static class AutenticationExtension
    {
        public static void AddAuthenticationConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddIdentity<UserEntity, RoleEntity>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Tokens.EmailConfirmationTokenProvider = "EmailConfirmation";
            }).AddEntityFrameworkStores<PersonsDbContext>();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme  = JwtBearerDefaults.AuthenticationScheme;
                
            }).AddJwtBearer(options =>
            {
                
            });
        }
    }
}