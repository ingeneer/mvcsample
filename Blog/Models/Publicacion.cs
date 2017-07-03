using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Publicacion
    {

        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} es obligatorio")]
        [StringLength(40, ErrorMessage = "{0} no puede ser mayor a {1} caracteres")]
        [Display(Name = "Título de tu post")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "{0} es obligatorio")]
        [Display(Name = "Expresa tus ideas y opiniones")]
        public string Contenido { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Puedes agregar una imagen si deseas")]
        public string Imagen { get; set; }

        [Display(Name = "Mostrar en el sitio")]
        public bool Habilitada { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Vistas { get; set; }

        [Required(ErrorMessage = "Debes agregar una descripción corta")]
        [StringLength(50, ErrorMessage = "La descrición no puede ser mayor a {1} caracteres")]
        public string Resumen { get; set; }

        [Required]
        public DateTime FechaPublicacion { get; set; }

        public virtual List<Comentario> Comentarios { get; set; }

    }
}