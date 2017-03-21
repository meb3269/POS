namespace FoodMenu
{
	partial class MenuItemEntry
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cboItemCategory = new System.Windows.Forms.ComboBox();
			this.txtItemName = new System.Windows.Forms.TextBox();
			this.txtItemDescription = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cboItemCategory
			// 
			this.cboItemCategory.FormattingEnabled = true;
			this.cboItemCategory.Location = new System.Drawing.Point(48, 106);
			this.cboItemCategory.Name = "cboItemCategory";
			this.cboItemCategory.Size = new System.Drawing.Size(121, 21);
			this.cboItemCategory.TabIndex = 0;
			this.cboItemCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// txtItemName
			// 
			this.txtItemName.Location = new System.Drawing.Point(201, 106);
			this.txtItemName.Name = "txtItemName";
			this.txtItemName.Size = new System.Drawing.Size(100, 20);
			this.txtItemName.TabIndex = 1;
			// 
			// txtItemDescription
			// 
			this.txtItemDescription.Location = new System.Drawing.Point(326, 107);
			this.txtItemDescription.Name = "txtItemDescription";
			this.txtItemDescription.Size = new System.Drawing.Size(337, 20);
			this.txtItemDescription.TabIndex = 2;
			// 
			// MenuItemEntry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtItemDescription);
			this.Controls.Add(this.txtItemName);
			this.Controls.Add(this.cboItemCategory);
			this.Name = "MenuItemEntry";
			this.Size = new System.Drawing.Size(900, 600);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cboItemCategory;
		private System.Windows.Forms.TextBox txtItemName;
		private System.Windows.Forms.TextBox txtItemDescription;
	}
}
