using SupermarketMgmt.CoreBusiness;

namespace SupermarketMgmt.UseCases.UseCaseInterfaces
{
    public interface IViewProductsByCategoryId
    {
        IEnumerable<Product> Execute(int categpryId);
    }
}