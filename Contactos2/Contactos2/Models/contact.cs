using Contactos2.Models;
using System.ComponentModel.DataAnnotations;

namespace Contactos2.Models
{
    public enum Typecontact
    {
        telephone,
        email,
        facebook
    }

    public class contact
    {
    [Key]
    private int contactID { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public Typecontact type { get; set; }
    [Required]
    [Display(Description ="contact")]
    public string contactvalue { get; set; }
}
}