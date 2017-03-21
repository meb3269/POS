namespace PointOfSale
{
	partial class AppWindow
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
			this.label1 = new System.Windows.Forms.Label();
			this.lblCompany = new System.Windows.Forms.Label();
			this.navMenu1 = new PointOfSale.UserControls.NavMenu();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(297, 242);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(390, 37);
			this.label1.TabIndex = 1;
			this.label1.Text = "Point of Sale Application";
			// 
			// lblCompany
			// 
			this.lblCompany.AutoSize = true;
			this.lblCompany.Location = new System.Drawing.Point(431, 359);
			this.lblCompany.Name = "lblCompany";
			this.lblCompany.Size = new System.Drawing.Size(143, 13);
			this.lblCompany.TabIndex = 2;
			this.lblCompany.Text = "Customer Name or logo Here";
			// 
			// navMenu1
			// 
			this.navMenu1.Location = new System.Drawing.Point(6, 6);
			this.navMenu1.Name = "navMenu1";
			this.navMenu1.Size = new System.Drawing.Size(900, 50);
			this.navMenu1.TabIndex = 3;
			// 
			// AppWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 762);
			this.Controls.Add(this.navMenu1);
			this.Controls.Add(this.lblCompany);
			this.Controls.Add(this.label1);
			this.Name = "AppWindow";
			this.Text = "Point of Sale";
			this.IsMdiContainer = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblCompany;
		private UserControls.NavMenu navMenu1;
	}
}