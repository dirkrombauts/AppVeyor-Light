using System;

using NFluent;

using NUnit.Framework;

namespace AppVeyorLight.AppVeyorServices.IntegrationTests
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
            Check.That(project.Builds[0].Status[0]).IsNotNull();
        }
    }
}
