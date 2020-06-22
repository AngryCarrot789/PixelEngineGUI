using FunPixelEngine.Helpers;
using FunPixelEngine.Themes;
using PixelEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunPixelEngine.Controls
{
    public class Button
    {
        public delegate void ClickedEventArgs(Button sender);
        public event ClickedEventArgs Clicked;
        public Pixel background;
        public Pixel normalBackground;
        public int X, Y, Width, Height;

        public string Text { get; set; }

        public bool MouseOver { get; set; }

        public Button(Pixel bckgrnd, int x = 10, int y = 10, int width = 200, int height = 80, string text = "text")
        {
            background = bckgrnd;
            normalBackground = bckgrnd;
            X = x; Y = y;
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
                if (input.Pressed)
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
            background = normalBackground;
            MouseOver = false;
        }

        public void MouseDown()
        {
            Click();
            background = DarkTheme.ControlMouseDownBackground;
        }

        public void Click()
        {
            Clicked?.Invoke(this);
        }
    }
}
