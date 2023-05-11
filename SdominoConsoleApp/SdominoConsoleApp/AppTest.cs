using SdominoData.FileWorking;
using SdominoData.Models.Entities;
using SdominoData.PersistenceServices.ISdominoPersistenceServiceDb;
using SdominoData.PersistenceServices.ISdominoPersistenceServiceFile;
using SdominoServices.ControllerService.OrderController;
using SdominoServices.ControllerService.ReceiptController;
using SdominoServices.ReceiptServices;

namespace SdominoConsoleApp
{
    public class AppTest
    {
        private readonly IOrderReader _orderReader;
        private readonly IPersistenceServiceDb _persistenceServiceDb;
        private readonly IPersistenceServiceFile _persistenceServiceFile;

        public AppTest(IOrderReader orderReader, IPersistenceServiceDb persistenceServiceDb, IPersistenceServiceFile persistenceServiceFile)
        {
            _orderReader = orderReader;
            _persistenceServiceDb = persistenceServiceDb;
            _persistenceServiceFile = persistenceServiceFile;
        }

        public void Run ()
        {
            var ordersDTO = _orderReader.Read();
            List<Order> orders = OrderController.ConvertToEntity(ordersDTO);
            foreach (var order in orders)
            {
                // salvo l'ordine nel db
                _persistenceServiceDb.Insert(order);
                // genero uno scontrino
                var recipt = ReceiptGenerator.Generate(order);
                // salvo lo scontrino nel db
                _persistenceServiceDb.Insert(recipt);
                // trasformo lo scontrino in un DTO
                var receiptDTO = ReceiptController.ConvertToDTO(recipt);
                // stampo lo scontrino
                _persistenceServiceFile.Write(receiptDTO);
            }

        }
    }
}
