using System;
using System.ComponentModel.DataAnnotations;

namespace CursoMVC.Models
{
    public class Calculadora
    {
        [Display(Name = "Primer Número")]
        public double n1 { get; set; }

        [Display(Name = "Segundo Número")]
        public double n2 { get; set; }

        [Display(Name = "Resultado")]
        public double resultado { get; set; }

        [Display(Name = "Operación")]
        public Operaciones operaciones { get; set; }
    }
}
