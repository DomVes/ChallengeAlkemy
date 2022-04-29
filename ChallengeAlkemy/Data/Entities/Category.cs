namespace ChallengeAlkemy.Data.Entities;
using System.ComponentModel.DataAnnotations;



public class Category
{
    public int Id { get; set; }

    [Required(ErrorMessage ="El campo {0} es obligatorio.")]
    [Display(Name ="Género")]
    [MaxLength(100,ErrorMessage ="El campo {0} debe tener almenos {1} caractéres.")]
    public string Name { get; set; }



    public ICollection<Film> Films { get; set; }

    [Display(Name ="Peliculas / Series ")]
    public int FilmsNumber => FilmsNumber == null ? 0 : Films.Count;



}
