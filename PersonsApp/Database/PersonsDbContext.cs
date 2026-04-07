using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonsApp.Entities;

namespace PersonsApp.Database
{
    public class PersonsDbContext : IdentityDbContext<UserEntity, RoleEntity, string> //Viene de un paquete nugget, necesitamos hacer un metodo constructor
    {
        public PersonsDbContext (DbContextOptions options) : base(options) //options es un parámetro que le vamos a mandar a la clase
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder) //Este método se ejecuta cuando se crea la base de datos, aquí se pueden configurar las tablas
        {
            base.OnModelCreating(builder); //Llamamos al método base para que se ejecute el código de IdentityDbContext
            SetIdentityTableNames(builder); //Llamamos al método que cambia los nombres de las tablas de Identity
        }
        private static void SetIdentityTableNames(ModelBuilder builder) //Este método se encarga de cambiar los nombres de las tablas de Identity
        {
            builder.Entity<UserEntity>().ToTable("users"); //Cambiamos el nombre de la tabla de usuarios
            builder.Entity<RoleEntity>().ToTable("roles"); //Cambiamos el nombre de la tabla de roles
            builder.Entity<IdentityUserRole<string>>().ToTable("user_roles")
            .HasKey(ur => new { ur.UserId, ur.RoleId }); //Cambiamos la clave primaria compuesta
            builder.Entity<IdentityUserClaim<string>>().ToTable("user_claims"); //Cambiamos el nombre de la tabla de claims de usuarios
            builder.Entity<IdentityUserLogin<string>>().ToTable("user_logins"); //Cambiamos el nombre de la tabla de logins de usuarios
            builder.Entity<IdentityUserToken<string>>().ToTable("user_tokens"); //Cambiamos el nombre de la tabla de tokens de usuarios
             //builder.Entity<IdentityRoleClaim<string>>().ToTable("role_claims"); //Cambiamos el nombre de la tabla de claims de roles

        }
        public DbSet<PersonEntity> persons { get; set; } 
        
        public DbSet<CountryEntity> countries { get; set; } 

    }
}