namespace PointOfSale
{
	partial class Menu
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
			this.foodMenu1 = new FoodMenu.FoodMenu();
			this.SuspendLayout();
			// 
			// foodMenu1
			// 
			this.foodMenu1.Location = new System.Drawing.Point(8, 6);
			this.foodMenu1.Name = "foodMenu1";
			this.foodMenu1.Size = new System.Drawing.Size(900, 700);
			this.foodMenu1.TabIndex = 0;
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(964, 712);
			this.Controls.Add(this.foodMenu1);
			this.Name = "Menu";
			this.Text = "Menu";
			this.ResumeLayout(false);

		}

		#endregion

		private FoodMenu.FoodMenu foodMenu1;
	}
}