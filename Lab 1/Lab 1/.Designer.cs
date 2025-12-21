namespace Lab_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWord = new System.Windows.Forms.Label();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.lstUsedLetters = new System.Windows.Forms.ListBox();
            this.picHangman = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHangman)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblWord.Location = new System.Drawing.Point(36, 313);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(300, 40);
            this.lblWord.TabIndex = 0;
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLetter
            // 
            this.txtLetter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLetter.Location = new System.Drawing.Point(159, 132);
            this.txtLetter.MaxLength = 1;
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(100, 20);
            this.txtLetter.TabIndex = 1;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(159, 186);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Ввод буквы";
            this.btnGuess.UseVisualStyleBackColor = true;
           
            // 
            // lblAttempts
            // 
            this.lblAttempts.AutoSize = true;
            this.lblAttempts.Location = new System.Drawing.Point(47, 135);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(0, 13);
            this.lblAttempts.TabIndex = 3;
            // 
            // lstUsedLetters
            // 
            this.lstUsedLetters.FormattingEnabled = true;
            this.lstUsedLetters.Location = new System.Drawing.Point(481, 279);
            this.lstUsedLetters.Name = "lstUsedLetters";
            this.lstUsedLetters.Size = new System.Drawing.Size(120, 95);
            this.lstUsedLetters.TabIndex = 4;
            // 
            // picHangman
            // 
            this.picHangman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHangman.Location = new System.Drawing.Point(467, 31);
            this.picHangman.Name = "picHangman";
            this.picHangman.Size = new System.Drawing.Size(150, 200);
            this.picHangman.TabIndex = 5;
            this.picHangman.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picHangman);
            this.Controls.Add(this.lstUsedLetters);
            this.Controls.Add(this.lblAttempts);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtLetter);
            this.Controls.Add(this.lblWord);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picHangman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            this.txtLetter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetter_KeyPress);
        }

        #endregion

        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox txtLetter;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.ListBox lstUsedLetters;
        private System.Windows.Forms.PictureBox picHangman;
    }
}

