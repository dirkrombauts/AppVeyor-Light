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
            var gateway = new AppVeyorGateway();

            var projects = gateway.GetProjects();

            Check.That(projects).IsNotNull();
        }
    }
}
