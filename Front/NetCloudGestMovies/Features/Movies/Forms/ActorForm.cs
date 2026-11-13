using System.ComponentModel.DataAnnotations;

namespace NetCloudGestMovies.Features.Movies.Forms
{
    public class ActorForm
    {
        [Required]
        [MinLength(1)]
        public string Nom { get; set; } = string.Empty;

        [Required]
        [MinLength(1)]
        public string Prenom { get; set; } = string.Empty;
    }
}
