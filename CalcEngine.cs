namespace WinDescCalc;

public static class CalcEngine
{
	public static string Calculate(string leftOperand, string rightOperand, string operationName)
	{
		var operation = GetBinaryOperation(operationName);

		double left = double.Parse(leftOperand);
		double right = double.Parse(rightOperand);

		double result = operation(left, right);

		return (result % 1 == 0) ? ((int)result).ToString() : result.ToString();
	}
	public static string Calculate(string operand, string operationName)
	{
		var operation = GetUnaryOperation(operationName);

		double value = double.Parse(operand);

		double result = operation(value);

		return (result % 1 == 0) ? ((int)result).ToString() : result.ToString();
	}

	static Func<double, double, double> GetBinaryOperation(string name)
	{
		var methodInfo = typeof(CalcEngine).GetMethod(name,
			System.Reflection.BindingFlags.Static |
			System.Reflection.BindingFlags.NonPublic
		);

		return (Func<double, double, double>)Delegate.CreateDelegate(
			typeof(Func<double, double, double>), methodInfo!);
	}
	static Func<double, double> GetUnaryOperation(string name)
	{
		var methodInfo = typeof(CalcEngine).GetMethod(name,
			System.Reflection.BindingFlags.Static |
			System.Reflection.BindingFlags.NonPublic
		);

		return (Func<double, double>)Delegate.CreateDelegate(
			typeof(Func<double, double>), methodInfo!);
	}

	static double Add(double x, double y) => x + y;
	static double Substract(double x, double y) => x - y;
	static double Multiply(double x, double y) => x * y;
	static double Divide(double x, double y) => x / y;

	static double Pow2(double x) => x * x;
	static double Sqrt(double x) => Math.Sqrt(x);
	static double Reverse(double x) => 1 / x;
}
