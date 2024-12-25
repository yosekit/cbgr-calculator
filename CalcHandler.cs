namespace WinDescCalc;

public class CalcHandler
{
	private const string _DefaultEntry = "0";

	private string _leftValue = string.Empty;
	private string _operation = string.Empty;

	private bool _isEntry = false;
	private bool _isDoubleEntry = false;

	public Action<string> RenderEntry { get; set; }
	public Action<string> RenderOutput { get; set; }

	public void HandleNumInput(string entry, string symbol)
	{
		string r = !_isEntry ? symbol : entry + symbol;
		RenderEntry(r);

		if (!_isEntry) _isEntry = true;
	}

	public void HandleSingInput(string entry)
	{
		string r = Negate(entry);
		RenderEntry(r);

		if (!_isEntry) _isEntry = true;
	}

	public void HandlePointInput(string entry, string symbol)
	{
		if (_isDoubleEntry) return;

		string r = entry + symbol;
		RenderEntry(r);

		_isDoubleEntry = true;

		if (!_isEntry) _isEntry = true;
	}

	public void HandleClearEntry()
	{
		_isEntry = false;

		RenderEntry(_DefaultEntry);
	}

	public void HandleClear()
	{
		HandleClearEntry();

		_leftValue = string.Empty;
		_operation = string.Empty;

		RenderOutput(string.Empty);
	}

	public void HandleBackspace(string entry)
	{
		if (entry.Length > 1)
			RenderEntry(entry[..^1]);
		else
			HandleClearEntry();
	}

	public void HandleUnaryOperation(string entry, string output, string name)
	{
		string value = entry;
		string result = CalcEngine.Calculate(value, name);
		RenderEntry(result);

		string r = name switch
		{
			"Reverse" => $"1/({value})",
			"Pow2" => $"{value}^2",
			"Sqrt" => $"sqrt({value})",
			_ => string.Empty
		};
		RenderOutput(r);

		_isEntry = false;
	}

	public void HandleBinaryOperation(string entry, string output, string name, string symbol)
	{
		_leftValue = (_leftValue == string.Empty) ?
			entry :
			CalcEngine.Calculate(_leftValue, entry, _operation);

		_operation = name;

		RenderOutput(_leftValue + $" {symbol} ");
		RenderEntry(_leftValue);

		_isEntry = false;
	}

	public void HandleEqual(string entry, string output)
	{
		if (_leftValue == string.Empty) return;

		string result = CalcEngine.Calculate(_leftValue, entry, _operation);

		RenderOutput(output + entry + " = ");
		RenderEntry(result);

		_leftValue = string.Empty;
	}

	static string Negate(string number) =>
		number.StartsWith('-') ? number[1..] : "-" + number;

	static string Format(string number) =>
		int.Parse(number).ToString("N0");
}
