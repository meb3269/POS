using System.Windows.Forms;

namespace Display
{
	public partial class GenericDisplay: UserControl
	{
		public GenericDisplay()
		{
			InitializeComponent();
		}

		#region Events

		public event KeyPressEventHandler ClearButton;

		#endregion Events

		public void ClearDisplay(object sender, KeyPressEventArgs e)
		{
			KeyPressEventHandler handler = ClearButton;

			if (handler != null)
			{
				this.Controls.Clear();
			}
		}
	}
}