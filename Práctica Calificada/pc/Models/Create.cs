using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pc.Models{
    [Table("t_loan")]
    public class Create {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID {get; set;}
        [Required(ErrorMessage = "Please enter name")]
        [Column("name")]
        public string name {get;set;}

         [Required(ErrorMessage = "Please enter Birthay")]
        [Column("loan_date")]
        [DataType(DataType.Date)]
        public DateTime loan_date {get; set;}

        [Required(ErrorMessage = "Please enter amount")]
        [Column("original_amount")]
        public double original_amount {get; set;}

        [Required(ErrorMessage = "Please enter rate")]
        [Column("rate")]
        public double rate {get; set;}

        [Column("total_amount")]
        public double total_amount {get; set;}

         [Column("status")]
        public String status { get; set; }

        [NotMapped]
        public string Mensaje { get; set; }

        [NotMapped]
        public Double Operacion { get; set; }
    }
}
