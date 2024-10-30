using System.ComponentModel.DataAnnotations;

namespace LeonardoAndradeExamenProgresoOne_R.Models
{
    public class Celular
    {

        [Key]

        public int Id { get; set; }
        [MaxLength(20)]


        public string Modelo { get; set; }
        [Range(0, 300)]
        public float precio  { get; set; }

        [Range(0, 2023)]
        public int año { get; set; }

    }
}
