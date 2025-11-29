namespace SLTestProject1
{
    internal class RemoveFromListItem
    {
        public RemoveFromListItem()
        {
            Items = new System.Collections.Generic.List<string>();
        }
        public System.Collections.Generic.IList<string> Items { get; }

        // Optional single-item compatibility accessor (mirrors AddToListItem)
        public string Item
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