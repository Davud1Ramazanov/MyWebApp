namespace Domain.Interfaces
{
    public interface IProductRepository<T> where T : class
    {
        IEnumerable<T> GetPopular();

    }
}
