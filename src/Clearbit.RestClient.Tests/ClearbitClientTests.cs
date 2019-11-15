using Clearbit.Models.Requests;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PortableRest;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Reflection;
using System.Threading.Tasks;

namespace Clearbit.RestClient.Tests
{
    [TestClass]
    public class ClearbitClientTests
    {

        #region Private Members

        private IConfiguration Configuration { get; set; }

        #endregion

        #region Constructors

        public ClearbitClientTests()
        {
            // the type specified here is just so the secrets library can 
            // find the UserSecretId we added in the csproj file
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<ClearbitClientTests>();

            Configuration = builder.Build();
        }

        #endregion

        [TestMethod]
        public async Task GetEnrichmentCombinedAsync_ReturnsValidResult()
        {
            var client = new ClearbitClient(Configuration["ClearbitApiKey"]);
            var result = await client.GetEnrichmentCombinedAsync(new EnrichmentPersonRequest("robert@nimbleapps.cloud"), true);
            result.Should().NotBeNull();
            result.Content.Should().NotBeNull();

            result.Content.Person.Should().NotBeNull();
            var person = result.Content.Person;

            person.Id.Should().NotBeEmpty();
            person.Avatar.Should().NotBeNullOrWhiteSpace();

            person.Name.Should().NotBeNull();
            person.Name.FullName.Should().NotBeNullOrWhiteSpace();

            person.Geo.Should().NotBeNull();
            person.Geo.City.Should().NotBeNullOrWhiteSpace();

            person.Employment.Should().NotBeNull();
            person.Employment.Domain.Should().NotBeNullOrWhiteSpace();

            person.Gravatar.Should().NotBeNull();

            result.Content.Company.Should().NotBeNull();
            var company = result.Content.Company;

            company.Id.Should().NotBeEmpty();
            company.Site.Should().NotBeNull();
            company.Category.Should().NotBeNull();
            company.Tags.Should().NotHaveCount(0);

            company.Geo.Should().NotBeNull();

            company.LinkedIn.Should().NotBeNull();

            company.Twitter.Should().NotBeNull();
        }

        [TestMethod]
        public void BuildRequestQueryString_UsesCorrectNames()
        {
            var client = new ClearbitClient(Configuration["ClearbitApiKey"]);
            var enrichmentRequest = new EnrichmentCompanyRequest("nimbleapps.cloud")
            {
                CompanyName = "CloudNimble"
            };
            var request = new RestRequest("");
            client.BuildRequestQueryString(request, enrichmentRequest, new string[] { });

            var prop = typeof(RestRequest).GetProperty("UrlSegments", BindingFlags.NonPublic | BindingFlags.Instance);
            var getter = prop.GetGetMethod(nonPublic: true);
            var parameters = (IList)getter.Invoke(request, null);
            parameters.Should().HaveCount(2);

            var one = ToDynamic(parameters[1]);
            ((string)one.Key).Should().Be("domain");

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private dynamic ToDynamic(object value)
        {
            IDictionary<string, object> expando = new ExpandoObject();

            foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(value.GetType()))
                expando.Add(property.Name, property.GetValue(value));

            return expando as ExpandoObject;
        }

    }

}