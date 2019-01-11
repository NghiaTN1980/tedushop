using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;
using TeduShop.Service;

namespace TeduShop.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IPostCategoryService _categoryService;
        private List<PostCategory> _listCategory;

        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<IPostCategoryRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _categoryService = new PostCategoryService(_mockRepository.Object, _mockUnitOfWork.Object);
            _listCategory = new List<PostCategory>()
            {
                new PostCategory(){ID = 1, Name="Danh mục 1", Status = true},
                new PostCategory(){ID = 2, Name="Danh mục 2", Status = true},
                new PostCategory(){ID = 3, Name="Danh mục 3", Status = true},
            };
        }

        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            //Set up method
            _mockRepository.Setup(m => m.GetAll(null)).Returns(_listCategory);

            //Call action
            var result = _categoryService.GetAll() as List<PostCategory>;

            //Compare
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void PostCategory_Service_Create()
        {
            PostCategory category = new PostCategory();
            int id = 1;
            category.Name = "Test";
            category.Alias = "test";
            category.Status = true;

            _mockRepository.Setup(x => x.Add(category)).Returns((PostCategory p) =>
              {
                  p.ID = id;
                  return p;
              });

            var result = _categoryService.Add(category);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
        }
    }
}