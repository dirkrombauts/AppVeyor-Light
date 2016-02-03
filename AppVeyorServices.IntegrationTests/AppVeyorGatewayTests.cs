using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NFluent;

using NUnit.Framework;

namespace AppVeyorServices.IntegrationTests
{
    [TestFixture]
    public class AppVeyorGatewayTests
    {
        [Test]
        public void GetProjects_Always_ReturnsListOfProjects()
        {
            var apiToken = System.Configuration.ConfigurationManager.AppSettings["ApiKey"];
            var gateway = new AppVeyorGateway(apiToken);

            var projects = gateway.GetProjects();

            Check.That(projects).IsNotNull();

            var project = projects[0];

            Check.That(project.Name).IsNotNull();
            Check.That(project.Slug).IsNotNull();
            Check.That(project.AccountName).IsNotNull();
        }
    }
}
