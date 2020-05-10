using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_IA.Class.LV
{
	public class LineFunction : LMAFunction
	{
		public override double GetY(double x, double[] a)
		{
			return a[0] * x + a[1];
		}

		public override double GetPartialDerivative(double x, double[] a, int parameterIndex)
		{
			double result = 0;
			switch (parameterIndex)
			{
				case 0:
					result = x;
					break;
				case 1:
					result = 1;
					break;
				default:
					throw new ArgumentException("No such parameter index: " + parameterIndex);
			}
			return result;
		}
	}
}
