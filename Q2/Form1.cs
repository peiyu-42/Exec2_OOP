using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.Text = "四顆骰子的遊戲";
			this.MaximizeBox = this.MinimizeBox = false;
			this.FormBorderStyle = FormBorderStyle.Fixed3D;

			resultLabel.Text = answerLabel.Text = String.Empty;
			resultLabel.Font = answerLabel.Font
				= new Font("標楷體", 12, FontStyle.Bold);
		}

		private void diceButton_Click(object sender, EventArgs e)
		{
			// 取得4個亂數
			resultLabel.Text = answerLabel.Text = string.Empty;
			int[] numbers = GetRandomNumbers();
			foreach (var i in numbers)
			{
				resultLabel.Text += Convert.ToString(i);
			}

			// 不符合標準的重新骰過
			Array.Sort(numbers);
			if (numbers[0] != numbers[1]
				&& numbers[1] != numbers[2]
				&& numbers[2] != numbers[3])
			{
				MessageBox.Show("請重新骰過，擲出來的數字至少要有兩個相同");
				resultLabel.Text = String.Empty;
				return;
			}

			// 計算數值
			int answer = 0;
			if (numbers[0] == numbers[1])
			{
				answer = numbers[2] + numbers[3];
			}
			else if (numbers[1] == numbers[2])
			{
				answer = numbers[0] + numbers[3];
			}
			else
			{
				answer = numbers[0] + numbers[1];
			}

			// 呈現結果
			answerLabel.Text = $"結果為 {answer}點 ";
		}

		private int[] GetRandomNumbers()
		{
			var random = new Random(Guid.NewGuid().GetHashCode());

			int[] numbers = new int[4];
			for (int i = 0; i < 4; i++)
			{
				numbers[i] = random.Next(1, 7);
			}

			return numbers;
		}
	}
}
