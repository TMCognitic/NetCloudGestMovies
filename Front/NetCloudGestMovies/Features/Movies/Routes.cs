namespace NetCloudGestMovies.Features.Movies
{
    public static class Routes
    {
        public const string Movies = "/movies";
        public const string Details = Movies + "/{Id:int}";
        public const string Create = Movies + "/create";
    }
}
