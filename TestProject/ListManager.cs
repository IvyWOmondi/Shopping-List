using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProject
{
    internal class ListManager
    {
        private readonly List<string> _items = new();

        public ListManager()
        {
        }

        internal AddtoListResponse AddtoList(AddtoListRequest request)
        {
            if (request?.Item?.Name is not null && !_items.Contains(request.Item.Name))
            {
                _items.Add(request.Item.Name);
            }

            return new AddtoListResponse()
            {
                // return current state as AddtoListItem[]
                Item = _items.Select(n => new AddtoListItem { Name = n }).ToArray()
            };
        }

        internal RemovefromListResponse RemovefromList(RemovefromListRequest request)
        {
            if (request?.NoItem?.Name is not null)
            {
                _items.Remove(request.NoItem.Name);
            }

            return new RemovefromListResponse()
            {
                // return current state as RemovefromListItem[]
                NoItem = _items.Select(n => new RemovefromListItem { Name = n }).ToArray()
            };
        }
    }
}