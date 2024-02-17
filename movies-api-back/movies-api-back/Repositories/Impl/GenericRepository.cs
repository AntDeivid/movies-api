using movies_api_back.Models.DAO;

namespace movies_api_back.Repositories.Impl;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseClass
{

    private readonly MoviesDbContext _moviesDbContext;

    public GenericRepository(MoviesDbContext moviesDbContext)
    {
        _moviesDbContext = moviesDbContext;
    }

    public IQueryable<T> All()
    {
        return _moviesDbContext.Set<T>();
    }

    public T? GetById(Guid id)
    {
        return _moviesDbContext.Set<T>().FirstOrDefault(model => model.Id == id);
    }

    public T Save(T obj)
    {
        _moviesDbContext.Set<T>().Add(obj);
        _moviesDbContext.SaveChanges();
        return obj;
    }

    public T Update(T obj)
    {
        _moviesDbContext.Set<T>().Update(obj);
        _moviesDbContext.SaveChanges();
        return obj;
    }
}