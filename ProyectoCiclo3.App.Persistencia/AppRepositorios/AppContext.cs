using Microsoft.EntityFrameworkCore;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Persistencia
{
    public class AppContext: DbContext{
        public DbSet<Buses> Buses { get; set; }
        public DbSet<Rutas> Rutas { get; set; }
        public DbSet<Estaciones> Estaciones { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog = ProyectoCiclo3;User ID=sa;Password=SomosDevco0806;");
                //optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ProyectoCiclo3");

            }
        }
    }
}
