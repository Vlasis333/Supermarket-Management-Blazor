using CoreBusiness;

namespace UseCases.UseCaseInterfaces
{
    public interface IGetProductByIdUseCase
    {
        Product Execute(int productId);
    }
}