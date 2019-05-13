using BookLibrary.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;
using Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using DataAccess.Implementation;
using DataAccess;

namespace BookLibrary.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexViewResultNotNull()
        {

            // Arrange
            //HomeController controller = new HomeController(BookService, _authorService, _userManager, _rateService);
            // Act
            //ViewResult result = controller.Index() as ViewResult;
            // Assert
            //Assert.NotNull(result);
        }
    }
}
