
namespace Contactos2.Models
{
    using System.Data.Entity;

    public class DataContent:DbContext
    {
        public DataContent():base("DefaultConnection")
        {

        }
    }
}