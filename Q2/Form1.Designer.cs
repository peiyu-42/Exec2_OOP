namespace Q2
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.diceButton = new System.Windows.Forms.Button();
			this.resultLabel = new System.Windows.Forms.Label();
			this.answerLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// diceButton
			// 
			this.diceButton.Location = new System.Drawing.Point(44, 30);
			this.diceButton.Name = "diceButton";
			this.diceButton.Size = new System.Drawing.Size(75, 23);
			this.diceButton.TabIndex = 0;
			this.diceButton.Text = "擲骰子";
			this.diceButton.UseVisualStyleBackColor = true;
			this.diceButton.Click += new System.EventHandler(this.diceButton_Click);
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Location = new System.Drawing.Point(53, 76);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(56, 12);
			this.resultLabel.TabIndex = 1;
			this.resultLabel.Text = "resultLabel";
			// 
			// answerLabel
			// 
			this.answerLabel.AutoSize = true;
			this.answerLabel.Location = new System.Drawing.Point(50, 111);
			this.answerLabel.Name = "answerLabel";
			this.answerLabel.Size = new System.Drawing.Size(63, 12);
			this.answerLabel.TabIndex = 2;
			this.answerLabel.Text = "answerLabel";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(164, 164);
			this.Controls.Add(this.answerLabel);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.diceButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button diceButton;
		private System.Windows.Forms.Label resultLabel;
		private System.Windows.Forms.Label answerLabel;
	}
}

