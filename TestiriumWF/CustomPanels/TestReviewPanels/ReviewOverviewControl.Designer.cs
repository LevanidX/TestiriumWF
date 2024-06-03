namespace TestiriumWF.CustomPanels
{
    partial class ReviewOverviewControl
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
            this.lblStudentName = new System.Windows.Forms.Label();
            this.studentResultDataGridView = new TestiriumWF.CustomControls.CustomDataGridView();
            this.lblTestTitle = new System.Windows.Forms.Label();
            this.lblPercentageResult = new System.Windows.Forms.Label();
            this.lblMarkResult = new System.Windows.Forms.Label();
            this.availableTestsPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.availableTestsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStudentName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStudentName.Location = new System.Drawing.Point(16, 16);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(520, 24);
            this.lblStudentName.TabIndex = 15;
            this.lblStudentName.Text = "Обучающийся: Иванов Иван Иванович";
            this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // studentResultDataGridView
            // 
            this.studentResultDataGridView.Location = new System.Drawing.Point(16, 104);
            this.studentResultDataGridView.Name = "studentResultDataGridView";
            this.studentResultDataGridView.Size = new System.Drawing.Size(936, 376);
            this.studentResultDataGridView.TabIndex = 11;
            // 
            // lblTestTitle
            // 
            this.lblTestTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTestTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTestTitle.Location = new System.Drawing.Point(16, 48);
            this.lblTestTitle.Name = "lblTestTitle";
            this.lblTestTitle.Size = new System.Drawing.Size(520, 48);
            this.lblTestTitle.TabIndex = 7;
            this.lblTestTitle.Text = "Результат по тестированию:";
            this.lblTestTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPercentageResult
            // 
            this.lblPercentageResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPercentageResult.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPercentageResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPercentageResult.Location = new System.Drawing.Point(0, 0);
            this.lblPercentageResult.Name = "lblPercentageResult";
            this.lblPercentageResult.Size = new System.Drawing.Size(216, 19);
            this.lblPercentageResult.TabIndex = 12;
            this.lblPercentageResult.Text = "Процент - 00%";
            this.lblPercentageResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMarkResult
            // 
            this.lblMarkResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMarkResult.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMarkResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMarkResult.Location = new System.Drawing.Point(0, 24);
            this.lblMarkResult.Name = "lblMarkResult";
            this.lblMarkResult.Size = new System.Drawing.Size(216, 19);
            this.lblMarkResult.TabIndex = 10;
            this.lblMarkResult.Text = "Оценка - 0";
            this.lblMarkResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // availableTestsPanel
            // 
            this.availableTestsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.availableTestsPanel.Controls.Add(this.lblStudentName);
            this.availableTestsPanel.Controls.Add(this.panel1);
            this.availableTestsPanel.Controls.Add(this.studentResultDataGridView);
            this.availableTestsPanel.Controls.Add(this.lblTestTitle);
            this.availableTestsPanel.Location = new System.Drawing.Point(16, 16);
            this.availableTestsPanel.Name = "availableTestsPanel";
            this.availableTestsPanel.Size = new System.Drawing.Size(968, 496);
            this.availableTestsPanel.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.lblPercentageResult);
            this.panel1.Controls.Add(this.lblMarkResult);
            this.panel1.Location = new System.Drawing.Point(736, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 48);
            this.panel1.TabIndex = 14;
            // 
            // ReviewOverviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.availableTestsPanel);
            this.Name = "ReviewOverviewControl";
            this.Size = new System.Drawing.Size(1000, 528);
            this.Load += new System.EventHandler(this.ReviewOverviewControl_Load);
            this.availableTestsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStudentName;
        private CustomControls.CustomDataGridView studentResultDataGridView;
        private System.Windows.Forms.Label lblTestTitle;
        private System.Windows.Forms.Label lblPercentageResult;
        private System.Windows.Forms.Label lblMarkResult;
        private System.Windows.Forms.Panel availableTestsPanel;
        private System.Windows.Forms.Panel panel1;
    }
}
