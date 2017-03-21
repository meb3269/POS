using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
			//Hide();

			Menu menu = new Menu();
			//menu.MdiParent = this.ParentForm;
			menu.StartPosition = FormStartPosition.CenterParent;
			menu.Show();
		}

		private void cashOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//this.Hide();

			CashOut cashOut = new CashOut();
			cashOut.Show();
		}
	}
}
