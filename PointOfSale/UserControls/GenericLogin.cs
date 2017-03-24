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
	public partial class GenericLogin : UserControl
	{
		public GenericLogin()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			var userName = txtUserName.Text;
			var password = txtPassword.Text;

			var isAuth = Authenticate(userName, password);

			if (isAuth)
			{
				SetAuthFormStatus();
			}
		}

		private bool Authenticate(string userName, string password)
		{
			//Build true data driven login solution

			bool retVal = userName == "Mike" && password == "Black";

			return retVal;
		}

		private void SetAuthFormStatus()
		{
			NavMenu nav = new NavMenu();
			nav.Location = new Point(0, 0);

			Form baseForm = this.FindForm();
			baseForm.Controls.Clear();
			baseForm.Controls.Add(nav);
		}
	}
}
