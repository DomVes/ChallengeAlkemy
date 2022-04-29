using System.ComponentModel.DataAnnotations;

namespace ChallengeAlkemy.Data.Entities
{
    public class Film
    {

        public int Id { get; set; }


        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage ="El campo {0} debe tener máximo {1} caractéres")]
        [Display(Name = "Titulo")]
        public string Name { get; set; }


        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name="Calificación")]
        [Range(1,5, ErrorMessage ="Debe ser un rango entre {0} y {1}.")]
        public int qualification { get; set; }

        [Required(ErrorMessage="El campo {0} es obligatorio")]
        [Display(Name= "Fecha de estreno")]
        public DateTime dateTime { get; set; }



        public Category Category { get; set; }

        public ICollection<Character> Characters { get; set; }

        public int CharactersNumber => CharactersNumber == null ? 0 : Characters.Count;


    }
}
