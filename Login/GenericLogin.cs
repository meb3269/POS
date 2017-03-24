using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login
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
		}
	}
}
