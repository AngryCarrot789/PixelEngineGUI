using FunPixelEngine.Controls;
using FunPixelEngine.Themes;
using PixelEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FunPixelEngine
{
	public class Program
	{
		static void Main(string[] args)
		{
			Prog p = new Prog(); p.Main();
		}

		public class Prog
        {
			public List<Button> buttons = new List<Button>();
			public List<Listbox> listboxes = new List<Listbox>();
			public void Main()
			{
				Button b1 = new Button(DarkTheme.ControlDefaultBackground, 10, 10, 100, 75, "hell0");
				Button b2 = new Button(DarkTheme.ControlDefaultBackground, 120, 10, 250, 75, "a btn");
				Button b3 = new Button(DarkTheme.ControlDefaultBackground, 10, 95, 360, 100, "another btn xddd");
				b1.Clicked += B1_Clicked;
				b2.Clicked += B1_Clicked;
				b3.Clicked += B1_Clicked;

				Listbox lb = new Listbox(DarkTheme.ContainerBackgroundColour, 10, 215, 400, 500);
				lb.AddItem(new ListboxItem(DarkTheme.ControlDefaultBackground, "listbox1"));
				lb.AddItem(new ListboxItem(DarkTheme.ControlDefaultBackground, "listbox2"));
				lb.AddItem(new ListboxItem(DarkTheme.ControlDefaultBackground, "listbox3"));
				lb.AddItem(new ListboxItem(DarkTheme.ControlDefaultBackground, "listbox4"));
				listboxes.Add(lb);

				buttons.Add(b1);
				buttons.Add(b2);
				buttons.Add(b3);

				GameEngine ge = new GameEngine(this);
				ge.Construct(1280, 720, 1, 1, 60);
				ge.Start();
			}

            private void B1_Clicked(Button sender)
            {
				Console.WriteLine($"Button who's content is '{sender.Text}' has been clicked xdddddd");
			}
		}

		// Velocity.x = (olc::GetKey(olc::RIGHT) - olc::GetKey(olc::Left)) * speed;
        // Velocity.y = (olc::GetKey(olc::DOWN) - olc::GetKey(olc::UP)) * speed; 
	}
}
