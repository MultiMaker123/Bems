using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Ninject;
using System.Web.Mvc;
using System.Linq;
using Site.Abstract;
using System.Collections.Generic;
using Site.DB;
using Site.ViewModels;
using Site.Controllers;

namespace Unit_Tests
{
    [TestClass]
    public class Site
    {
        [TestMethod]
        // refactor with support for other tables when possible
        public void Can_Delete_Reports()
        {
            // Arrange
            // set up repo with 2 report
            Mock<IBemsRepository> mock = new Mock<IBemsRepository>();
            mock.Setup(m => m.Reports).Returns(new Report[]
            {
                new Report { ID = 1 },
                new Report { ID = 2 },
                new Report { ID = 3 }
            }.AsQueryable());

            // create mock controller
            EditorController target = new EditorController(mock.Object);

            // Act - call mock controller's delete function
            target.Delete("report", 2);
            IQueryable<Report> result = mock.Object.Reports;

            // Assert - assert that we deleted a paper
            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void Cannot_Delete_Nonexistent_Paper()
        {
            // Arrange
            // set up repo with 2 report
            Mock<IBemsRepository> mock = new Mock<IBemsRepository>();
            mock.Setup(m => m.Reports).Returns(new Report[]
            {
                new Report { ID = 1 },
                new Report { ID = 2 }
            }.AsQueryable());

            // create mock controller
            EditorController target = new EditorController(mock.Object);

            // Act - call mock controller's delete function with nonexistent
            // report
            target.Delete("report", 3);

            // Assert - assert that we did not delete anything
            Assert.AreEqual(2, mock.Object.Reports.Count());
        }
    }
}
