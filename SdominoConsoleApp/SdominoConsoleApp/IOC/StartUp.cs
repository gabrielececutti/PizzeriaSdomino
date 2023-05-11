using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using SdominoData.FileWorking;
using SdominoData.PersistenceServices.ISdominoPersistenceServiceDb;
using SdominoData.PersistenceServices.ISdominoPersistenceServiceFile;
using SdominoData.Repositories;
using SdominoServices.ControllerService.OrderController;
using SdominoServices.ControllerService.ReceiptController;
using SdominoServices.ReceiptServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SdominoConsoleApp.IOC
{
    public static class StartUp
    {
        public static IHostBuilder CreateHostBuilder()
        {

            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, service) =>
                {
                    string fileName = "AppSettings.json";
                    string json = File.ReadAllText(fileName);
                    AppSettings? appSettings = JsonConvert.DeserializeObject<AppSettings>(json);
                    service.AddSingleton(appSettings);

                    service.AddDbContext<SdominoContext>(options =>
                        options.UseSqlServer(appSettings.ConnectionStrings.MyConnectionString));

                    service.AddSingleton<IOrderReader>(new OrderReader(appSettings.OrdinationsFolder.MyOrdinationsPath));
                    service.AddSingleton<ISdominoReposistory, SdominoRepository>();
                    service.AddSingleton<IPersistenceServiceDb, PersistenceServiceDb>();
                    service.AddSingleton<IPersistenceServiceFile>(new PeristenceServiceFile(appSettings.DownloadReceipts.MyReceiptsPath));
                });
        }
    }
}
