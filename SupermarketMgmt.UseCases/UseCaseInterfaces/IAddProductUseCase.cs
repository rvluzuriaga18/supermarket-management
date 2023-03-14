using SupermarketMgmt.CoreBusiness;

namespace SupermarketMgmt.UseCases.UseCaseInterfaces
{
    public interface IAddProductUseCase
    {
        void Execute(Product product);
    }
}