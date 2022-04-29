using System.ComponentModel.DataAnnotations;

namespace ChallengeAlkemy.Data.Entities
{
    public class Character
    {

        public int Id { get; set; } 

        [Required(ErrorMessage="El campo {0} es obligatorio.")]
        [Display(Name="Personaje")]
        [MaxLength(100, ErrorMessage ="El campo {0} debe tener máximo {1} caractéres")]
        public string Name { get; set; }
        

        public ICollection<Film> Films { get; set; }

        public int FilmsNumber => FilmsNumber == null? 0 : Films.Count;

     
    }
}
