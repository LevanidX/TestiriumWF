namespace TestiriumWF
{
    partial class CustomClearRowButton
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
            this.btnClearRow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClearRow
            // 
            this.btnClearRow.BackColor = System.Drawing.Color.Transparent;
            this.btnClearRow.FlatAppearance.BorderSize = 0;
            this.btnClearRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearRow.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearRow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClearRow.Location = new System.Drawing.Point(0, 0);
            this.btnClearRow.Margin = new System.Windows.Forms.Padding(0);
            this.btnClearRow.Name = "btnClearRow";
            this.btnClearRow.Size = new System.Drawing.Size(23, 23);
            this.btnClearRow.TabIndex = 0;
            this.btnClearRow.Text = "Х";
            this.btnClearRow.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClearRow.UseVisualStyleBackColor = false;
            this.btnClearRow.Click += new System.EventHandler(this.btnClearRow_Click);
            // 
            // CustomClearRowButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClearRow);
            this.Name = "CustomClearRowButton";
            this.Size = new System.Drawing.Size(23, 23);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClearRow;
    }
}
