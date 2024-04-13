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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCompletedQuestions = new System.Windows.Forms.Label();
            this.lblQuestionsCount = new System.Windows.Forms.Label();
            this.lblPercentageResult = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMark = new System.Windows.Forms.Label();
            this.lblTimeLeftForTest = new System.Windows.Forms.Label();
            this.endScreenPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // endScreenPanel
            // 
            this.endScreenPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.endScreenPanel.Controls.Add(this.panel1);
            this.endScreenPanel.Location = new System.Drawing.Point(0, 0);
            this.endScreenPanel.Name = "endScreenPanel";
            this.endScreenPanel.Size = new System.Drawing.Size(784, 496);
            this.endScreenPanel.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.lblTimeLeftForTest);
            this.panel1.Controls.Add(this.lblMark);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblPercentageResult);
            this.panel1.Controls.Add(this.lblQuestionsCount);
            this.panel1.Controls.Add(this.lblCompletedQuestions);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(160, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 304);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ваш результат";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(120, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "из";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(144, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 56);
            this.label3.TabIndex = 2;
            this.label3.Text = "Оценка - 3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(72, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Времени затрачено - 12:56";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCompletedQuestions
            // 
            this.lblCompletedQuestions.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompletedQuestions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCompletedQuestions.Location = new System.Drawing.Point(120, 120);
            this.lblCompletedQuestions.Name = "lblCompletedQuestions";
            this.lblCompletedQuestions.Size = new System.Drawing.Size(56, 48);
            this.lblCompletedQuestions.TabIndex = 4;
            this.lblCompletedQuestions.Text = "00";
            this.lblCompletedQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuestionsCount
            // 
            this.lblQuestionsCount.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestionsCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQuestionsCount.Location = new System.Drawing.Point(216, 120);
            this.lblQuestionsCount.Name = "lblQuestionsCount";
            this.lblQuestionsCount.Size = new System.Drawing.Size(56, 48);
            this.lblQuestionsCount.TabIndex = 5;
            this.lblQuestionsCount.Text = "00";
            this.lblQuestionsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPercentageResult
            // 
            this.lblPercentageResult.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPercentageResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPercentageResult.Location = new System.Drawing.Point(288, 120);
            this.lblPercentageResult.Name = "lblPercentageResult";
            this.lblPercentageResult.Size = new System.Drawing.Size(64, 48);
            this.lblPercentageResult.TabIndex = 6;
            this.lblPercentageResult.Text = "50";
            this.lblPercentageResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(232, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 48);
            this.label8.TabIndex = 7;
            this.label8.Text = "-";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(340, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 48);
            this.label9.TabIndex = 8;
            this.label9.Text = "%";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMark
            // 
            this.lblMark.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMark.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMark.Location = new System.Drawing.Point(288, 184);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(32, 56);
            this.lblMark.TabIndex = 9;
            this.lblMark.Text = "5";
            this.lblMark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimeLeftForTest
            // 
            this.lblTimeLeftForTest.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimeLeftForTest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTimeLeftForTest.Location = new System.Drawing.Point(304, 256);
            this.lblTimeLeftForTest.Name = "lblTimeLeftForTest";
            this.lblTimeLeftForTest.Size = new System.Drawing.Size(96, 32);
            this.lblTimeLeftForTest.TabIndex = 10;
            this.lblTimeLeftForTest.Text = "05:08:43";
            // 
            // TestEndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.endScreenPanel);
            this.Name = "TestEndScreen";
            this.Size = new System.Drawing.Size(784, 496);
            this.endScreenPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel endScreenPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblQuestionsCount;
        private System.Windows.Forms.Label lblCompletedQuestions;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPercentageResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTimeLeftForTest;
    }
}
