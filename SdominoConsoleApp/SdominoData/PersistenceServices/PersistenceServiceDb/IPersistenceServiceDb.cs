using SdominoData.Models.Entities;
using SdominoData.Repositories;
using SominoModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdominoData.PersistenceServices.ISdominoPersistenceServiceDb
{
    public interface IPersistenceServiceDb
    {
        public void Insert(Order order);
        public void Insert(Receipt receipt);
    }

    public class PersistenceServiceDb : IPersistenceServiceDb
    {
        private readonly ISdominoReposistory _sdominoReposistory;

        public PersistenceServiceDb(ISdominoReposistory sdominoReposistory)
        {
            _sdominoReposistory = sdominoReposistory;
        }

        public void Insert(Order order)
        {
            _sdominoReposistory.Insert(order);
        }

        public void Insert(Receipt receipt)
        {
            _sdominoReposistory.Insert(receipt);
        }
    }
}
