namespace TestiriumWF.CustomControls
{
    partial class CustomLabel
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
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.MaximumSize = new System.Drawing.Size(685, 40);
            this.label.MinimumSize = new System.Drawing.Size(342, 23);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(342, 23);
            this.label.TabIndex = 0;
            this.label.Text = "Какой-то текст";
            // 
            // CustomLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.label);
            this.MaximumSize = new System.Drawing.Size(685, 40);
            this.MinimumSize = new System.Drawing.Size(342, 23);
            this.Name = "CustomLabel";
            this.Size = new System.Drawing.Size(345, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
    }
}
