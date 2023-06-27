﻿using AngleSharp.Html.Dom;
using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wa9.Tests.Helpers;

namespace wa9.Tests
{
    public class WebIntegrationTests : IClassFixture<WebApplicationFactory<wa9.Program>>
    {
        private readonly WebApplicationFactory<wa9.Program> _factory;

        public WebIntegrationTests(WebApplicationFactory<wa9.Program> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("/")]
        [InlineData("/Home/Index")]
        [InlineData("/Home/Privacy")]
        public async Task Home_Action_RetornaContentTypeCorrecto(string url)
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299
            Assert.Equal("text/html; charset=utf-8", response.Content.Headers.ContentType.ToString());
        }

        [Fact]
        public async Task Home_Index_ContieneLista()
        {
            // Arrange
            var client = _factory.CreateClient();
            var defaultPage = await client.GetAsync("/");
            var content = await HtmlHelpers.GetDocumentAsync(defaultPage);

            // Act
            var liElement = (IHtmlUnorderedListElement)content.QuerySelector("main ul");

            // Assert
            Assert.True(liElement.Children.Length == 15, "Cantidad de items no esperada");
            // InvalidOperationException
            //Assert.Throws<FormatException>(() => Int32.Parse("123"));
        }
    }
}
