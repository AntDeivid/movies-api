namespace movies_api_back.Repositories;

public interface IGenericRepository<T>
{
    IQueryable<T> All();

    T? GetById(Guid id);

    T Save(T obj);

    T Update(T obj);

    T Delete(T obj);

}