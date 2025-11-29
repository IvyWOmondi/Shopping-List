namespace SLTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldAddItem()
        {
            var add = new AddToListItem()
            {
                Items =
                {
                    "milk",
                    "bread",
                    "eggs",
                    "juice",
                }
            };

        }

        [Test]
        public void ShouldRemoveItem()
        {
            var remove = new RemoveFromListItem();
            remove.Items.Remove("milk");
            remove.Items.Remove("bread");
            remove.Items.Remove("eggs");
            remove.Items.Remove("juice");
            remove.Item = "eggs";
            //Assert.That(remove.Items.Contains("eggs"), Is.False);
        }
    }
}