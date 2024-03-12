using Microsoft.EntityFrameworkCore;
using WebApiCrud.Models;

namespace WebApiCrud.Context
{
    public class AppDbContext:DbContext
    {
        //este constructor se utiliza para inicializar una instancia de AppDbContext con las opciones de configuración proporcionadas.Estas opciones pueden incluir información sobre la cadena de conexión de la base de datos, 
        //proveedores de base de datos específicos, y otras configuraciones relacionadas con Entity Framework.
        public AppDbContext(DbContextOptions<AppDbContext>options): base (options)
        {
            
        }

        //Define el tipo de entidad que se estableció en el modelo
        public DbSet<Person> Persons { get; set; }
    }
}
