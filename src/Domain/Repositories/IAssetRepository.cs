using InvestmentManagement.Domain.Entities;
using System.Collections.Generic;

namespace InvestmentManagement.Domain.Repositories
{
    public interface IAssetRepository
    {
        void Save(Asset asset);
        Asset FindById(string id);
        List<Asset> FindAll();
        void Delete(string id);
    }
}
