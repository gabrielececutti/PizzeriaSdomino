using Microsoft.Extensions.DependencyInjection;
using SdominoConsoleApp;
using SdominoConsoleApp.IOC;
using SdominoData.FileWorking;
using SdominoData.PersistenceServices.ISdominoPersistenceServiceDb;
using SdominoData.PersistenceServices.ISdominoPersistenceServiceFile;

var host = StartUp.CreateHostBuilder().Build();
var orderReader = host.Services.GetRequiredService<IOrderReader>();
var persistenceServiceDb = host.Services.GetRequiredService<IPersistenceServiceDb>();
var persistenceServiceFile = host.Services.GetRequiredService<IPersistenceServiceFile>();

var app = new AppTest (orderReader, persistenceServiceDb, persistenceServiceFile);
app.Run ();







