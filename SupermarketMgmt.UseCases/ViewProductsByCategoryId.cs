using SupermarketMgmt.CoreBusiness;
using SupermarketMgmt.UseCases.DataStorePluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketMgmt.UseCases
{
    public class ViewProductsByCategoryId : IViewProductsByCategoryId
    {
        private readonly IProductRepository productRepository;

        public ViewProductsByCategoryId(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IEnumerable<Product> Execute(int categpryId)
        {
            return productRepository.GetProductsByCategoryId(categpryId);
        }
    }
}
