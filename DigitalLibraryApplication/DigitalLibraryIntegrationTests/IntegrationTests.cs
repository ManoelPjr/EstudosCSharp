using System;
using System.Net.Http;
using System.Threading.Tasks;
using DigitalLibraryApplication;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Xunit;

namespace DigitalLibraryIntegrationTests
{
    public class IntegrationTests
    {
        public HttpClient _client;
        private readonly TestServer _server;
        public IntegrationTests()
        {
            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            _client = _server.CreateClient();
        }
        
        [Fact]
        public async Task Description_NoCondition_Success()
        {
            var response = await _client.GetAsync("/Welcome/Description");
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Equal("This is the application for managing digital books!",
                responseString);
        }
    }
}
