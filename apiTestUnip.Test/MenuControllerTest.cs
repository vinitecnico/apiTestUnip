using System;
using System.Collections;
using apiTestUnip.WebApi.Controllers;
using apiTestUnip.WebApi.Model;
using apiTestUnip.WebApi.Repository;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace apiTestUnip.Test {
    public class MenuControllerTest {
        private readonly IRepository<apiTestUnip.WebApi.Model.MainMenu> _mainMenuRepository;

        public MenuControllerTest (IRepository<apiTestUnip.WebApi.Model.MainMenu> mainMenuRepository) {
            this._mainMenuRepository = mainMenuRepository;
        }

        [Fact]
        public async void Get () {
            // Act
            var okResult = await this._mainMenuRepository.GetAll();
            // Assert
            Assert.NotEmpty (okResult);
        }

        [Fact]
        public void GetbyId () {
            // Act
            //var okResult = _controller.Get (5);

            // Assert
            //Assert.Equal("value", okResult.Value);
        }
    }
}