﻿using System.ComponentModel.DataAnnotations;

namespace API.Domain.DTOs
{
    public class ProductDTOCreate
    {
        [Required(ErrorMessage = "El campo Nombre es requerido")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo Descripción es requerido")]
        public string Description { get; set; }

        [Required(ErrorMessage = "El campo Categoria es requerido")]
        public string Category { get; set; }

        [Required(ErrorMessage = "El campo Precio es requerido")]
        public float Price { get; set; }

        [Required(ErrorMessage = "El campo Cantidad es requerido")]
        public string Amount { get; set; }

    }
}
