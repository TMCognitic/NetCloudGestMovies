using NetCloudGestMovies.Domain.Films.Queries;
using Tools.Results;

namespace NetCloudGestMovies.Domain.Films;

public class FilmService(IList<Film> films) : IFilmRepository
{
    public Result<IEnumerable<Film>> Handle(GetFilmsQuery query)
    {
        return Result<IEnumerable<Film>>.Success(films);
    }

    public Result<Film> Handle(GetFilmByIdQuery query)
    {
        Film? film = films.SingleOrDefault(f => f.Id == query.Id);

        if (film is null)
            return Error.Create("Films", "Film introuvable");

        return Result<Film>.Success(film);
    }
}
