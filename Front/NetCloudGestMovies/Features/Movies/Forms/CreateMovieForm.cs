using System.ComponentModel.DataAnnotations;

namespace NetCloudGestMovies.Features.Movies.Forms
{

    //[ValidatableType] // Uniquement si validation imbriquée
    public class CreateMovieForm
    {
        [Required]
        [MinLength(1)]
        public string Titre { get; set; } = string.Empty;

        [Compare(nameof(Titre))]
        public string ConfirmTitre { get; set; } = string.Empty;

        [Range(1830, 9999)]
        public int Annee { get; set; }

        public List<ActorForm> Acteurs { get; } = new List<ActorForm>();
    }
}
