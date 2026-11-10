using Tools.Cqs;

namespace NetCloudGestMovies.Domain.Films.Queries
{
    public record GetFilmsQuery() : IQueryDefinition<IEnumerable<Film>>;
}
