using System;
using System.Collections.Generic;

namespace Katas
{
    public class Test2
    {
    }
    public class Kyu5PaginationHelper<T>
    {

        private int itemsPerPage;
        private IList<T> collection;

        public Kyu5PaginationHelper(IList<T> collection, int itemsPerPage)
        {
            this.collection = collection;
            this.itemsPerPage = itemsPerPage;
        }

        public int ItemCount => collection.Count;

        public int PageCount => (ItemCount / itemsPerPage) + (ItemCount % itemsPerPage > 0 ? 1: 0);

        public int PageItemCount(int pageIndex)
        {
            if (pageIndex < 0 || pageIndex >= PageCount) return -1;
            if (pageIndex == PageCount - 1) return ItemCount % itemsPerPage;
            return itemsPerPage;
        }

        public int PageIndex(int itemIndex)
        {
            if (itemIndex < 0 || itemIndex >= ItemCount) return -1;
            if (itemIndex % itemsPerPage == 0) return (itemIndex / itemsPerPage);
            return (itemIndex / itemsPerPage);
        }
    }
}