using App.Domain.Core.AppServices.Customers.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Orders.Commands
{
    public class ScoreByCustomerAppService : IScoreByCustomerAppService
    {

        public void Execute(int customerId, int orderId, int score)
        {
            // step-1 : update Score field in the order


            // step-2 : get AcceptedExpertId of the order


            // step-3 : get List of Expert Scores in diff orders


            // step-4 : calc ScoreAvg and Update ScoreAvg in Expert Table
        }
    }
}
