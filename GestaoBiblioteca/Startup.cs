using Application.Pages.Dashboard;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoBiblioteca
{
    public static class Startup
    {
        public static IServiceProvider ServiceProvider = null!;
        public static void Run() => StartApplication();

        private static void StartApplication()
        {
            IHost builder = CreateHostBuilder().Build();

            ServiceProvider = builder.Services;

            System.Windows.Forms.Application.Run(ServiceProvider.GetRequiredService<DashboardPage>());
        }

        private static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices(services => services.ConfigureServices());
        }
    }
}
