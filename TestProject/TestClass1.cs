using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class TestClass1
    {
        public object Name { get; private set; }

        [SetUp]
        public void SetUp()
        { }

        [Test]
        public void Addtolist()
        {
            var item = new AddtoListItem()
            { Name = "Milk" };

            var request = new AddtoListRequest()
            { Item = item };

            var manager = new ListManager();
            AddtoListResponse response = manager.AddtoList(request);

            Assert.That(response, Is.Not.Null);
            // robust containment check by Name (avoids relying on reference equality)
            Assert.That(response.Item.Any(i => i.Name == "Milk"), Is.True);
        }

        [Test]
        public void Removefromlist()
        {
            var manager = new ListManager();

            // ensure milk exists first
            manager.AddtoList(new AddtoListRequest { Item = new AddtoListItem { Name = "Milk" } });

            var nonitem = new RemovefromListItem()
            { Name = "Milk" };

            var request = new RemovefromListRequest()
            { NoItem =   nonitem };

            RemovefromListResponse response = manager.RemovefromList(request);

            Assert.That(response, Is.Not.Null);

            // assert that no remaining item has Name == "Milk"
            Assert.That(response.NoItem.Any(n => n.Name == "Milk"), Is.False);
        }
    }
}


