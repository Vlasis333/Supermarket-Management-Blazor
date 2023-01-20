using CoreBusiness;

namespace UseCases.UseCaseInterfaces
{
    public interface IViewCategoriesUseCase
    {
        IEnumerable<Category> Exacute();
    }
}