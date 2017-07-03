using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Comentario
    {

        [ScaffoldColumn(false)]
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} no puede ser vacio")]
        [StringLength(100, ErrorMessage = "{0} no puede ser mayor a {1} caracteres")]
        [Display(Name = "¿Qué quieres decirle al autor de este post?")]
        public string Contenido { get; set; }
        
        [Display(Name = "Aprobar comentario")]
        public bool Aprobado { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaPublicacion { get; set; }

        public virtual Publicacion EnPublicacion { get; set; }
    }
}