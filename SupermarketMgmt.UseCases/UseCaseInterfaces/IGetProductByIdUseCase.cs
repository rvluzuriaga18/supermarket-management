using SupermarketMgmt.CoreBusiness;

namespace SupermarketMgmt.UseCases.UseCaseInterfaces
{
    public interface IGetProductByIdUseCase
    {
        Product Execute(int productId);
    }
}