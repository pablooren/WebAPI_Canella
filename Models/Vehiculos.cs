namespace webapi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Vehiculos
    {
        
        public int Matricula { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "El valor debe de ser mayor que 0")]
        public string Precio_Alquiler { get; set; }
    }
}