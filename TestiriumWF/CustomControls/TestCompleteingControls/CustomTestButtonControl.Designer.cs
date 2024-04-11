namespace TestiriumWF.CustomControls
{
    partial class CustomTestButtonControl
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
            this.btnQuestionNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuestionNumber
            // 
            this.btnQuestionNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQuestionNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnQuestionNumber.FlatAppearance.BorderSize = 0;
            this.btnQuestionNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestionNumber.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQuestionNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuestionNumber.Location = new System.Drawing.Point(0, 0);
            this.btnQuestionNumber.Name = "btnQuestionNumber";
            this.btnQuestionNumber.Size = new System.Drawing.Size(36, 36);
            this.btnQuestionNumber.TabIndex = 6;
            this.btnQuestionNumber.Text = "99";
            this.btnQuestionNumber.UseVisualStyleBackColor = false;
            this.btnQuestionNumber.Click += new System.EventHandler(this.btnQuestionNumber_Click);
            // 
            // CustomTestButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnQuestionNumber);
            this.Name = "CustomTestButtonControl";
            this.Size = new System.Drawing.Size(36, 36);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuestionNumber;
    }
}
