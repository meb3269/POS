namespace PosLibrary
{
	public static class Calculate
	{
		public static double Add(double val1, double val2)
		{
			return val1 + val2;
		}

		public static double Subtract(double val1, double val2)
		{
			return val1 - val2;
		}

		public static double Multiply(double val1, double val2)
		{
			return val1 * val2;
		}

		public static double Divide(double val1, double val2)
		{
			if (val2 != 0)
			{
				return val1/val2;
			}

			return 0;
		}
	}
}