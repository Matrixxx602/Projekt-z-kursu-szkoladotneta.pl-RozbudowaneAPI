﻿using MovieManagement;
using MovieManagement.Application.Directors.Queries.GetDirectorDetail;
using Shouldly;
using System.Threading.Tasks;
using WebApi.IntegrationTests.Common;
using Xunit;

namespace WebApi.IntegrationTests.Controllers.Directors
{
    public class GetDetails_Tests : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly CustomWebApplicationFactory<Startup> _factory;

        public GetDetails_Tests(CustomWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GivenDirectorsId_ReturnDirectorsDetail()
        {
            var client = await _factory.GetAuthenticatedClientAsync();

            string id = "1";
            var response = await client.GetAsync($"/api/directors/{id}");
            response.EnsureSuccessStatusCode();

            var vm = await Utilities.GetResponseContent<DirectorDetailVm>(response);
            vm.ShouldNotBeNull();
        }
    }
}
