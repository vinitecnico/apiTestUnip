using System;
using System.Collections;
using apiTestUnip.WebApi.Controllers;
using apiTestUnip.WebApi.Model;
using apiTestUnip.WebApi.Repository;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace apiTestUnip.Test {
    public class MenuControllerTest {
        private readonly MenuController controller;

        public MenuControllerTest () {
            this.controller = new MenuController (null);
        }

        [Fact]
        public async void Get () {
            // Act
            var okResult = await controller.Get ();
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