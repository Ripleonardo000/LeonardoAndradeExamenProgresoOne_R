using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeonardoAndradeExamenProgresoOne_R.Models
{
    public class Andrade
    {

        [Key]
        public int Id { get; set; }
        [MaxLength(20)]

        public string name { get; set; }

        [Range(0, 9000)]
        public float sueldo { get; set; }

        public Boolean empleo { get; set; }



           
            public DateTime Cumple { get; set; }


        public Celular? Celular { get; set; }

    [ForeignKey("Celular")]

    public int IdCelular { get; set; }


    }
}
