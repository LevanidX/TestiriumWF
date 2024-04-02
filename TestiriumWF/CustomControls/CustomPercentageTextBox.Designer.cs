namespace TestiriumWF.CustomControls
{
    partial class CustomPercentageTextBox
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
            this.percentageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // percentageTextBox
            // 
            this.percentageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.percentageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.percentageTextBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percentageTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.percentageTextBox.Location = new System.Drawing.Point(0, 0);
            this.percentageTextBox.Name = "percentageTextBox";
            this.percentageTextBox.Size = new System.Drawing.Size(40, 23);
            this.percentageTextBox.TabIndex = 6;
            this.percentageTextBox.Text = "0%";
            this.percentageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.percentageTextBox.Click += new System.EventHandler(this.percentageTextBox_Click);
            this.percentageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.percentageTextBox_KeyPress);
            this.percentageTextBox.Leave += new System.EventHandler(this.percentageTextBox_Leave);
            // 
            // CustomPercentageTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.percentageTextBox);
            this.Name = "CustomPercentageTextBox";
            this.Size = new System.Drawing.Size(40, 23);
            this.Load += new System.EventHandler(this.CustomPercentageTextBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox percentageTextBox;
    }
}
