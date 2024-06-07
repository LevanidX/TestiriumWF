namespace TestiriumWF.CustomPanels.DeserializedQuestionPanels
{
    partial class TestWelcomeScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTestDescription = new System.Windows.Forms.Label();
            this.lblTestTitle = new System.Windows.Forms.Label();
            this.lblTestTimeLimit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTestDescription);
            this.panel1.Controls.Add(this.lblTestTitle);
            this.panel1.Controls.Add(this.lblTestTimeLimit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 496);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(656, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Время \r\nтестирования";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // lblTestDescription
            // 
            this.lblTestDescription.AutoSize = true;
            this.lblTestDescription.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTestDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTestDescription.Location = new System.Drawing.Point(32, 128);
            this.lblTestDescription.MaximumSize = new System.Drawing.Size(720, 300);
            this.lblTestDescription.MinimumSize = new System.Drawing.Size(720, 25);
            this.lblTestDescription.Name = "lblTestDescription";
            this.lblTestDescription.Size = new System.Drawing.Size(720, 25);
            this.lblTestDescription.TabIndex = 2;
            this.lblTestDescription.Text = "Описание тестирования";
            // 
            // lblTestTitle
            // 
            this.lblTestTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTestTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTestTitle.Location = new System.Drawing.Point(32, 32);
            this.lblTestTitle.MaximumSize = new System.Drawing.Size(450, 80);
            this.lblTestTitle.MinimumSize = new System.Drawing.Size(450, 25);
            this.lblTestTitle.Name = "lblTestTitle";
            this.lblTestTitle.Size = new System.Drawing.Size(450, 80);
            this.lblTestTitle.TabIndex = 1;
            this.lblTestTitle.Text = "Основы численных методов в математике";
            this.lblTestTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestTimeLimit
            // 
            this.lblTestTimeLimit.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTestTimeLimit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTestTimeLimit.Location = new System.Drawing.Point(656, 62);
            this.lblTestTimeLimit.Name = "lblTestTimeLimit";
            this.lblTestTimeLimit.Size = new System.Drawing.Size(96, 32);
            this.lblTestTimeLimit.TabIndex = 4;
            this.lblTestTimeLimit.Text = "∞";
            this.lblTestTimeLimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTestTimeLimit.Visible = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(655, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "минут";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // TestWelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "TestWelcomeScreen";
            this.Size = new System.Drawing.Size(784, 496);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTestTitle;
        private System.Windows.Forms.Label lblTestDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTestTimeLimit;
    }
}
