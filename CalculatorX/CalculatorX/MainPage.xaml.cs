using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculatorX
{
	public partial class MainPage : ContentPage
	{
		enum Operator
		{
			None,
			Add,
			Subtract,
			Multiply,
			Divide
		}

		private Button[] buttons = new Button[16];
		private string firstValue, secondValue;
		Operator Operate = Operator.None;
		Arithmetic arithmetic;

		public MainPage()
		{
			InitializeComponent();
			
			buttons[0] = number0Button;
			buttons[1] = number1Button;
			buttons[2] = number2Button;
			buttons[3] = number3Button;
			buttons[4] = number4Button;
			buttons[5] = number5Button;
			buttons[6] = number6Button;
			buttons[7] = number7Button;
			buttons[8] = number8Button;
			buttons[9] = number9Button;
			buttons[10] = divideButton;
			buttons[11] = multiplicationButton;
			buttons[12] = subtractionButton;
			buttons[13] = additionButton;
			buttons[14] = resultButton;
			buttons[15] = dotButton;
			arithmetic = new Arithmetic();

			resultLabel.BackgroundColor = Color.DarkSeaGreen;
			resultLabel.TextColor = Color.White;
			resultLabel.GestureRecognizers.Add(new TapGestureRecognizer((view) => OnResultLabelClicked()));

			foreach (Button button in buttons)
			{
				button.TextColor = Color.White;
			}
		}

		private void OnResultLabelClicked()
		{
			resultLabel.Text = "";
			firstValue = null;
			secondValue = null;
			Operate = Operator.None;
		}

		private void number7Button_Clicked(object sender, EventArgs e)
		{
			resultLabel.Text += "7";
		}

		private void number4Button_Clicked(object sender, EventArgs e)
		{
			resultLabel.Text += "4";
		}

		private void number1Button_Clicked(object sender, EventArgs e)
		{
			resultLabel.Text += "1";
		}

		private void number8Button_Clicked(object sender, EventArgs e)
		{
			resultLabel.Text += "8";
		}

		private void number5Button_Clicked(object sender, EventArgs e)
		{
			resultLabel.Text += "5";
		}

		private void number2Button_Clicked(object sender, EventArgs e)
		{
			resultLabel.Text += "2";
		}

		private void number9Button_Clicked(object sender, EventArgs e)
		{
			resultLabel.Text += "9";
		}

		private void number6Button_Clicked(object sender, EventArgs e)
		{
			resultLabel.Text += "6";
		}

		private void number3Button_Clicked(object sender, EventArgs e)
		{
			resultLabel.Text += "3";
		}

		private void number0Button_Clicked(object sender, EventArgs e)
		{
			resultLabel.Text += "0";
		}

		private void dotButton_Clicked(object sender, EventArgs e)
		{
			if (!resultLabel.Text.Contains("."))
			{
				resultLabel.Text += ".";
			}
		}

		private void divideButton_Clicked(object sender, EventArgs e)
		{
			firstValue = resultLabel.Text;
			resultLabel.Text = "";
			Operate = Operator.Divide;
		}

		private void multiplicationButton_Clicked(object sender, EventArgs e)
		{
			firstValue = resultLabel.Text;
			resultLabel.Text = "";
			Operate = Operator.Multiply;
		}

		private void subtractionButton_Clicked(object sender, EventArgs e)
		{
			firstValue = resultLabel.Text;
			resultLabel.Text = "";
			Operate = Operator.Subtract;
		}

		private void additionButton_Clicked(object sender, EventArgs e)
		{
			firstValue = resultLabel.Text;
			resultLabel.Text = "";
			Operate = Operator.Add;
		}

		private void resultButton_Clicked(object sender, EventArgs e)
		{
			secondValue = resultLabel.Text;

			if(Operate == Operator.Multiply)
			{
				resultLabel.Text = "";
				resultLabel.Text = firstValue + " * " + secondValue + " = " + 
				arithmetic.MultiplyTowNumbers(firstValue, secondValue).ToString();
			}
			else if(Operate == Operator.Divide)
			{
				resultLabel.Text = "";
				resultLabel.Text = firstValue + " / " + secondValue + " = " + 
				arithmetic.DivideTowNumbers(firstValue, secondValue).ToString();
			}
			else if (Operate == Operator.Add)
			{
				resultLabel.Text = "";
				resultLabel.Text = firstValue + " + " + secondValue + " = " + 
				arithmetic.AddTowNumbers(firstValue, secondValue).ToString();
			}
			else if (Operate == Operator.Subtract)
			{
				resultLabel.Text = "";
				resultLabel.Text = firstValue + " - " + secondValue + " = " + 
				arithmetic.SubtractTowNumbers(firstValue, secondValue).ToString();
			}
		}
	}
}
