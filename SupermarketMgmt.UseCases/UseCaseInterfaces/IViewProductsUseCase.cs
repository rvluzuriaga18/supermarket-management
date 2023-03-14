using SupermarketMgmt.CoreBusiness;

namespace SupermarketMgmt.UseCases.UseCaseInterfaces
{
    public interface IViewProductsUseCase
    {
        IEnumerable<Product> Execute();
    }
}