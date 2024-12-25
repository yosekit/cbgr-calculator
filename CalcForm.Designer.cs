namespace WinDescCalc
{
	partial class CalcForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcForm));
			textBoxOutput = new TextBox();
			contextMenuStrip1 = new ContextMenuStrip(components);
			textBoxEntry = new TextBox();
			btnBackspace = new CalcButton();
			btnPercent = new CalcButton();
			calcButton3 = new CalcButton();
			calcButton4 = new CalcButton();
			calcButton5 = new CalcButton();
			calcButton6 = new CalcButton();
			calcButton7 = new CalcButton();
			calcButton8 = new CalcButton();
			btnClearEntry = new CalcButton();
			btnClear = new CalcButton();
			btnDivide = new CalcButton();
			btnReverse = new CalcButton();
			btnPow2 = new CalcButton();
			btnSqrt = new CalcButton();
			btnMultiply = new CalcButton();
			btnNum7 = new CalcButton();
			btnNum8 = new CalcButton();
			btnNum9 = new CalcButton();
			btnSubstract = new CalcButton();
			btnNum4 = new CalcButton();
			btnNum5 = new CalcButton();
			btnNum6 = new CalcButton();
			btnAdd = new CalcButton();
			btnNum1 = new CalcButton();
			btnNum2 = new CalcButton();
			btnNum3 = new CalcButton();
			btnEqual = new CalcButton();
			btnSign = new CalcButton();
			btnNum0 = new CalcButton();
			btnPoint = new CalcButton();
			SuspendLayout();
			// 
			// textBoxOutput
			// 
			textBoxOutput.BackColor = Color.FromArgb(32, 32, 32);
			textBoxOutput.BorderStyle = BorderStyle.None;
			textBoxOutput.Dock = DockStyle.Top;
			textBoxOutput.Font = new Font("Gadugi", 14F);
			textBoxOutput.ForeColor = Color.Silver;
			textBoxOutput.Location = new Point(0, 0);
			textBoxOutput.Margin = new Padding(0, 10, 0, 0);
			textBoxOutput.Multiline = true;
			textBoxOutput.Name = "textBoxOutput";
			textBoxOutput.ReadOnly = true;
			textBoxOutput.Size = new Size(334, 28);
			textBoxOutput.TabIndex = 0;
			textBoxOutput.TabStop = false;
			textBoxOutput.TextAlign = HorizontalAlignment.Right;
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(61, 4);
			// 
			// textBoxEntry
			// 
			textBoxEntry.BackColor = Color.FromArgb(32, 32, 32);
			textBoxEntry.BorderStyle = BorderStyle.None;
			textBoxEntry.Dock = DockStyle.Top;
			textBoxEntry.Font = new Font("Gadugi", 32F);
			textBoxEntry.ForeColor = Color.White;
			textBoxEntry.Location = new Point(0, 28);
			textBoxEntry.Margin = new Padding(0);
			textBoxEntry.Multiline = true;
			textBoxEntry.Name = "textBoxEntry";
			textBoxEntry.ReadOnly = true;
			textBoxEntry.Size = new Size(334, 55);
			textBoxEntry.TabIndex = 1;
			textBoxEntry.TabStop = false;
			textBoxEntry.Text = "0";
			textBoxEntry.TextAlign = HorizontalAlignment.Right;
			// 
			// btnBackspace
			// 
			btnBackspace.BackColor = Color.FromArgb(60, 60, 60);
			btnBackspace.BackgroundColor = Color.FromArgb(60, 60, 60);
			btnBackspace.BorderColor = Color.FromArgb(32, 32, 32);
			btnBackspace.BorderRadius = 20;
			btnBackspace.BorderSize = 0;
			btnBackspace.FlatAppearance.BorderSize = 0;
			btnBackspace.FlatStyle = FlatStyle.Flat;
			btnBackspace.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnBackspace.ForeColor = Color.White;
			btnBackspace.Image = (Image)resources.GetObject("btnBackspace.Image");
			btnBackspace.Location = new Point(245, 123);
			btnBackspace.Margin = new Padding(0);
			btnBackspace.Name = "btnBackspace";
			btnBackspace.Size = new Size(80, 55);
			btnBackspace.TabIndex = 2;
			btnBackspace.TextColor = Color.White;
			btnBackspace.UseVisualStyleBackColor = false;
			btnBackspace.Click += btnBackspace_Click;
			// 
			// btnPercent
			// 
			btnPercent.BackColor = Color.FromArgb(60, 60, 60);
			btnPercent.BackgroundColor = Color.FromArgb(60, 60, 60);
			btnPercent.BorderColor = Color.FromArgb(32, 32, 32);
			btnPercent.BorderRadius = 20;
			btnPercent.BorderSize = 0;
			btnPercent.FlatAppearance.BorderSize = 0;
			btnPercent.FlatStyle = FlatStyle.Flat;
			btnPercent.Font = new Font("Gadugi", 12F);
			btnPercent.ForeColor = Color.White;
			btnPercent.Location = new Point(5, 122);
			btnPercent.Margin = new Padding(0);
			btnPercent.Name = "btnPercent";
			btnPercent.Size = new Size(80, 55);
			btnPercent.TabIndex = 3;
			btnPercent.Text = "%";
			btnPercent.TextColor = Color.White;
			btnPercent.UseVisualStyleBackColor = false;
			// 
			// calcButton3
			// 
			calcButton3.BackColor = Color.FromArgb(32, 32, 32);
			calcButton3.BackgroundColor = Color.FromArgb(32, 32, 32);
			calcButton3.BorderColor = Color.FromArgb(32, 32, 32);
			calcButton3.BorderRadius = 20;
			calcButton3.BorderSize = 0;
			calcButton3.FlatAppearance.BorderSize = 0;
			calcButton3.FlatStyle = FlatStyle.Flat;
			calcButton3.Font = new Font("Gadugi", 10F);
			calcButton3.ForeColor = Color.White;
			calcButton3.Location = new Point(269, 93);
			calcButton3.Margin = new Padding(0);
			calcButton3.Name = "calcButton3";
			calcButton3.Size = new Size(50, 30);
			calcButton3.TabIndex = 2;
			calcButton3.Text = "M~";
			calcButton3.TextColor = Color.White;
			calcButton3.UseVisualStyleBackColor = false;
			// 
			// calcButton4
			// 
			calcButton4.BackColor = Color.FromArgb(32, 32, 32);
			calcButton4.BackgroundColor = Color.FromArgb(32, 32, 32);
			calcButton4.BorderColor = Color.FromArgb(32, 32, 32);
			calcButton4.BorderRadius = 20;
			calcButton4.BorderSize = 0;
			calcButton4.FlatAppearance.BorderSize = 0;
			calcButton4.FlatStyle = FlatStyle.Flat;
			calcButton4.Font = new Font("Gadugi", 10F);
			calcButton4.ForeColor = Color.White;
			calcButton4.Location = new Point(219, 93);
			calcButton4.Margin = new Padding(0);
			calcButton4.Name = "calcButton4";
			calcButton4.Size = new Size(50, 30);
			calcButton4.TabIndex = 2;
			calcButton4.Text = "MS";
			calcButton4.TextColor = Color.White;
			calcButton4.UseVisualStyleBackColor = false;
			// 
			// calcButton5
			// 
			calcButton5.BackColor = Color.FromArgb(32, 32, 32);
			calcButton5.BackgroundColor = Color.FromArgb(32, 32, 32);
			calcButton5.BorderColor = Color.FromArgb(32, 32, 32);
			calcButton5.BorderRadius = 20;
			calcButton5.BorderSize = 0;
			calcButton5.FlatAppearance.BorderSize = 0;
			calcButton5.FlatStyle = FlatStyle.Flat;
			calcButton5.Font = new Font("Gadugi", 10F);
			calcButton5.ForeColor = Color.White;
			calcButton5.Location = new Point(169, 93);
			calcButton5.Margin = new Padding(0);
			calcButton5.Name = "calcButton5";
			calcButton5.Size = new Size(50, 30);
			calcButton5.TabIndex = 2;
			calcButton5.Text = "M-";
			calcButton5.TextColor = Color.White;
			calcButton5.UseVisualStyleBackColor = false;
			// 
			// calcButton6
			// 
			calcButton6.BackColor = Color.FromArgb(32, 32, 32);
			calcButton6.BackgroundColor = Color.FromArgb(32, 32, 32);
			calcButton6.BorderColor = Color.FromArgb(32, 32, 32);
			calcButton6.BorderRadius = 20;
			calcButton6.BorderSize = 0;
			calcButton6.FlatAppearance.BorderSize = 0;
			calcButton6.FlatStyle = FlatStyle.Flat;
			calcButton6.Font = new Font("Gadugi", 10F);
			calcButton6.ForeColor = Color.White;
			calcButton6.Location = new Point(119, 93);
			calcButton6.Margin = new Padding(0);
			calcButton6.Name = "calcButton6";
			calcButton6.Size = new Size(50, 30);
			calcButton6.TabIndex = 2;
			calcButton6.Text = "M+";
			calcButton6.TextColor = Color.White;
			calcButton6.UseVisualStyleBackColor = false;
			// 
			// calcButton7
			// 
			calcButton7.BackColor = Color.FromArgb(32, 32, 32);
			calcButton7.BackgroundColor = Color.FromArgb(32, 32, 32);
			calcButton7.BorderColor = Color.FromArgb(32, 32, 32);
			calcButton7.BorderRadius = 20;
			calcButton7.BorderSize = 0;
			calcButton7.FlatAppearance.BorderSize = 0;
			calcButton7.FlatStyle = FlatStyle.Flat;
			calcButton7.Font = new Font("Gadugi", 10F);
			calcButton7.ForeColor = Color.White;
			calcButton7.Location = new Point(69, 93);
			calcButton7.Margin = new Padding(0);
			calcButton7.Name = "calcButton7";
			calcButton7.Size = new Size(50, 30);
			calcButton7.TabIndex = 2;
			calcButton7.Text = "MR";
			calcButton7.TextColor = Color.White;
			calcButton7.UseVisualStyleBackColor = false;
			// 
			// calcButton8
			// 
			calcButton8.BackColor = Color.FromArgb(32, 32, 32);
			calcButton8.BackgroundColor = Color.FromArgb(32, 32, 32);
			calcButton8.BorderColor = Color.FromArgb(32, 32, 32);
			calcButton8.BorderRadius = 20;
			calcButton8.BorderSize = 0;
			calcButton8.FlatAppearance.BorderSize = 0;
			calcButton8.FlatStyle = FlatStyle.Flat;
			calcButton8.Font = new Font("Gadugi", 10F);
			calcButton8.ForeColor = Color.White;
			calcButton8.Location = new Point(19, 93);
			calcButton8.Margin = new Padding(0);
			calcButton8.Name = "calcButton8";
			calcButton8.Size = new Size(50, 30);
			calcButton8.TabIndex = 2;
			calcButton8.Text = "MC";
			calcButton8.TextColor = Color.White;
			calcButton8.UseVisualStyleBackColor = false;
			// 
			// btnClearEntry
			// 
			btnClearEntry.BackColor = Color.FromArgb(60, 60, 60);
			btnClearEntry.BackgroundColor = Color.FromArgb(60, 60, 60);
			btnClearEntry.BorderColor = Color.FromArgb(32, 32, 32);
			btnClearEntry.BorderRadius = 20;
			btnClearEntry.BorderSize = 0;
			btnClearEntry.FlatAppearance.BorderSize = 0;
			btnClearEntry.FlatStyle = FlatStyle.Flat;
			btnClearEntry.Font = new Font("Gadugi", 12F);
			btnClearEntry.ForeColor = Color.White;
			btnClearEntry.Location = new Point(85, 122);
			btnClearEntry.Margin = new Padding(0);
			btnClearEntry.Name = "btnClearEntry";
			btnClearEntry.Size = new Size(80, 55);
			btnClearEntry.TabIndex = 3;
			btnClearEntry.Text = "CE";
			btnClearEntry.TextColor = Color.White;
			btnClearEntry.UseVisualStyleBackColor = false;
			btnClearEntry.Click += btnClearEntry_Click;
			// 
			// btnClear
			// 
			btnClear.BackColor = Color.FromArgb(60, 60, 60);
			btnClear.BackgroundColor = Color.FromArgb(60, 60, 60);
			btnClear.BorderColor = Color.FromArgb(32, 32, 32);
			btnClear.BorderRadius = 20;
			btnClear.BorderSize = 0;
			btnClear.FlatAppearance.BorderSize = 0;
			btnClear.FlatStyle = FlatStyle.Flat;
			btnClear.Font = new Font("Gadugi", 12F);
			btnClear.ForeColor = Color.White;
			btnClear.Location = new Point(165, 123);
			btnClear.Margin = new Padding(0);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(80, 55);
			btnClear.TabIndex = 3;
			btnClear.Text = "C";
			btnClear.TextColor = Color.White;
			btnClear.UseVisualStyleBackColor = false;
			btnClear.Click += btnClear_Click;
			// 
			// btnDivide
			// 
			btnDivide.BackColor = Color.FromArgb(60, 60, 60);
			btnDivide.BackgroundColor = Color.FromArgb(60, 60, 60);
			btnDivide.BorderColor = Color.FromArgb(32, 32, 32);
			btnDivide.BorderRadius = 20;
			btnDivide.BorderSize = 0;
			btnDivide.FlatAppearance.BorderSize = 0;
			btnDivide.FlatStyle = FlatStyle.Flat;
			btnDivide.Font = new Font("Gadugi", 16F);
			btnDivide.ForeColor = Color.White;
			btnDivide.Location = new Point(245, 178);
			btnDivide.Margin = new Padding(0);
			btnDivide.Name = "btnDivide";
			btnDivide.Size = new Size(80, 55);
			btnDivide.TabIndex = 2;
			btnDivide.Text = "÷";
			btnDivide.TextColor = Color.White;
			btnDivide.UseVisualStyleBackColor = false;
			btnDivide.Click += btnBinaryOperation_Click;
			// 
			// btnReverse
			// 
			btnReverse.BackColor = Color.FromArgb(60, 60, 60);
			btnReverse.BackgroundColor = Color.FromArgb(60, 60, 60);
			btnReverse.BorderColor = Color.FromArgb(32, 32, 32);
			btnReverse.BorderRadius = 20;
			btnReverse.BorderSize = 0;
			btnReverse.FlatAppearance.BorderSize = 0;
			btnReverse.FlatStyle = FlatStyle.Flat;
			btnReverse.Font = new Font("Gadugi", 12F);
			btnReverse.ForeColor = Color.White;
			btnReverse.Location = new Point(5, 177);
			btnReverse.Margin = new Padding(0);
			btnReverse.Name = "btnReverse";
			btnReverse.Size = new Size(80, 55);
			btnReverse.TabIndex = 3;
			btnReverse.Text = "1/x";
			btnReverse.TextColor = Color.White;
			btnReverse.UseVisualStyleBackColor = false;
			btnReverse.Click += btnUnaryOperation_Click;
			// 
			// btnPow2
			// 
			btnPow2.BackColor = Color.FromArgb(60, 60, 60);
			btnPow2.BackgroundColor = Color.FromArgb(60, 60, 60);
			btnPow2.BorderColor = Color.FromArgb(32, 32, 32);
			btnPow2.BorderRadius = 20;
			btnPow2.BorderSize = 0;
			btnPow2.FlatAppearance.BorderSize = 0;
			btnPow2.FlatStyle = FlatStyle.Flat;
			btnPow2.Font = new Font("Gadugi", 12F);
			btnPow2.ForeColor = Color.White;
			btnPow2.Location = new Point(85, 177);
			btnPow2.Margin = new Padding(0);
			btnPow2.Name = "btnPow2";
			btnPow2.Size = new Size(80, 55);
			btnPow2.TabIndex = 3;
			btnPow2.Text = "x^2";
			btnPow2.TextColor = Color.White;
			btnPow2.UseVisualStyleBackColor = false;
			btnPow2.Click += btnUnaryOperation_Click;
			// 
			// btnSqrt
			// 
			btnSqrt.BackColor = Color.FromArgb(60, 60, 60);
			btnSqrt.BackgroundColor = Color.FromArgb(60, 60, 60);
			btnSqrt.BorderColor = Color.FromArgb(32, 32, 32);
			btnSqrt.BorderRadius = 20;
			btnSqrt.BorderSize = 0;
			btnSqrt.FlatAppearance.BorderSize = 0;
			btnSqrt.FlatStyle = FlatStyle.Flat;
			btnSqrt.Font = new Font("Gadugi", 12F);
			btnSqrt.ForeColor = Color.White;
			btnSqrt.Location = new Point(165, 178);
			btnSqrt.Margin = new Padding(0);
			btnSqrt.Name = "btnSqrt";
			btnSqrt.Size = new Size(80, 55);
			btnSqrt.TabIndex = 3;
			btnSqrt.Text = "√x";
			btnSqrt.TextColor = Color.White;
			btnSqrt.UseVisualStyleBackColor = false;
			btnSqrt.Click += btnUnaryOperation_Click;
			// 
			// btnMultiply
			// 
			btnMultiply.BackColor = Color.FromArgb(60, 60, 60);
			btnMultiply.BackgroundColor = Color.FromArgb(60, 60, 60);
			btnMultiply.BorderColor = Color.FromArgb(32, 32, 32);
			btnMultiply.BorderRadius = 20;
			btnMultiply.BorderSize = 0;
			btnMultiply.FlatAppearance.BorderSize = 0;
			btnMultiply.FlatStyle = FlatStyle.Flat;
			btnMultiply.Font = new Font("Gadugi", 16F);
			btnMultiply.ForeColor = Color.White;
			btnMultiply.Location = new Point(245, 233);
			btnMultiply.Margin = new Padding(0);
			btnMultiply.Name = "btnMultiply";
			btnMultiply.Size = new Size(80, 55);
			btnMultiply.TabIndex = 2;
			btnMultiply.Text = "×";
			btnMultiply.TextColor = Color.White;
			btnMultiply.UseVisualStyleBackColor = false;
			btnMultiply.Click += btnBinaryOperation_Click;
			// 
			// btnNum7
			// 
			btnNum7.BackColor = Color.FromArgb(70, 70, 70);
			btnNum7.BackgroundColor = Color.FromArgb(70, 70, 70);
			btnNum7.BorderColor = Color.FromArgb(32, 32, 32);
			btnNum7.BorderRadius = 20;
			btnNum7.BorderSize = 0;
			btnNum7.FlatAppearance.BorderSize = 0;
			btnNum7.FlatStyle = FlatStyle.Flat;
			btnNum7.Font = new Font("Gadugi", 12F);
			btnNum7.ForeColor = Color.White;
			btnNum7.Location = new Point(5, 232);
			btnNum7.Margin = new Padding(0);
			btnNum7.Name = "btnNum7";
			btnNum7.Size = new Size(80, 55);
			btnNum7.TabIndex = 3;
			btnNum7.Text = "7";
			btnNum7.TextColor = Color.White;
			btnNum7.UseVisualStyleBackColor = false;
			btnNum7.Click += btnNum_Click;
			// 
			// btnNum8
			// 
			btnNum8.BackColor = Color.FromArgb(70, 70, 70);
			btnNum8.BackgroundColor = Color.FromArgb(70, 70, 70);
			btnNum8.BorderColor = Color.FromArgb(32, 32, 32);
			btnNum8.BorderRadius = 20;
			btnNum8.BorderSize = 0;
			btnNum8.FlatAppearance.BorderSize = 0;
			btnNum8.FlatStyle = FlatStyle.Flat;
			btnNum8.Font = new Font("Gadugi", 12F);
			btnNum8.ForeColor = Color.White;
			btnNum8.Location = new Point(85, 232);
			btnNum8.Margin = new Padding(0);
			btnNum8.Name = "btnNum8";
			btnNum8.Size = new Size(80, 55);
			btnNum8.TabIndex = 3;
			btnNum8.Text = "8";
			btnNum8.TextColor = Color.White;
			btnNum8.UseVisualStyleBackColor = false;
			btnNum8.Click += btnNum_Click;
			// 
			// btnNum9
			// 
			btnNum9.BackColor = Color.FromArgb(70, 70, 70);
			btnNum9.BackgroundColor = Color.FromArgb(70, 70, 70);
			btnNum9.BorderColor = Color.FromArgb(32, 32, 32);
			btnNum9.BorderRadius = 20;
			btnNum9.BorderSize = 0;
			btnNum9.FlatAppearance.BorderSize = 0;
			btnNum9.FlatStyle = FlatStyle.Flat;
			btnNum9.Font = new Font("Gadugi", 12F);
			btnNum9.ForeColor = Color.White;
			btnNum9.Location = new Point(165, 233);
			btnNum9.Margin = new Padding(0);
			btnNum9.Name = "btnNum9";
			btnNum9.Size = new Size(80, 55);
			btnNum9.TabIndex = 3;
			btnNum9.Text = "9";
			btnNum9.TextColor = Color.White;
			btnNum9.UseVisualStyleBackColor = false;
			btnNum9.Click += btnNum_Click;
			// 
			// btnSubstract
			// 
			btnSubstract.BackColor = Color.FromArgb(60, 60, 60);
			btnSubstract.BackgroundColor = Color.FromArgb(60, 60, 60);
			btnSubstract.BorderColor = Color.FromArgb(32, 32, 32);
			btnSubstract.BorderRadius = 20;
			btnSubstract.BorderSize = 0;
			btnSubstract.FlatAppearance.BorderSize = 0;
			btnSubstract.FlatStyle = FlatStyle.Flat;
			btnSubstract.Font = new Font("Gadugi", 18F);
			btnSubstract.ForeColor = Color.White;
			btnSubstract.Location = new Point(245, 288);
			btnSubstract.Margin = new Padding(0);
			btnSubstract.Name = "btnSubstract";
			btnSubstract.Size = new Size(80, 55);
			btnSubstract.TabIndex = 2;
			btnSubstract.Text = "-";
			btnSubstract.TextColor = Color.White;
			btnSubstract.UseVisualStyleBackColor = false;
			btnSubstract.Click += btnBinaryOperation_Click;
			// 
			// btnNum4
			// 
			btnNum4.BackColor = Color.FromArgb(70, 70, 70);
			btnNum4.BackgroundColor = Color.FromArgb(70, 70, 70);
			btnNum4.BorderColor = Color.FromArgb(32, 32, 32);
			btnNum4.BorderRadius = 20;
			btnNum4.BorderSize = 0;
			btnNum4.FlatAppearance.BorderSize = 0;
			btnNum4.FlatStyle = FlatStyle.Flat;
			btnNum4.Font = new Font("Gadugi", 12F);
			btnNum4.ForeColor = Color.White;
			btnNum4.Location = new Point(5, 287);
			btnNum4.Margin = new Padding(0);
			btnNum4.Name = "btnNum4";
			btnNum4.Size = new Size(80, 55);
			btnNum4.TabIndex = 3;
			btnNum4.Text = "4";
			btnNum4.TextColor = Color.White;
			btnNum4.UseVisualStyleBackColor = false;
			btnNum4.Click += btnNum_Click;
			// 
			// btnNum5
			// 
			btnNum5.BackColor = Color.FromArgb(70, 70, 70);
			btnNum5.BackgroundColor = Color.FromArgb(70, 70, 70);
			btnNum5.BorderColor = Color.FromArgb(32, 32, 32);
			btnNum5.BorderRadius = 20;
			btnNum5.BorderSize = 0;
			btnNum5.FlatAppearance.BorderSize = 0;
			btnNum5.FlatStyle = FlatStyle.Flat;
			btnNum5.Font = new Font("Gadugi", 12F);
			btnNum5.ForeColor = Color.White;
			btnNum5.Location = new Point(85, 287);
			btnNum5.Margin = new Padding(0);
			btnNum5.Name = "btnNum5";
			btnNum5.Size = new Size(80, 55);
			btnNum5.TabIndex = 3;
			btnNum5.Text = "5";
			btnNum5.TextColor = Color.White;
			btnNum5.UseVisualStyleBackColor = false;
			btnNum5.Click += btnNum_Click;
			// 
			// btnNum6
			// 
			btnNum6.BackColor = Color.FromArgb(70, 70, 70);
			btnNum6.BackgroundColor = Color.FromArgb(70, 70, 70);
			btnNum6.BorderColor = Color.FromArgb(32, 32, 32);
			btnNum6.BorderRadius = 20;
			btnNum6.BorderSize = 0;
			btnNum6.FlatAppearance.BorderSize = 0;
			btnNum6.FlatStyle = FlatStyle.Flat;
			btnNum6.Font = new Font("Gadugi", 12F);
			btnNum6.ForeColor = Color.White;
			btnNum6.Location = new Point(165, 288);
			btnNum6.Margin = new Padding(0);
			btnNum6.Name = "btnNum6";
			btnNum6.Size = new Size(80, 55);
			btnNum6.TabIndex = 3;
			btnNum6.Text = "6";
			btnNum6.TextColor = Color.White;
			btnNum6.UseVisualStyleBackColor = false;
			btnNum6.Click += btnNum_Click;
			// 
			// btnAdd
			// 
			btnAdd.BackColor = Color.FromArgb(60, 60, 60);
			btnAdd.BackgroundColor = Color.FromArgb(60, 60, 60);
			btnAdd.BorderColor = Color.FromArgb(32, 32, 32);
			btnAdd.BorderRadius = 20;
			btnAdd.BorderSize = 0;
			btnAdd.FlatAppearance.BorderSize = 0;
			btnAdd.FlatStyle = FlatStyle.Flat;
			btnAdd.Font = new Font("Gadugi", 16F);
			btnAdd.ForeColor = Color.White;
			btnAdd.Location = new Point(245, 343);
			btnAdd.Margin = new Padding(0);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(80, 55);
			btnAdd.TabIndex = 2;
			btnAdd.Text = "+";
			btnAdd.TextColor = Color.White;
			btnAdd.UseVisualStyleBackColor = false;
			btnAdd.Click += btnBinaryOperation_Click;
			// 
			// btnNum1
			// 
			btnNum1.BackColor = Color.FromArgb(70, 70, 70);
			btnNum1.BackgroundColor = Color.FromArgb(70, 70, 70);
			btnNum1.BorderColor = Color.FromArgb(32, 32, 32);
			btnNum1.BorderRadius = 20;
			btnNum1.BorderSize = 0;
			btnNum1.FlatAppearance.BorderSize = 0;
			btnNum1.FlatStyle = FlatStyle.Flat;
			btnNum1.Font = new Font("Gadugi", 12F);
			btnNum1.ForeColor = Color.White;
			btnNum1.Location = new Point(5, 342);
			btnNum1.Margin = new Padding(0);
			btnNum1.Name = "btnNum1";
			btnNum1.Size = new Size(80, 55);
			btnNum1.TabIndex = 3;
			btnNum1.Text = "1";
			btnNum1.TextColor = Color.White;
			btnNum1.UseVisualStyleBackColor = false;
			btnNum1.Click += btnNum_Click;
			// 
			// btnNum2
			// 
			btnNum2.BackColor = Color.FromArgb(70, 70, 70);
			btnNum2.BackgroundColor = Color.FromArgb(70, 70, 70);
			btnNum2.BorderColor = Color.FromArgb(32, 32, 32);
			btnNum2.BorderRadius = 20;
			btnNum2.BorderSize = 0;
			btnNum2.FlatAppearance.BorderSize = 0;
			btnNum2.FlatStyle = FlatStyle.Flat;
			btnNum2.Font = new Font("Gadugi", 12F);
			btnNum2.ForeColor = Color.White;
			btnNum2.Location = new Point(85, 342);
			btnNum2.Margin = new Padding(0);
			btnNum2.Name = "btnNum2";
			btnNum2.RightToLeft = RightToLeft.No;
			btnNum2.Size = new Size(80, 55);
			btnNum2.TabIndex = 3;
			btnNum2.Text = "2";
			btnNum2.TextColor = Color.White;
			btnNum2.UseVisualStyleBackColor = false;
			btnNum2.Click += btnNum_Click;
			// 
			// btnNum3
			// 
			btnNum3.BackColor = Color.FromArgb(70, 70, 70);
			btnNum3.BackgroundColor = Color.FromArgb(70, 70, 70);
			btnNum3.BorderColor = Color.FromArgb(32, 32, 32);
			btnNum3.BorderRadius = 20;
			btnNum3.BorderSize = 0;
			btnNum3.FlatAppearance.BorderSize = 0;
			btnNum3.FlatStyle = FlatStyle.Flat;
			btnNum3.Font = new Font("Gadugi", 12F);
			btnNum3.ForeColor = Color.White;
			btnNum3.Location = new Point(165, 343);
			btnNum3.Margin = new Padding(0);
			btnNum3.Name = "btnNum3";
			btnNum3.Size = new Size(80, 55);
			btnNum3.TabIndex = 3;
			btnNum3.Text = "3";
			btnNum3.TextColor = Color.White;
			btnNum3.UseVisualStyleBackColor = false;
			btnNum3.Click += btnNum_Click;
			// 
			// btnEqual
			// 
			btnEqual.BackColor = Color.DodgerBlue;
			btnEqual.BackgroundColor = Color.DodgerBlue;
			btnEqual.BorderColor = Color.FromArgb(32, 32, 32);
			btnEqual.BorderRadius = 20;
			btnEqual.BorderSize = 0;
			btnEqual.FlatAppearance.BorderSize = 0;
			btnEqual.FlatStyle = FlatStyle.Flat;
			btnEqual.Font = new Font("Gadugi", 16F);
			btnEqual.ForeColor = Color.White;
			btnEqual.Location = new Point(245, 398);
			btnEqual.Margin = new Padding(0);
			btnEqual.Name = "btnEqual";
			btnEqual.Size = new Size(80, 55);
			btnEqual.TabIndex = 2;
			btnEqual.Text = "=";
			btnEqual.TextColor = Color.White;
			btnEqual.UseVisualStyleBackColor = false;
			btnEqual.Click += btnEqual_Click;
			// 
			// btnSign
			// 
			btnSign.BackColor = Color.FromArgb(70, 70, 70);
			btnSign.BackgroundColor = Color.FromArgb(70, 70, 70);
			btnSign.BorderColor = Color.FromArgb(32, 32, 32);
			btnSign.BorderRadius = 20;
			btnSign.BorderSize = 0;
			btnSign.FlatAppearance.BorderSize = 0;
			btnSign.FlatStyle = FlatStyle.Flat;
			btnSign.Font = new Font("Gadugi", 15F);
			btnSign.ForeColor = Color.White;
			btnSign.Location = new Point(5, 397);
			btnSign.Margin = new Padding(0);
			btnSign.Name = "btnSign";
			btnSign.Size = new Size(80, 55);
			btnSign.TabIndex = 3;
			btnSign.Text = "±";
			btnSign.TextColor = Color.White;
			btnSign.UseVisualStyleBackColor = false;
			btnSign.Click += btnSign_Click;
			// 
			// btnNum0
			// 
			btnNum0.BackColor = Color.FromArgb(70, 70, 70);
			btnNum0.BackgroundColor = Color.FromArgb(70, 70, 70);
			btnNum0.BorderColor = Color.FromArgb(32, 32, 32);
			btnNum0.BorderRadius = 20;
			btnNum0.BorderSize = 0;
			btnNum0.FlatAppearance.BorderSize = 0;
			btnNum0.FlatStyle = FlatStyle.Flat;
			btnNum0.Font = new Font("Gadugi", 12F);
			btnNum0.ForeColor = Color.White;
			btnNum0.Location = new Point(85, 397);
			btnNum0.Margin = new Padding(0);
			btnNum0.Name = "btnNum0";
			btnNum0.RightToLeft = RightToLeft.No;
			btnNum0.Size = new Size(80, 55);
			btnNum0.TabIndex = 3;
			btnNum0.Text = "0";
			btnNum0.TextColor = Color.White;
			btnNum0.UseVisualStyleBackColor = false;
			btnNum0.Click += btnNum_Click;
			// 
			// btnPoint
			// 
			btnPoint.BackColor = Color.FromArgb(70, 70, 70);
			btnPoint.BackgroundColor = Color.FromArgb(70, 70, 70);
			btnPoint.BorderColor = Color.FromArgb(32, 32, 32);
			btnPoint.BorderRadius = 20;
			btnPoint.BorderSize = 0;
			btnPoint.FlatAppearance.BorderSize = 0;
			btnPoint.FlatStyle = FlatStyle.Flat;
			btnPoint.Font = new Font("Gadugi", 12F);
			btnPoint.ForeColor = Color.White;
			btnPoint.Location = new Point(165, 398);
			btnPoint.Margin = new Padding(0);
			btnPoint.Name = "btnPoint";
			btnPoint.Size = new Size(80, 55);
			btnPoint.TabIndex = 3;
			btnPoint.Text = ".";
			btnPoint.TextColor = Color.White;
			btnPoint.UseVisualStyleBackColor = false;
			btnPoint.Click += btnPoint_Click;
			// 
			// CalcForm
			// 
			AutoScaleMode = AutoScaleMode.None;
			BackColor = Color.FromArgb(32, 32, 32);
			ClientSize = new Size(334, 466);
			Controls.Add(btnPoint);
			Controls.Add(btnNum3);
			Controls.Add(btnNum6);
			Controls.Add(btnNum9);
			Controls.Add(btnNum0);
			Controls.Add(btnNum2);
			Controls.Add(btnNum5);
			Controls.Add(btnSqrt);
			Controls.Add(btnNum8);
			Controls.Add(btnPow2);
			Controls.Add(btnSign);
			Controls.Add(btnNum1);
			Controls.Add(btnNum4);
			Controls.Add(btnClear);
			Controls.Add(btnNum7);
			Controls.Add(btnReverse);
			Controls.Add(btnClearEntry);
			Controls.Add(btnPercent);
			Controls.Add(calcButton8);
			Controls.Add(calcButton7);
			Controls.Add(calcButton6);
			Controls.Add(calcButton5);
			Controls.Add(btnEqual);
			Controls.Add(btnAdd);
			Controls.Add(btnSubstract);
			Controls.Add(calcButton4);
			Controls.Add(btnMultiply);
			Controls.Add(btnDivide);
			Controls.Add(calcButton3);
			Controls.Add(btnBackspace);
			Controls.Add(textBoxEntry);
			Controls.Add(textBoxOutput);
			Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			ForeColor = Color.FromArgb(32, 32, 32);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Name = "CalcForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Калькулятор";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBoxOutput;
		private ContextMenuStrip contextMenuStrip1;
		private TextBox textBoxEntry;
		private CalcButton btnBackspace;
		private CalcButton btnPercent;
		private CalcButton calcButton3;
		private CalcButton calcButton4;
		private CalcButton calcButton5;
		private CalcButton calcButton6;
		private CalcButton calcButton7;
		private CalcButton calcButton8;
		private CalcButton btnClearEntry;
		private CalcButton btnClear;
		private CalcButton btnDivide;
		private CalcButton btnReverse;
		private CalcButton btnPow2;
		private CalcButton btnSqrt;
		private CalcButton btnMultiply;
		private CalcButton btnNum7;
		private CalcButton btnNum8;
		private CalcButton btnNum9;
		private CalcButton btnSubstract;
		private CalcButton btnNum4;
		private CalcButton btnNum5;
		private CalcButton btnNum6;
		private CalcButton btnAdd;
		private CalcButton btnNum1;
		private CalcButton btnNum2;
		private CalcButton btnNum3;
		private CalcButton btnEqual;
		private CalcButton btnSign;
		private CalcButton btnNum0;
		private CalcButton btnPoint;
	}
}
