using CoreBusiness;

namespace UseCases.UseCaseInterfaces
{
    public interface IViewProductsByCategoryId
    {
        IEnumerable<Product> Execute(int categoryId);
    }
}