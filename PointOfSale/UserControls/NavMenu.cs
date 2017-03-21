using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Keypad;
using FoodMenu;

namespace PointOfSale.UserControls
{
	public partial class NavMenu : UserControl
	{
		public NavMenu()
		{
			InitializeComponent();
		}

		private void menuToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//this.ParentForm.Controls.Clear();

			var x = 20;
			var y = 30;

			FoodMenu.FoodMenu menu = new FoodMenu.FoodMenu();
			menu.Location = new Point(x, y);

			//this.ParentForm.Controls.Add(menu);
		}

		private void cashOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//this.ParentForm.Controls.Clear();

			var x = 20;
			var y = 100;

			RegisterKeypad registerKeypad = new RegisterKeypad();
			registerKeypad.Location = new Point(x, y);

			//this.ParentForm.Controls.Add(registerKeypad);
		}
	}
}
