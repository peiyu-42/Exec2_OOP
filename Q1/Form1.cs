using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
	public partial class Form1 : Form
	{
		private int number = 4; // 要猜幾個數字
		public Form1()
		{
			InitializeComponent();
			this.Text = "1A2B 猜數字遊戲";
			this.MaximizeBox = this.MinimizeBox = false;
			this.FormBorderStyle = FormBorderStyle.Fixed3D;

			guessTextBox.MaxLength = number;
			titleLabel.Text = $"請輸入{number}個 0~9不重複的數字";

			answerLabel.Text = string.Empty;
			answerButton.Visible = guessButton.Visible = false;

			answerLabel.Font = displayTextBox.Font = titleLabel.Font
				= new Font("微軟正黑體", 12, FontStyle.Bold);
			newGameButton.Font = answerButton.Font = guessButton.Font
				= new Font("標楷體", 12, FontStyle.Regular);
		}
		private int[] answer;

		private void newGameButton_Click(object sender, EventArgs e)
		{
			// 取得亂數
			answer = new GuessNumber().GetRandomNumber(number);
			// 令答案和驗證按鈕，只能在有新的答案時顯示
			answerButton.Visible = guessButton.Visible = true;
			displayTextBox.Text = answerLabel.Text = string.Empty;
		}

		private void answerButton_Click(object sender, EventArgs e)
		{
			foreach (int item in answer)
			{
				answerLabel.Text += Convert.ToString(item);
			}
			answerButton.Visible = false;
		}

		private void guessButton_Click(object sender, EventArgs e)
		{
			// 取得輸入的值，並判斷是否為整數
			int[] guessInput = new int[number];
			try
			{
				guessInput = InputIsInt();
				IsRepeat(guessInput);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				guessTextBox.Text = string.Empty;
				return;
			}

			// 判斷數字和位置與答案是否一致
			guessInput = InputIsInt();
			string result = new GuessNumber().CompareNumbers(answer, guessInput);

			// 查看兩個陣列
			//foreach (int item in answer)
			//{
			//	displayTextBox.Text += Convert.ToString(item) + ",";
			//}
			//displayTextBox.Text += "\r\n";
			//foreach (int item in guessInput)
			//{
			//	displayTextBox.Text += Convert.ToString(item) + ",";
			//}

			// 呈現結果
			string guess = guessTextBox.Text;
			if (result == null)
			{
				MessageBox.Show($"恭喜，答對了");
			}
			else
			{
				displayTextBox.Text += $"{guess} => {result}\r\n";
				guessTextBox.Text = string.Empty;
			}
		}

		private void IsRepeat(int[] sortInput)
		{
			Array.Sort(sortInput); // 會讓輸入的陣列變為遞增排列
			for (int i = 0; i < sortInput.Length - 1; i++)
			{
				if (sortInput[i] == sortInput[i + 1])
				{
					throw new Exception("請輸入不重複的數字");
				}
			}
		}

		private int[] InputIsInt()
		{
			string input = guessTextBox.Text;

			bool isInt = int.TryParse(input, out int items);

			// 將字串轉換成數列
			int[] values = new int[input.Length];
			if (string.IsNullOrEmpty(input) == true ||
				isInt == false || items < 0 || input.Length != number)
			{
				throw new Exception($"請輸入0~9不重複的{number}個數字，再試一次");
			}
			else
			{
				for (int i = 0; i < input.Length; i++)
				{
					values[i] = Convert.ToInt32(input.Substring(i, 1));
				}
			}
			return values;
		}
	}

	internal class GuessNumber
	{
		/// <summary>
		/// 新遊戲，重新生出多(number)個亂數[0,9]
		/// </summary>
		/// <param name="number">產生多少個亂數</param>
		/// <returns></returns>
		public int[] GetRandomNumber(int number)
		{
			var random = new Random(Guid.NewGuid().GetHashCode());
			// 取0~9的數列
			int[] numbers = new int[10];
			for (int i = 0; i < numbers.Length; i++)
			{ numbers[i] = i; }
			// 將0~9的數列打亂
			int temp, indexRandom;
			for (int i = 0; i < numbers.Length; i++)
			{
				indexRandom = random.Next(0, 10);

				temp = numbers[i];
				numbers[i] = numbers[indexRandom];
				numbers[indexRandom] = temp;
			}
			// 從打亂後的數列，取得前4(number)個數值
			int[] values = new int[number];
			for (int i = 0; i < values.Length; i++)
			{
				values[i] = numbers[i];
			}
			return values;
		}
		/// <summary>
		/// 比對答案與猜測的數值是否相等
		/// </summary>
		/// <param name="answer">答案</param>
		/// <param name="guessInput">猜測的數值</param>
		/// <returns></returns>
		internal string CompareNumbers(int[] answer, int[] guessNumbers)
		{
			// a為數值正確，b為數值以及位置皆正確
			int a = 0, b = 0;
			// 比較兩個數字及位置是否相等
			for (int i = 0; i < answer.Length; i++) // answer的Index
			{
				for (int k = 0; k < guessNumbers.Length; k++) // guessNumbers的Index
				{
					if (guessNumbers[k] == answer[i] && k == i)
					{ b++; }
					else if (guessNumbers[k] == answer[i])
					{ a++; }
				}
			}
			string result = string.Empty;
			return (b == answer.Length) ? result = null
				: result = $"{a}A{b}B";
		}
	}
}
