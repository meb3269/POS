using System;
using System.Windows.Forms;

namespace Keypad
{
	public partial class RegisterKeypad : GenericKeypad
	{
		public RegisterKeypad()
		{
			InitializeComponent();
		}

		#region Custom Events

		//public event KeyPressEventHandler BackspaceButton;

		#endregion

		private bool isLastOperatorEquals = false;

		private void btn0_Click(object sender, EventArgs e)
		{
			if (isLastOperatorEquals)
			{
				ClearDisplayValue();
			}

			SetDisplayValue(Number_Pressed(sender, null, GetDisplayValue()));
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			if (isLastOperatorEquals)
			{
				ClearDisplayValue();
			}

			SetDisplayValue(Number_Pressed(sender, null, GetDisplayValue()));
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			if (isLastOperatorEquals)
			{
				ClearDisplayValue();
			}

			SetDisplayValue(Number_Pressed(sender, null, GetDisplayValue()));
		}

		private void btn3_Click(object sender, EventArgs e)
		{
			if (isLastOperatorEquals)
			{
				ClearDisplayValue();
			}

			SetDisplayValue(Number_Pressed(sender, null, GetDisplayValue()));
		}

		private void btn4_Click(object sender, EventArgs e)
		{
			if (isLastOperatorEquals)
			{
				ClearDisplayValue();
			}

			SetDisplayValue(Number_Pressed(sender, null, GetDisplayValue()));
		}

		private void btn5_Click(object sender, EventArgs e)
		{
			if (isLastOperatorEquals)
			{
				ClearDisplayValue();
			}

			SetDisplayValue(Number_Pressed(sender, null, GetDisplayValue()));
		}

		private void btn6_Click(object sender, EventArgs e)
		{
			if (isLastOperatorEquals)
			{
				ClearDisplayValue();
			}

			SetDisplayValue(Number_Pressed(sender, null, GetDisplayValue()));
		}

		private void btn7_Click(object sender, EventArgs e)
		{
			if (isLastOperatorEquals)
			{
				ClearDisplayValue();
			}

			SetDisplayValue(Number_Pressed(sender, null, GetDisplayValue()));
		}

		private void btn8_Click(object sender, EventArgs e)
		{
			if (isLastOperatorEquals)
			{
				ClearDisplayValue();
			}

			SetDisplayValue(Number_Pressed(sender, null, GetDisplayValue()));
		}

		private void btn9_Click(object sender, EventArgs e)
		{
			if (isLastOperatorEquals)
			{
				ClearDisplayValue();
			}

			SetDisplayValue(Number_Pressed(sender, null, GetDisplayValue()));
		}

		private void btnDecimal_Click(object sender, EventArgs e)
		{
			string display = GetDisplayValue();

			if (!display.Contains("."))
			{
				if (display == string.Empty)
				{
					SetDisplayValue("0" + Number_Pressed(sender, null, display));
				}
				else
				{
					SetDisplayValue(Number_Pressed(sender, null, display));
				}
			}
		}

		private void btnBackspace_Click(object sender, EventArgs e)
		{
			//this.BackspaceButton?.Invoke(this, null);
			string display = GetDisplayValue();
			//ToDo: backspace has a bug
			if (display.Length > 0)
			{
				SetDisplayValue(display.Substring(0, display.Length - 1));
			}
		}

		private void btnPlus_Click(object sender, EventArgs e)
		{
			string display = GetAccumulatorDisplayValue();

			if (display != string.Empty && !display.StartsWith("+"))
			{
				isLastOperatorEquals = false;
				SetDisplayValue(Operator_Pressed(sender, null, display));
			}
		}

		//ToDo: run if check for accumulator display on remaining operators

		private void btnMinus_Click(object sender, EventArgs e)
		{
			isLastOperatorEquals = false;
			SetDisplayValue(Operator_Pressed(sender, null, GetDisplayValue()));
		}

		private void btnMultiply_Click(object sender, EventArgs e)
		{
			isLastOperatorEquals = false;
			SetDisplayValue(Operator_Pressed(sender, null, GetDisplayValue()));
		}

		private void btnDivide_Click(object sender, EventArgs e)
		{
			isLastOperatorEquals = false;
			SetDisplayValue(Operator_Pressed(sender, null, GetDisplayValue()));
		}

		private void btnEqual_Click(object sender, EventArgs e)
		{
			isLastOperatorEquals = true;
			SetDisplayValue(Operator_Pressed(sender, null, GetDisplayValue()));
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearDisplayValue();
		}

		private void SetDisplayValue(string output)
		{
			txtRegisterKeypadDisplayMulti.Items[0] = accumulator;
			txtRegisterKeypadDisplayMulti.Items[1] = output;
		}

		private string GetDisplayValue()
		{
			return txtRegisterKeypadDisplayMulti.Items[1].ToString();
		}

		private string GetAccumulatorDisplayValue()
		{
			return txtRegisterKeypadDisplayMulti.Items[0].ToString();
		}

		private void ClearDisplayValue()
		{
			accumulator = string.Empty;
			txtRegisterKeypadDisplayMulti.Items[0] = string.Empty;
			txtRegisterKeypadDisplayMulti.Items[1] = string.Empty;
		}

		private void RegisterKeypad_Load(object sender, EventArgs e)
		{
			txtRegisterKeypadDisplayMulti.Items.Add("");
			txtRegisterKeypadDisplayMulti.Items.Add("");
		}
	}
}