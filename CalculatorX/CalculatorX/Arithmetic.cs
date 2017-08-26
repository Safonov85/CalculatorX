using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorX
{
	public class Arithmetic
	{
		public string addition, subtraction, multiplicaiton, division;

		public double AddTowNumbers(string first, string second)
		{
			double result, firstValue, secondValue;
			firstValue = Convert.ToDouble(first);
			secondValue = Convert.ToDouble(second);
			result = firstValue + secondValue;

			return result;
		}

		public double SubtractTowNumbers(string first, string second)
		{
			double result, firstValue, secondValue;
			firstValue = Convert.ToDouble(first);
			secondValue = Convert.ToDouble(second);
			result = firstValue - secondValue;

			return result;
		}

		public double MultiplyTowNumbers(string first, string second)
		{
			double result, firstValue, secondValue;
			firstValue = Convert.ToDouble(first);
			secondValue = Convert.ToDouble(second);
			result = firstValue * secondValue;

			return result;
		}

		public double DivideTowNumbers(string first, string second)
		{
			double result, firstValue, secondValue;
			firstValue = Convert.ToDouble(first);
			secondValue = Convert.ToDouble(second);
			result = firstValue / secondValue;

			return result;
		}
	}
}
