namespace CinemaBookingSystem.Services.Interface
{
    public class IMovieService
    {
        List<Movie> GetAllMovies();
        Movie GetDetailsForMovie(Guid? id);
        void CreateNewMovie(Movie m);
        void UpdeteExistingProjection(Movie m);
        void DeleteProjection(Guid id);
    }
}