namespace TestiriumWF.CustomPanels.DeserializedQuestionPanels
{
    partial class TestEndScreen
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
            this.endScreenPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMark = new System.Windows.Forms.Label();
            this.lblPercentageResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewResults = new System.Windows.Forms.Button();
            this.endScreenPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // endScreenPanel
            // 
            this.endScreenPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.endScreenPanel.Controls.Add(this.btnViewResults);
            this.endScreenPanel.Controls.Add(this.panel1);
            this.endScreenPanel.Location = new System.Drawing.Point(0, 0);
            this.endScreenPanel.Name = "endScreenPanel";
            this.endScreenPanel.Size = new System.Drawing.Size(784, 496);
            this.endScreenPanel.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblMark);
            this.panel1.Controls.Add(this.lblPercentageResult);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(160, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 312);
            this.panel1.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(72, 264);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(320, 32);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Времени затрачено - 00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMark
            // 
            this.lblMark.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMark.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMark.Location = new System.Drawing.Point(144, 192);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(184, 56);
            this.lblMark.TabIndex = 2;
            this.lblMark.Text = "Оценка - 0";
            this.lblMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPercentageResult
            // 
            this.lblPercentageResult.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPercentageResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPercentageResult.Location = new System.Drawing.Point(104, 128);
            this.lblPercentageResult.Name = "lblPercentageResult";
            this.lblPercentageResult.Size = new System.Drawing.Size(260, 48);
            this.lblPercentageResult.TabIndex = 1;
            this.lblPercentageResult.Text = "00 из 00 - 00,00%";
            this.lblPercentageResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ваш результат";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnViewResults
            // 
            this.btnViewResults.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnViewResults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViewResults.FlatAppearance.BorderSize = 0;
            this.btnViewResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewResults.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewResults.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewResults.Location = new System.Drawing.Point(160, 392);
            this.btnViewResults.Name = "btnViewResults";
            this.btnViewResults.Size = new System.Drawing.Size(472, 32);
            this.btnViewResults.TabIndex = 6;
            this.btnViewResults.Text = "Просмотреть результаты";
            this.btnViewResults.UseVisualStyleBackColor = false;
            this.btnViewResults.Click += new System.EventHandler(this.btnViewResults_Click);
            // 
            // TestEndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.endScreenPanel);
            this.Name = "TestEndScreen";
            this.Size = new System.Drawing.Size(784, 496);
            this.Load += new System.EventHandler(this.TestEndScreen_Load);
            this.endScreenPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel endScreenPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.Label lblPercentageResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnViewResults;
    }
}
