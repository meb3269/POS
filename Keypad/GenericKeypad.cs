using System;
using System.Windows.Forms;
using PosLibrary;

namespace Keypad
{
	public partial class GenericKeypad: UserControl
	{
		public GenericKeypad()
		{
			InitializeComponent();
		}

		#region Events

		//public event KeyPressEventHandler ButtonPressed;

		//public void RaiseButtonPressed(char WhatToSend)
		//{
		//	KeyPressEventHandler handler = ButtonPressed;

		//	if (handler != null)
		//	{
		//		handler(this, new KeyPressEventArgs(WhatToSend));
		//	}
		//}

		#endregion Events

		#region Methods

		string operand1 = string.Empty;
		string operand2 = string.Empty;
		public string accumulator = string.Empty;
		string result;
		char operation;

		public string Operator_Pressed(object sender, EventArgs e, string display)
		{
			char operation = (sender as Button).Text[0];

			//if (operation == 'c')
			//{
			//	return string.Empty;
			//}

			accumulator += operation;

			switch (operation)
			{
				case '+':
					return btnPlus_Click(display);
				case '-':
					return btnMinus_Click(display);
				case '*':
					return btnMulitply_Click(display);
				case '/':
					return btnDivide_Click(display);
				case '=':
					return btnEqual_Click(display);
			}

			return string.Empty;
		}

		public string Number_Pressed(object sender, EventArgs e, string display)
		{
			string number = (sender as Button).Text;

			accumulator += number;

			return display == "0"
				? number
				: display + number;
		}

		private string btnPlus_Click(string display)
		{
			operand1 = display;
			operation = '+';
			return string.Empty;
		}

		private string btnMinus_Click(string display)
		{
			operand1 = display;
			operation = '-';
			return string.Empty;
		}

		private string btnMulitply_Click(string display)
		{
			operand1 = display;
			operation = '*';
			return string.Empty;
		}

		private string btnDivide_Click(string display)
		{
			operand1 = display;
			operation = '/';
			return string.Empty;
		}

		private string btnEqual_Click(string display)
		{
			operand2 = display;

			double opr1, opr2;
			double.TryParse(operand1, out opr1);
			double.TryParse(operand2, out opr2);

			switch (operation)
			{
				case '+':
					result = Calculate.Add(opr1, opr2).ToString();
					break;
				case '-':
					result = Calculate.Subtract(opr1, opr2).ToString();
					break;
				case '*':
					result = Calculate.Multiply(opr1, opr2).ToString();
					break;
				case '/':
					result = Calculate.Divide(opr1, opr2).ToString();
					break;
			}

			//return accumulator + " " + result;
			return result;
		}

		#endregion Methods
	}
}