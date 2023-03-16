using SupermarketMgmt.CoreBusiness;

namespace SupermarketMgmt.UseCases
{
    public interface IViewProductsByCategoryId
    {
        IEnumerable<Product> Execute(int categpryId);
    }
}