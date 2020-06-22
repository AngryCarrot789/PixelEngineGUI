using FunPixelEngine.Themes;
using PixelEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FunPixelEngine.Controls
{
    public class ListboxItem
    {
        public Pixel background;
        public Pixel normalBackground;

        public int Width, Height;

        public int X, Y;

        public bool IsFocused { get; set; }

        public string Text { get; set; }

        public bool MouseOver { get; set; }

        public Listbox Parent { get; set; }

        public ListboxItem(Pixel bckgrnd, string text = "text", int height = 80, int width = -1)
        {
            background = bckgrnd;
            normalBackground = bckgrnd;
            Width = width; Height = height;
            Text = text;
        }

        public void Update(int mPosX, int mPosY, Input input)
        {
            if (mPosX > X && mPosY > Y)
            {
                if (mPosX < X + Width && mPosY < Y + Height)
                    OnMouseEnter();
                else
                    OnMouseLeave();
            }
            else
                OnMouseLeave();

            if (MouseOver)
            {
                if (input.Down)
                    MouseDown();
            }
        }

        public void OnMouseEnter()
        {
            background = DarkTheme.ControlMouseOverBackground;
            MouseOver = true;
        }

        public void OnMouseLeave()
        {
            if (!IsFocused)
            {
                background = normalBackground;
            }
            MouseOver = false;
        }

        public void MouseDown()
        {
            IsFocused = true;
            Click();
        }

        public void Click()
        {
            background = DarkTheme.ControlSelectedBackground;
        }

        public void Focus()
        {
            Click();
        }
    }
}
