namespace TestiriumWF.CustomControls
{
    partial class CustomMinuteTextBox
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
            this.minuteTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // minuteTextBox
            // 
            this.minuteTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.minuteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minuteTextBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minuteTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.minuteTextBox.Location = new System.Drawing.Point(0, 0);
            this.minuteTextBox.Name = "minuteTextBox";
            this.minuteTextBox.Size = new System.Drawing.Size(56, 23);
            this.minuteTextBox.TabIndex = 7;
            this.minuteTextBox.Text = "10 мин";
            this.minuteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minuteTextBox.Click += new System.EventHandler(this.minuteTextBox_Click);
            this.minuteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minuteTextBox_KeyPress);
            this.minuteTextBox.Leave += new System.EventHandler(this.minuteTextBox_Leave);
            // 
            // CustomMinuteTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.minuteTextBox);
            this.Name = "CustomMinuteTextBox";
            this.Size = new System.Drawing.Size(56, 23);
            this.Load += new System.EventHandler(this.CustomMinuteTextBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox minuteTextBox;
    }
}
