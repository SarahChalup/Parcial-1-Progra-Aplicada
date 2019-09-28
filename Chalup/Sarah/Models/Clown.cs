using System;

namespace Sarah.Models
{
    using System.ComponentModel.DataAnnotations;

    public enum Tricks
    {
        Sopa,
        Srampeon,
        Superman
    }
    public class Clown
    {
        [Key]
        public int ClownID { get; set; }
        [Required]
        [Display(Name = "Nombre Completo")]
        [StringLength(24, MinimumLength = 2)]

        public string NickName { get; set; }
        [Required]
        public Tricks tricks { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "Direccion de correo no valida")]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }


    }
}