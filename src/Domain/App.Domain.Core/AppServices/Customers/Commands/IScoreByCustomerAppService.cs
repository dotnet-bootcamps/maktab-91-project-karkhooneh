using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.AppServices.Customers.Commands
{
    /// <summary>
    /// ابتدا امتیاز از نظر مشتری در سفارش ثبت شود
    /// سپس محاسبات میانگین امتیاز برای متخصصی که این سفارش را انجام داده است
    /// در جدول متخصص آپدیت شود
    /// </summary>
    public interface IScoreByCustomerAppService
    {
        void Execute(int customerId, int orderId, int score);
    }
}
