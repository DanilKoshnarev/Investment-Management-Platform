using InvestmentManagement.Domain.UseCases;
using System;

namespace InvestmentManagement.Infrastructure.Controllers
{
    public class AssetController
    {
        private readonly ManageAsset _manageAsset;

        public AssetController(ManageAsset manageAsset)
        {
            _manageAsset = manageAsset;
        }

        public void AddAsset(string id, string name, string type, decimal value)
        {
            _manageAsset.CreateAsset(id, name, type, value);
        }

        public void DisplayAllAssets()
        {
            var assets = _manageAsset.ViewAllAssets();
            foreach (var asset in assets)
            {
                Console.WriteLine($"ID: {asset.Id}, Name: {asset.Name}, Type: {asset.Type}, Value: {asset.Value}");
            }
        }

        public void DeleteAsset(string id)
        {
            _manageAsset.RemoveAsset(id);
        }
    }
}
