namespace TestiriumWF
{
    partial class CustomQuestionTextBox
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
            this.questionTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // questionTxtBox
            // 
            this.questionTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.questionTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionTxtBox.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.questionTxtBox.Location = new System.Drawing.Point(0, 0);
            this.questionTxtBox.Multiline = true;
            this.questionTxtBox.Name = "questionTxtBox";
            this.questionTxtBox.Size = new System.Drawing.Size(736, 64);
            this.questionTxtBox.TabIndex = 3;
            this.questionTxtBox.Text = "Введите текст вопроса";
            this.questionTxtBox.Click += new System.EventHandler(this.questionTxtBox_Click);
            // 
            // CustomQuestionTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.questionTxtBox);
            this.Name = "CustomQuestionTextBox";
            this.Size = new System.Drawing.Size(736, 64);
            this.Load += new System.EventHandler(this.CustomQuestionTextBox_Load);
            this.Leave += new System.EventHandler(this.CustomQuestionTextBox_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox questionTxtBox;
    }
}
