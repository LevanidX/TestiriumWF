namespace TestiriumWF.CustomControls.CustomOverrideControls
{
    partial class CustomNumericTextBox
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
            this.numericTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // numericTextBox
            // 
            this.numericTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.numericTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericTextBox.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericTextBox.ForeColor = System.Drawing.Color.White;
            this.numericTextBox.Location = new System.Drawing.Point(0, 0);
            this.numericTextBox.Multiline = true;
            this.numericTextBox.Name = "numericTextBox";
            this.numericTextBox.Size = new System.Drawing.Size(342, 24);
            this.numericTextBox.TabIndex = 7;
            this.numericTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBox_KeyPress);
            // 
            // CustomNumericTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericTextBox);
            this.Name = "CustomNumericTextBox";
            this.Size = new System.Drawing.Size(342, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numericTextBox;
    }
}
