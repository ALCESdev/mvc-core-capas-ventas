using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaVentas.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
//using SistemaVentas.DAL.Interfaces;
//using SistemaVentas.DAL.Implementacion;
//using SistemaVentas.BLL.Interfaces;
//using SistemaVentas.BLL.Implementacion;




namespace SistemaVentas.IOC
{
    public static class Dependencia
    {
        public static void InyectarDependencia(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<VentasdbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("MiConexion"));
            });
        }
    }
}
