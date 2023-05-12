using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.AppService.Customers.Commands;
using App.Domain.AppService.Customers.Queries;
using App.Domain.AppService.Experts.Commands;
using App.Domain.AppService.Experts.Queries;
using App.Domain.Core.AppServices.Customers.Commands;
using App.Domain.Core.AppServices.Customers.Queries;
using App.Domain.Core.AppServices.Experts.Commands;
using App.Domain.Core.AppServices.Experts.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace App.Domain.AppService._IocConfigs
{
    public static class ServiceCollectionExtensions
    {
        public static void Add_AppService(this IServiceCollection services)
        {

            // AppServices - Experts
            services.AddScoped<IAddBidAppService, AddBidAppService>();
            services.AddScoped<IAddServiceToProfileAppService, AddServiceToProfileAppService>();
            services.AddScoped<IEditExpertProfileAppService, EditExpertProfileAppService>();
            services.AddScoped<IFinishOrderAppService, FinishOrderAppService>();
            services.AddScoped<IRegisterExpertProfileAppService, RegisterExpertProfileAppService>();
            services.AddScoped<IScoreByAcceptedExpertAppService, ScoreByAcceptedExpertAppService>();
            
            services.AddScoped<IGetListOfBidsAppService, GetListOfBidsAppService>();
            services.AddScoped<IGetListOfSuitableOrdersAppService, GetListOfSuitableOrdersAppService>();
            services.AddScoped<IGetOrderDetailsWithMyBidAppService, GetOrderDetailsWithMyBidAppService>();


            // AppServices - Customers
            services.AddScoped<IAcceptBidAppService, AcceptBidAppService>();
            services.AddScoped<IAddAddressAppService, AddAddressAppService>();
            services.AddScoped<IAddOrderAppService, AddOrderAppService>();
            services.AddScoped<ICancelOrderAppService, CancelOrderAppService>();
            services.AddScoped<IEditCustomerProfileAppService, EditCustomerProfileAppService>();
            services.AddScoped<IPayOrderAppService, PayOrderAppService>();
            services.AddScoped<IRegisterCustomerProfileAppService, RegisterCustomerProfileAppService>();
            services.AddScoped<IScoreByCustomerAppService, ScoreByCustomerAppService>();
            
            services.AddScoped<IGetListOfOrderDetailsAppService, GetListOfOrderDetailsAppService>();
            services.AddScoped<IGetOrderDetailsWithListOfBidsAppService, GetOrderDetailsWithListOfBidsAppService>();

        }
    }
}
