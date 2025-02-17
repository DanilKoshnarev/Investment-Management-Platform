using InvestmentManagement.Domain.Entities;
using InvestmentManagement.Domain.Repositories;
using InvestmentManagement.Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace InvestmentManagement.Tests.DomainTests
{
    [TestClass]
    public class AssetServiceTests
    {
        private AssetService _assetService;
        private MockAssetRepository _mockRepository;

        [TestInitialize]
        public void Setup()
        {
            _mockRepository = new MockAssetRepository();
            _assetService = new AssetService(_mockRepository);
        }

        [TestMethod]
        public void AddAsset_Should_Add_Asset()
        {
            var asset = new Asset("1", "Stock", "Equity", 1000m);
            _assetService.AddAsset(asset);
            var addedAsset = _assetService.GetAsset("1");

            Assert.IsNotNull(addedAsset);
            Assert.AreEqual("Stock", addedAsset.Name);
        }

        [TestMethod]
        public void DeleteAsset_Should_Remove_Asset()
        {
            var asset = new Asset("1", "Stock", "Equity", 1000m);
            _assetService.AddAsset(asset);
            _assetService.DeleteAsset("1");

            var deletedAsset = _assetService.GetAsset("1");
            Assert.IsNull(deletedAsset);
        }

        [TestMethod]
        public void GetAllAssets_Should_Return_All_Assets()
        {
            var asset1 = new Asset("1", "
