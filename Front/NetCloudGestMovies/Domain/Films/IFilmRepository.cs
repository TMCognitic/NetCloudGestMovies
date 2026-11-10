using NetCloudGestMovies.Domain.Films.Queries;
using Tools.Cqs;

namespace NetCloudGestMovies.Domain.Films
{
    public interface IFilmRepository : 
        IQueryHandler<GetFilmsQuery, IEnumerable<Film>>,
        IQueryHandler<GetFilmByIdQuery, Film>
    {
    }
}
