using InvestmentManagement.Domain.Services;
using InvestmentManagement.Infrastructure.Models;
using InvestmentManagement.Infrastructure.Controllers;
using InvestmentManagement.Domain.UseCases;
using System;

namespace InvestmentManagement.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var assetRepository = new AssetModel();
            var assetService = new AssetService(assetRepository);
            var manageAsset = new ManageAsset(assetService);
            var assetController = new AssetController(manageAsset);

            
            assetController.AddAsset("1", "Stock", "Equity", 1000m);
            assetController.AddAsset("2", "Bond", "Fixed Income", 500m);

            
            Console.WriteLine("All Assets:");
            assetController.DisplayAllAssets();

            
            assetController.DeleteAsset("1");

            
            Console.WriteLine("\nAssets after deletion:");
            assetController.DisplayAllAssets();
        }
    }
}
