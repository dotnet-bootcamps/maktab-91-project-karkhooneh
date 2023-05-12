using App.Domain.Core.AppServices.Customers.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.DtoModels.Customers;

namespace App.Domain.AppService.Customers.Commands
{
    public class AddOrderAppService : IAddOrderAppService
    {
        public int Execute(AddOrderInputModel model)
        {
            throw new NotImplementedException();
        }
    }
}
