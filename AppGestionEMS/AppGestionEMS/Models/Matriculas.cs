using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppGestionEMS.Models
{
    public class Matriculas
    {
        public int Id { get; set; }

        [Display(Name = "Curso")]
        [DisplayName("Curso")]
        public int CursoId { get; set; }
        public virtual Cursos Curso { get; set; }

        [Display(Name = "Grupo de clase")]
        [DisplayName("Grupo de clase")]
        public int GrupoClasesId { get; set; }
        public virtual GrupoClases GrupoClases { get; set; }

        [Display(Name = "Matrícula")]
        [DisplayName("Matrícula")]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}