using SupermarketMgmt.CoreBusiness;

namespace SupermarketMgmt.UseCases.UseCaseInterfaces
{
    public interface IEditCategoryUseCase
    {
        void Execute(Category category);
    }
}