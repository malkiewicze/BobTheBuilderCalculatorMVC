using BuilderCalculatorMVC.Domain.Interfaces;
using BuilderCalculatorMVC.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderCalculatorMVC.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
           
            services.AddTransient<IAddressRepository, AddressRepository>();
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IClientTypeRepository, ClientTypeRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IRoomRepository, RoomRepository>();
            services.AddTransient<IWorkRepository, WorkRepository>();
            return services;
        }
    }
}
