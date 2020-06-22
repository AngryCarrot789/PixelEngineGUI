using FunPixelEngine.Controls;
using FunPixelEngine.Helpers;
using FunPixelEngine.Themes;
using PixelEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static FunPixelEngine.Program;

namespace FunPixelEngine
{
	public class GameEngine : Game
	{
		public Prog program;
		public GameEngine(Prog prog)
        {
			program = prog;
        }

		int updown = 0, leftright = 0;
		public override void OnUpdate(float elapsed)
		{
			Clear(Pixel.Presets.Black);

			foreach (Button btn in program.buttons)
			{
				// update
				btn.Update(MouseX, MouseY, GetMouse(Mouse.Left));

				// render
				FillRect(new Point(btn.X, btn.Y), new Point(btn.X + btn.Width, btn.Y + btn.Height), btn.background);

				DrawText(new Point(btn.X + (btn.Width / 2) - (btn.Text.Length * 4), btn.Y + (btn.Height / 2)), btn.Text, DarkTheme.ControlForeground);
			}

			foreach (Listbox lb in program.listboxes)
			{
				// render
				FillRect(new Point(lb.X, lb.Y), new Point(lb.X + lb.Width, lb.Y + lb.Height), lb.background);

				foreach (ListboxItem lbi in lb.Items)
				{
					// update
					lbi.Update(MouseX, MouseY, GetMouse(Mouse.Left));

					// render
					FillRect(new Point(lbi.X, lbi.Y), new Point(lbi.X + lbi.Width, lbi.Y + lbi.Height), lbi.background);
					DrawText(new Point(lbi.X + (lbi.Width / 2) - (lbi.Text.Length * 4), lbi.Y + (lbi.Height / 2)), lbi.Text, DarkTheme.ControlForeground);
				}
			}

			FillCircle(new Point(MouseX, MouseY), 5, new Pixel(200, 100, 50));
		}

		public override void OnKeyDown(Key k)
		{
			base.OnKeyDown(k);
		}
	}
}
