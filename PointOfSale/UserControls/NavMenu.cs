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
			NavMenu nav = new NavMenu();
			nav.Location = new Point(0,0);

			MenuControl menu = new MenuControl();
			menu.Location = new Point(20, 30);

			Form baseForm = this.FindForm();
			baseForm.Controls.Clear();
			baseForm.Controls.Add(nav);
			baseForm.Controls.Add(menu);
		}

		private void cashOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NavMenu nav = new NavMenu();
			nav.Location = new Point(0, 0);

			RegisterKeypad registerKeypad = new RegisterKeypad();
			registerKeypad.Location = new Point(20, 100);

			Form baseForm = this.FindForm();
			baseForm.Controls.Clear();
			baseForm.Controls.Add(nav);
			baseForm.Controls.Add(registerKeypad);
		}
	}
}