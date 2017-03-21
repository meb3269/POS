using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PosLibrary;
using PosLibraryCode;

namespace FoodMenu
{
	public partial class FoodMenu : UserControl
	{
		public FoodMenu()
		{
			InitializeComponent();
		}


		public Order order;

		//ToDo: Add tabs for drinks, appetizers and sides?

		private void FoodMenu_Load(object sender, EventArgs e)
		{
			//Once DB is setup, pull the values from there using the Menu object
			ButtonFactory(MenuFactoryBreakfast());
			ButtonFactory(MenuFactoryLunch());

			order = new Order();
		}

		private void ButtonFactory(List<FoodMenuItem> items)
		{
			var x = 36;
			var y = 25;
			var buttonCounter = 0;
			var buttonRowSize = 5;
			var maxButtons = 40;

			foreach (FoodMenuItem item in items)
			{
				if (buttonCounter != maxButtons)
				{
					Point buttonLocation = new Point(x, y);

					Button newButton = new Button();
					newButton.Text = item.ItemName;
					newButton.Name = item.ItemName;
					newButton.Font = new Font(newButton.Font.Name, newButton.Font.Size, FontStyle.Bold);
					newButton.Size = new Size(105, 58);
					newButton.Location = buttonLocation;
					newButton.Click += GenericButtonClick;

					//Add to specific tab
					switch (item.ItemCategory)
					{
						case "Breakfast":
							{
								this.tabBreakfast.Controls.Add(newButton);
								break;
							}
						case "Lunch":
							{
								this.tabLunch.Controls.Add(newButton);
								break;
							}
						case "Dinner":
							{
								this.tabDinner.Controls.Add(newButton);
								break;
							}
						case "Dessert":
							{
								this.tabDessert.Controls.Add(newButton);
								break;
							}
					}

					buttonCounter++;
					x = x + 110;

					if (buttonCounter == buttonRowSize)
					{
						x = 36;
						y = y + 65;
						buttonRowSize = buttonRowSize + 5;
					}
				}
				else
				{
					//ToDo: Handle more than max buttons
				}
			}
		}

		private void GenericButtonClick(object sender, EventArgs e)
		{
			var button = sender as Button;
			if (button != null)
			{
				lbPlate.Items.Add(button.Text);
			}
		}

		#region Temporary Data Factories

		//Temp Factories until DB is up
		private List<FoodMenuItem> MenuFactoryBreakfast()
		{
			List<FoodMenuItem> items = new List<FoodMenuItem>();

			//Breakfast
			items.Add(new FoodMenuItem { ItemName = "Bacon", ItemCategory = "Breakfast" });
			items.Add(new FoodMenuItem { ItemName = "Eggs", ItemCategory = "Breakfast" });
			items.Add(new FoodMenuItem { ItemName = "Toast", ItemCategory = "Breakfast" });
			items.Add(new FoodMenuItem { ItemName = "Grits", ItemCategory = "Breakfast" });
			items.Add(new FoodMenuItem { ItemName = "Pancakes", ItemCategory = "Breakfast" });
			items.Add(new FoodMenuItem { ItemName = "Oatmeal", ItemCategory = "Breakfast" });
			items.Add(new FoodMenuItem { ItemName = "Waffle", ItemCategory = "Breakfast" });

			return items;
		}

		private List<FoodMenuItem> MenuFactoryLunch()
		{
			List<FoodMenuItem> items = new List<FoodMenuItem>();

			//Lunch
			items.Add(new FoodMenuItem { ItemName = "1", ItemCategory = "Lunch" });
			items.Add(new FoodMenuItem { ItemName = "2", ItemCategory = "Lunch" });
			items.Add(new FoodMenuItem { ItemName = "3", ItemCategory = "Lunch" });
			items.Add(new FoodMenuItem { ItemName = "4", ItemCategory = "Lunch" });
			items.Add(new FoodMenuItem { ItemName = "5", ItemCategory = "Lunch" });
			items.Add(new FoodMenuItem { ItemName = "6", ItemCategory = "Lunch" });
			items.Add(new FoodMenuItem { ItemName = "7", ItemCategory = "Lunch" });

			return items;
		}

		#endregion

		private void btnClear_Click(object sender, EventArgs e)
		{
			lbPlate.Items.Remove(lbPlate.SelectedItem);
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			Plate plate = new Plate();

			foreach (var item in lbPlate.Items)
			{
				FoodMenuItem foodItem = new FoodMenuItem();
				foodItem.ItemName = item.ToString();
				
				plate.PlateOrder.Add(foodItem);
				plate.PlateNumber = item.GetHashCode().ToString();
			}

			//Add Plate to order
			//order.plates.Add(plate);

			//Add order To lbOrder
			lbOrder.Items.AddRange(lbPlate.Items);

			//Clear items from lbPlate
			lbPlate.Items.Clear();

		}
	}
}