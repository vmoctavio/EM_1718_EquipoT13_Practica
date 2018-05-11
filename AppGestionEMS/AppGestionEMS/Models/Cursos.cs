using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace AppGestionEMS.Models
{
    public class Cursos
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Código de curso")]
        public string Cod_Curso { get; set; }
        [Required]
        public Boolean Actual { get; set; }

    }
}