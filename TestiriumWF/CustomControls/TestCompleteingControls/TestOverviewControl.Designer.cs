namespace TestiriumWF.CustomControls.TestCompleteingControls
{
    partial class TestOverviewControl
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
            this.availableTestsPanel = new System.Windows.Forms.Panel();
            this.lblTestTitle = new System.Windows.Forms.Label();
            this.lblBestResult = new System.Windows.Forms.Label();
            this.lblAvailableTries = new System.Windows.Forms.Label();
            this.btnBeginTest = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customDataGridView = new TestiriumWF.CustomControls.CustomDataGridView();
            this.availableTestsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // availableTestsPanel
            // 
            this.availableTestsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.availableTestsPanel.Controls.Add(this.panel1);
            this.availableTestsPanel.Controls.Add(this.btnBeginTest);
            this.availableTestsPanel.Controls.Add(this.customDataGridView);
            this.availableTestsPanel.Controls.Add(this.lblTestTitle);
            this.availableTestsPanel.Location = new System.Drawing.Point(16, 16);
            this.availableTestsPanel.Name = "availableTestsPanel";
            this.availableTestsPanel.Size = new System.Drawing.Size(968, 496);
            this.availableTestsPanel.TabIndex = 8;
            // 
            // lblTestTitle
            // 
            this.lblTestTitle.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTestTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTestTitle.Location = new System.Drawing.Point(16, 16);
            this.lblTestTitle.Name = "lblTestTitle";
            this.lblTestTitle.Size = new System.Drawing.Size(520, 72);
            this.lblTestTitle.TabIndex = 7;
            this.lblTestTitle.Text = "Название тестирования";
            this.lblTestTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBestResult
            // 
            this.lblBestResult.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBestResult.AutoSize = true;
            this.lblBestResult.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBestResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBestResult.Location = new System.Drawing.Point(0, 24);
            this.lblBestResult.Name = "lblBestResult";
            this.lblBestResult.Size = new System.Drawing.Size(181, 19);
            this.lblBestResult.TabIndex = 10;
            this.lblBestResult.Text = "Лучший результат - 0%";
            this.lblBestResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvailableTries
            // 
            this.lblAvailableTries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvailableTries.AutoSize = true;
            this.lblAvailableTries.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAvailableTries.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAvailableTries.Location = new System.Drawing.Point(0, 0);
            this.lblAvailableTries.Name = "lblAvailableTries";
            this.lblAvailableTries.Size = new System.Drawing.Size(170, 19);
            this.lblAvailableTries.TabIndex = 12;
            this.lblAvailableTries.Text = "Доступно попыток - 0";
            // 
            // btnBeginTest
            // 
            this.btnBeginTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBeginTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(203)))), ((int)(((byte)(129)))));
            this.btnBeginTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBeginTest.FlatAppearance.BorderSize = 0;
            this.btnBeginTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeginTest.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBeginTest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBeginTest.Location = new System.Drawing.Point(16, 440);
            this.btnBeginTest.Name = "btnBeginTest";
            this.btnBeginTest.Size = new System.Drawing.Size(936, 40);
            this.btnBeginTest.TabIndex = 13;
            this.btnBeginTest.Text = "Пройти тестирование";
            this.btnBeginTest.UseVisualStyleBackColor = false;
            this.btnBeginTest.Click += new System.EventHandler(this.btnBeginTest_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.lblAvailableTries);
            this.panel1.Controls.Add(this.lblBestResult);
            this.panel1.Location = new System.Drawing.Point(752, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 48);
            this.panel1.TabIndex = 14;
            // 
            // customDataGridView
            // 
            this.customDataGridView.Location = new System.Drawing.Point(16, 104);
            this.customDataGridView.Name = "customDataGridView";
            this.customDataGridView.Size = new System.Drawing.Size(936, 328);
            this.customDataGridView.TabIndex = 11;
            // 
            // TestOverviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.availableTestsPanel);
            this.Name = "TestOverviewControl";
            this.Size = new System.Drawing.Size(1001, 529);
            this.Load += new System.EventHandler(this.TestOverviewControl_Load);
            this.availableTestsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel availableTestsPanel;
        private System.Windows.Forms.Label lblTestTitle;
        private System.Windows.Forms.Label lblBestResult;
        private System.Windows.Forms.Label lblAvailableTries;
        private CustomDataGridView customDataGridView;
        private System.Windows.Forms.Button btnBeginTest;
        private System.Windows.Forms.Panel panel1;
    }
}
