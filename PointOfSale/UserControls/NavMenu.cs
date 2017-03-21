using System;
using System.Drawing;
using System.Windows.Forms;
using FoodMenu;
using Keypad;

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

			MenuControl menu = new MenuControl();
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
