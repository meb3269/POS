namespace PointOfSale
{
	partial class CashOut
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.registerKeypad1 = new Keypad.RegisterKeypad();
			this.SuspendLayout();
			// 
			// registerKeypad1
			// 
			this.registerKeypad1.Location = new System.Drawing.Point(12, 123);
			this.registerKeypad1.Name = "registerKeypad1";
			this.registerKeypad1.Size = new System.Drawing.Size(305, 449);
			this.registerKeypad1.TabIndex = 0;
			// 
			// CashOut
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 662);
			this.Controls.Add(this.registerKeypad1);
			this.Name = "CashOut";
			this.Text = "Cash Out";
			this.ResumeLayout(false);

		}

		#endregion

		private Keypad.RegisterKeypad registerKeypad1;
	}
}

