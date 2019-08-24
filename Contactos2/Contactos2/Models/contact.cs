using Contactos2.Models;
using System.ComponentModel.DataAnnotations;

namespace Contactos2.Models
{
    public enum TypeContact
    {
        telephone,
        email,
        facebook
    }

    public class Contact
    {
    [Key]
    private int ContactID { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public TypeContact Type { get; set; }
    [Required]
    [Display(Description ="Contact")]
    public string Contactvalue { get; set; }
}
}