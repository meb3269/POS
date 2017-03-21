namespace FoodMenu
{
	partial class FoodMenu
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
			this.lbOrder = new System.Windows.Forms.ListBox();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.lbPlate = new System.Windows.Forms.ListBox();
			this.tabMenu = new System.Windows.Forms.TabControl();
			this.tabBreakfast = new System.Windows.Forms.TabPage();
			this.tabLunch = new System.Windows.Forms.TabPage();
			this.tabDinner = new System.Windows.Forms.TabPage();
			this.tabDessert = new System.Windows.Forms.TabPage();
			this.tabMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbOrder
			// 
			this.lbOrder.FormattingEnabled = true;
			this.lbOrder.Location = new System.Drawing.Point(34, 482);
			this.lbOrder.Name = "lbOrder";
			this.lbOrder.Size = new System.Drawing.Size(183, 108);
			this.lbOrder.TabIndex = 9;
			// 
			// btnNext
			// 
			this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.Location = new System.Drawing.Point(132, 413);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(85, 50);
			this.btnNext.TabIndex = 8;
			this.btnNext.Text = "NEXT";
			this.btnNext.UseMnemonic = false;
			this.btnNext.UseVisualStyleBackColor = true;
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(34, 413);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(85, 50);
			this.btnClear.TabIndex = 7;
			this.btnClear.Text = "CLEAR";
			this.btnClear.UseVisualStyleBackColor = true;
			// 
			// lbPlate
			// 
			this.lbPlate.FormattingEnabled = true;
			this.lbPlate.Location = new System.Drawing.Point(34, 71);
			this.lbPlate.Name = "lbPlate";
			this.lbPlate.Size = new System.Drawing.Size(183, 329);
			this.lbPlate.TabIndex = 6;
			// 
			// tabMenu
			// 
			this.tabMenu.Controls.Add(this.tabBreakfast);
			this.tabMenu.Controls.Add(this.tabLunch);
			this.tabMenu.Controls.Add(this.tabDinner);
			this.tabMenu.Controls.Add(this.tabDessert);
			this.tabMenu.Location = new System.Drawing.Point(235, 49);
			this.tabMenu.Name = "tabMenu";
			this.tabMenu.SelectedIndex = 0;
			this.tabMenu.Size = new System.Drawing.Size(631, 602);
			this.tabMenu.TabIndex = 5;
			// 
			// tabBreakfast
			// 
			this.tabBreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabBreakfast.Location = new System.Drawing.Point(4, 22);
			this.tabBreakfast.Name = "tabBreakfast";
			this.tabBreakfast.Size = new System.Drawing.Size(623, 576);
			this.tabBreakfast.TabIndex = 0;
			this.tabBreakfast.Text = "Breakfast";
			// 
			// tabLunch
			// 
			this.tabLunch.Location = new System.Drawing.Point(4, 22);
			this.tabLunch.Name = "tabLunch";
			this.tabLunch.Size = new System.Drawing.Size(623, 576);
			this.tabLunch.TabIndex = 1;
			this.tabLunch.Text = "Lunch";
			this.tabLunch.UseVisualStyleBackColor = true;
			// 
			// tabDinner
			// 
			this.tabDinner.Location = new System.Drawing.Point(4, 22);
			this.tabDinner.Name = "tabDinner";
			this.tabDinner.Size = new System.Drawing.Size(623, 576);
			this.tabDinner.TabIndex = 2;
			this.tabDinner.Text = "Dinner";
			this.tabDinner.UseVisualStyleBackColor = true;
			// 
			// tabDessert
			// 
			this.tabDessert.Location = new System.Drawing.Point(4, 22);
			this.tabDessert.Name = "tabDessert";
			this.tabDessert.Size = new System.Drawing.Size(623, 576);
			this.tabDessert.TabIndex = 3;
			this.tabDessert.Text = "Dessert";
			this.tabDessert.UseVisualStyleBackColor = true;
			// 
			// FoodMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lbOrder);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.lbPlate);
			this.Controls.Add(this.tabMenu);
			this.Name = "FoodMenu";
			this.Size = new System.Drawing.Size(900, 700);
			this.tabMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lbOrder;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.ListBox lbPlate;
		private System.Windows.Forms.TabControl tabMenu;
		private System.Windows.Forms.TabPage tabBreakfast;
		private System.Windows.Forms.TabPage tabLunch;
		private System.Windows.Forms.TabPage tabDinner;
		private System.Windows.Forms.TabPage tabDessert;
	}
}
