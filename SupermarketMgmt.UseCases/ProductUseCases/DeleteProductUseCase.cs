using SupermarketMgmt.UseCases.DataStorePluginInterfaces;
using SupermarketMgmt.UseCases.UseCaseInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketMgmt.UseCases.ProductUseCases
{
    public class DeleteProductUseCase : IDeleteProductUseCase
    {
        private readonly IProductRepository productRepository;

        public DeleteProductUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public void Execute(int productId)
        {
            productRepository.DeleteProduct(productId);
        }
    }
}
