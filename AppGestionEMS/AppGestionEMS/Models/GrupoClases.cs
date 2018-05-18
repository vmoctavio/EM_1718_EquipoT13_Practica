using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace AppGestionEMS.Models
{
    public class GrupoClases
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Grupo de clase")]
        public string Cod_Grupo { get; set; }      
    }
}