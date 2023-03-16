using SupermarketMgmt.CoreBusiness;
using SupermarketMgmt.UseCases.DataStorePluginInterfaces;
using SupermarketMgmt.UseCases.UseCaseInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketMgmt.UseCases.ProductUseCases
{
    public class GetProductByIdUseCase : IGetProductByIdUseCase
    {
        private readonly IProductRepository productRepository;

        public GetProductByIdUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public Product Execute(int productId)
        {
            return productRepository.GetProductById(productId);
        }
    }
}
