using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demomvc.Models
{
    [Table("t_contacto")]
    public class Contacto{

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter first name")]
        [Column("firstname")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter last name")]
        [Column("lastname")]
        public string LastName { get; set; }

        [Column("agree")]
        public Boolean Agree { get; set; }

        [Column("gender")]
        public string Gender { get; set; }

        [Column("country")]
        public string Country { get; set; }


        [EmailAddress]
        [Column("email")]
        public string Email { get; set; }

        [NotMapped]
        public int Operador1 { get; set; }

        [NotMapped]
        public int Operador2 { get; set; }

        [NotMapped]
        public string Mensaje { get; set; }
    }

}