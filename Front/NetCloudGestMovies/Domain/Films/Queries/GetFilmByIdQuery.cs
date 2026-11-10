using Tools.Cqs;

namespace NetCloudGestMovies.Domain.Films.Queries
{
    public record GetFilmByIdQuery(int Id) : IQueryDefinition<Film>;
}
