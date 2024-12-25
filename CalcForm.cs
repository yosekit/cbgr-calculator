namespace WinDescCalc;

public partial class CalcForm : Form
{
	private readonly CalcHandler handler = new();
	public CalcForm()
	{
		InitializeComponent();

		handler.RenderEntry = content => textBoxEntry.Text = content;
		handler.RenderOutput = content => textBoxOutput.Text = content;
	}

	private void btnNum_Click(object sender, EventArgs e)
	{
		var button = sender as Button;
		handler.HandleNumInput(textBoxEntry.Text, button.Text);
	}

	private void btnSign_Click(object sender, EventArgs e)
	{
		var button = sender as Button;
		handler.HandleSingInput(textBoxEntry.Text);
	}

	private void btnPoint_Click(object sender, EventArgs e)
	{
		var button = sender as Button;
		handler.HandlePointInput(textBoxEntry.Text, button.Text);
	}

	private void btnClearEntry_Click(object sender, EventArgs e)
	{
		handler.HandleClearEntry();
	}

	private void btnClear_Click(object sender, EventArgs e)
	{
		handler.HandleClear();
	}

	private void btnBackspace_Click(object sender, EventArgs e)
	{
		handler.HandleBackspace(textBoxEntry.Text);
	}

	private void btnUnaryOperation_Click(object sender, EventArgs e)
	{
		var button = sender as Button;
		string operationName = button.Name.Replace("btn", string.Empty);

		handler.HandleUnaryOperation(textBoxEntry.Text, textBoxOutput.Text, operationName);
	}

	private void btnBinaryOperation_Click(object sender, EventArgs e)
	{
		var button = sender as Button;
		string operationSybmol = button.Text;
		string operationName = button.Name.Replace("btn", string.Empty);

		handler.HandleBinaryOperation(textBoxEntry.Text, textBoxOutput.Text, operationName, operationSybmol);
	}

	private void btnEqual_Click(object sender, EventArgs e)
	{
		handler.HandleEqual(textBoxEntry.Text, textBoxOutput.Text);
	}







}
