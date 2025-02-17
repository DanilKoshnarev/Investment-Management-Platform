using InvestmentManagement.Domain.Entities;
using InvestmentManagement.Domain.Services;
using System.Collections.Generic;

namespace InvestmentManagement.Domain.UseCases
{
    public class ManageAsset
    {
        private readonly AssetService _assetService;

        public ManageAsset(AssetService assetService)
        {
            _assetService = assetService;
        }

        public void CreateAsset(string id, string name, string type, decimal value)
        {
            var asset = new Asset(id, name, type, value);
            _assetService.AddAsset(asset);
        }

        public Asset ViewAsset(string id)
        {
            return _assetService.GetAsset(id);
        }

        public List<Asset> ViewAllAssets()
        {
            return _assetService.GetAllAssets();
        }

        public void RemoveAsset(string id)
        {
            _assetService.DeleteAsset(id);
        }
    }
}
