using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;
using UseCases.UseCaseInterfaces;

namespace UseCases.TransactionsUseCase
{
    public class RecordTransactionUseCase : IRecordTransactionUseCase
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IGetProductByIdUseCase getProductByIdUseCase;

        public RecordTransactionUseCase(
            ITransactionRepository transactionRepository,
            IGetProductByIdUseCase getProductByIdUseCase)
        {
            _transactionRepository = transactionRepository;
            this.getProductByIdUseCase = getProductByIdUseCase;
        }

        public void Execute(string cashierName, int productId, int qty)
        {
            var product = getProductByIdUseCase.Execute(productId);
            _transactionRepository.Save(cashierName, productId, product.Name, product.Price.Value, product.Quantity.Value, qty);
        }
    }
}
