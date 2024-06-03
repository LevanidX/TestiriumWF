namespace TestiriumWF
{
    partial class CustomAnswerTextBox
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // answerTextBox
            // 
            this.answerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answerTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.answerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerTextBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.answerTextBox.Location = new System.Drawing.Point(0, 0);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(672, 23);
            this.answerTextBox.TabIndex = 5;
            this.answerTextBox.Text = "Введите вариант ответа";
            this.answerTextBox.Click += new System.EventHandler(this.answerTextBox_Click);
            this.answerTextBox.Leave += new System.EventHandler(this.answerTextBox_Leave);
            // 
            // CustomAnswerTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.answerTextBox);
            this.Name = "CustomAnswerTextBox";
            this.Size = new System.Drawing.Size(672, 23);
            this.Load += new System.EventHandler(this.CustomAnswerTextBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox answerTextBox;
    }
}
