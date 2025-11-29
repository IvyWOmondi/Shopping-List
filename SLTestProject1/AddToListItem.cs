namespace SLTestProject1
{
    internal class AddToListItem
    {
        public AddToListItem()
        {
            Items = new System.Collections.Generic.List<string>();
        }

        public System.Collections.Generic.List<string> Items { get; set; } = new();

        // Optional compatibility accessor: maps a single value to the collection
        public string List
        {
            get => Items.Count > 0 ? Items[0] : null;
            set
            {
                Items.Clear();
                if (value != null) Items.Add(value);
            }
        }
    }
}