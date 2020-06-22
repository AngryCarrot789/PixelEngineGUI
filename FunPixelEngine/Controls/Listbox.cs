using PixelEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunPixelEngine.Controls
{
    public class Listbox
    {
        public Pixel background;
        public List<ListboxItem> Items { get; set; }

        public int X, Y, Width, Height;

        private int totalHeightForYPos = 0;

        public Listbox(Pixel bckgrnd, int x = 10, int y = 10, int width = 250, int height = 250)
        {
            background = bckgrnd;
            X = x; Y = y;
            totalHeightForYPos = Y;
            Width = width; Height = height;

            Items = new List<ListboxItem>();
        }

        public void AddItem(ListboxItem lbi)
        {
            if (lbi != null)
            {
                if (lbi.Width == -1)
                    lbi.Width = Width;
                lbi.Y = totalHeightForYPos;
                lbi.X = X;
                totalHeightForYPos += lbi.Height;
                Items.Add(lbi);
            }
        }

        public void RemoveItem(ListboxItem lbi)
        {
            if (lbi != null)
            {
                totalHeightForYPos -= lbi.Height;
                Items.Remove(lbi);
            }
        }
    }
}
