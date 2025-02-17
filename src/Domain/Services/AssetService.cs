using InvestmentManagement.Domain.Entities;
using InvestmentManagement.Domain.Repositories;
using System.Collections.Generic;

namespace InvestmentManagement.Domain.Services
{
    public class AssetService
    {
        private readonly IAssetRepository _assetRepository;

        public AssetService(IAssetRepository assetRepository)
        {
            _assetRepository = assetRepository;
        }

        public void AddAsset(Asset asset)
        {
            _assetRepository.Save(asset);
        }

        public Asset GetAsset(string id)
        {
            return _assetRepository.FindById(id);
        }

        public List<Asset> GetAllAssets()
        {
            return _assetRepository.FindAll();
        }

        public void DeleteAsset(string id)
        {
            _assetRepository.Delete(id);
        }
    }
}
