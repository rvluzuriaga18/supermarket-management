using SupermarketMgmt.CoreBusiness;

namespace SupermarketMgmt.UseCases.UseCaseInterfaces
{
    public interface IEditProductUseCase
    {
        void Execute(Product product);
    }
}