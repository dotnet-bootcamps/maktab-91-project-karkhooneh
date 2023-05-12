using App.Domain.Core.AppServices.Customers.Queries;
using App.Domain.Core.AppServices.Experts.Queries;
using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels.Customers;

namespace App.Domain.AppService.Customers.Queries
{
    public class GetListOfOrderDetailsAppService : IGetListOfOrderDetailsAppService
    {
        private readonly IOrderRepository _orderRepository;

        public GetListOfOrderDetailsAppService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }


        public List<OrderDetailsOutputModel> Execute(int customerId)
        {
            return _orderRepository.GetListOfOrderDetails(customerId);
        }
    }
}