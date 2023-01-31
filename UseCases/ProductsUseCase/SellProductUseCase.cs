using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases.ProductsUseCase
{
    public class SellProductUseCase : ISellProductUseCase
    {
        private readonly IProductRepository _productRepository;
        private readonly IRecordTransactionUseCase recordTransactionUseCase;

        public SellProductUseCase(
            IProductRepository productRepository,
            IRecordTransactionUseCase recordTransactionUseCase)
        {
            this._productRepository = productRepository;
            this.recordTransactionUseCase = recordTransactionUseCase;
        }

        public void Execute(string cashierName, int productId, int qtyToSell)
        {
            var product = _productRepository.GetProductById(productId);
            if (product == null) return;

            recordTransactionUseCase.Execute(cashierName, productId, qtyToSell);

            product.Quantity -= qtyToSell;
            _productRepository.UpdateProduct(product);
            
        }
    }
}
