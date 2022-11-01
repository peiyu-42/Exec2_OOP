namespace Q1
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
			this.newGameButton = new System.Windows.Forms.Button();
			this.answerButton = new System.Windows.Forms.Button();
			this.answerLabel = new System.Windows.Forms.Label();
			this.guessButton = new System.Windows.Forms.Button();
			this.guessTextBox = new System.Windows.Forms.TextBox();
			this.displayTextBox = new System.Windows.Forms.TextBox();
			this.titleLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// newGameButton
			// 
			this.newGameButton.Location = new System.Drawing.Point(12, 17);
			this.newGameButton.Name = "newGameButton";
			this.newGameButton.Size = new System.Drawing.Size(75, 23);
			this.newGameButton.TabIndex = 0;
			this.newGameButton.Text = "新遊戲";
			this.newGameButton.UseVisualStyleBackColor = true;
			this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
			// 
			// answerButton
			// 
			this.answerButton.Location = new System.Drawing.Point(102, 17);
			this.answerButton.Name = "answerButton";
			this.answerButton.Size = new System.Drawing.Size(75, 23);
			this.answerButton.TabIndex = 1;
			this.answerButton.Text = "答案";
			this.answerButton.UseVisualStyleBackColor = true;
			this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
			// 
			// answerLabel
			// 
			this.answerLabel.AutoSize = true;
			this.answerLabel.Location = new System.Drawing.Point(183, 22);
			this.answerLabel.Name = "answerLabel";
			this.answerLabel.Size = new System.Drawing.Size(63, 12);
			this.answerLabel.TabIndex = 2;
			this.answerLabel.Text = "answerLabel";
			// 
			// guessButton
			// 
			this.guessButton.Location = new System.Drawing.Point(151, 66);
			this.guessButton.Name = "guessButton";
			this.guessButton.Size = new System.Drawing.Size(75, 23);
			this.guessButton.TabIndex = 3;
			this.guessButton.Text = "驗證";
			this.guessButton.UseVisualStyleBackColor = true;
			this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
			// 
			// guessTextBox
			// 
			this.guessTextBox.Location = new System.Drawing.Point(26, 67);
			this.guessTextBox.Name = "guessTextBox";
			this.guessTextBox.Size = new System.Drawing.Size(100, 22);
			this.guessTextBox.TabIndex = 4;
			// 
			// displayTextBox
			// 
			this.displayTextBox.Location = new System.Drawing.Point(26, 106);
			this.displayTextBox.Multiline = true;
			this.displayTextBox.Name = "displayTextBox";
			this.displayTextBox.ReadOnly = true;
			this.displayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.displayTextBox.Size = new System.Drawing.Size(200, 129);
			this.displayTextBox.TabIndex = 5;
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Location = new System.Drawing.Point(24, 43);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(48, 12);
			this.titleLabel.TabIndex = 6;
			this.titleLabel.Text = "titleLabel";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(277, 262);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.displayTextBox);
			this.Controls.Add(this.guessTextBox);
			this.Controls.Add(this.guessButton);
			this.Controls.Add(this.answerLabel);
			this.Controls.Add(this.answerButton);
			this.Controls.Add(this.newGameButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button newGameButton;
		private System.Windows.Forms.Button answerButton;
		private System.Windows.Forms.Label answerLabel;
		private System.Windows.Forms.Button guessButton;
		private System.Windows.Forms.TextBox guessTextBox;
		private System.Windows.Forms.TextBox displayTextBox;
		private System.Windows.Forms.Label titleLabel;
	}
}

