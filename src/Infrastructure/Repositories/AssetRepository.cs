using InvestmentManagement.Domain.Entities;
using InvestmentManagement.Domain.Repositories;
using System.Collections.Generic;

namespace InvestmentManagement.Infrastructure.Repositories
{
    public class AssetRepository : IAssetRepository
    {
        private readonly List<Asset> _assets = new List<Asset>();

        public void Save(Asset asset)
        {
            _assets.Add(asset);
        }

        public Asset FindById(string id)
        {
            return _assets.Find(asset => asset.Id == id);
        }

        public List<Asset> FindAll()
        {
            return _assets;
        }

        public void Delete(string id)
        {
            _assets.RemoveAll(asset => asset.Id == id);
        }
    }
}
