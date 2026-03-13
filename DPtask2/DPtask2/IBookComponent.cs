using System;
using System.Collections.Generic;
using System.Text;

namespace DPtask2
{
    interface IBookComponent
    {
        int GetPages();
    }

    class Book : IBookComponent
    {
        private int pages;

        public Book(int pages)
        {
            this.pages = pages;
        }

        public int GetPages()
        {
            return pages;
        }
    }

    class Box : IBookComponent
    {
        private List<IBookComponent> items = new List<IBookComponent>();

        public void Add(IBookComponent item)
        {
            items.Add(item);
        }

        public int GetPages()
        {
            int total = 0;

            foreach (var item in items)
            {
                total += item.GetPages();
            }

            return total;
        }
    }
}
