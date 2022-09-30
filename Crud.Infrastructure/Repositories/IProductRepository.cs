namespace Crud.Infrastructure.Repositories
{
    public interface IProductRepository : IRepository
    {
        public void Select();
        public void Delete();
        public void Update();
        public void Insert();
    }
}
