using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels.Customers;
using App.Infrastructures.Db.SqlServer.Ef.Database;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructures.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;

        public OrderRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<OrderDetailsOutputModel> GetListOfOrderDetails(int customerId)
        {
            return _appDbContext.Orders
                .Where(w=>w.CustomerId== customerId)
                .Select(s => new OrderDetailsOutputModel
            {
                AcceptedExpertId = s.AcceptedExpertId,
                AvailabilityTo = s.AvailabilityTo,
                CreatedAt = s.CreatedAt,
                CreatedByUserId = s.CreatedBy,
                CustomerAddressId = s.CustomerAddressId,
                ExpertFinishedWorkAt = s.ExpertFinishedWorkAt,
                ExpertStartedWorkAt = s.ExpertStartedWorkAt,
                LastModifiedAt = s.LastModifiedAt,
                //ListOfServiceIds = 
                ScoreByCustomerId = s.ScoreByCustomerId,
                ScoreByExpertId = s.ScoreByAcceptedExpertId,
                ServiceCategoryId = s.ServiceCategoryId,
            }).ToList();
        }
    }
}