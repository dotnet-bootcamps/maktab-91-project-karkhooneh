using App.Domain.Core.DtoModels.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.AppServices.Experts.Queries
{
    public interface IGetListOfBidsAppService
    {
        List<OrderDetailsOutputModel> Execute(int customerId);
    }
}
