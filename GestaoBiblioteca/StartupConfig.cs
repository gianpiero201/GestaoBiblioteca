using Application.Pages.Dashboard;
using Application.Queries.Acervos;
using Infra.Config;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoBiblioteca
{
    internal static class StartupConfig
    {

        public static IServiceCollection ConfigureServices(this IServiceCollection services) =>
            services
            .AddTransient<DashboardPage>()
            .AddScoped<IContext, Context>()
            .AddTransient<IAcervoQuery, AcervoQuery>();
    }
}
