namespace TestiriumWF.CustomPanels
{
    partial class ReviewControl
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
            this.allCoursesPanel = new System.Windows.Forms.Panel();
            this.classesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTests = new System.Windows.Forms.Label();
            this.availableTestsPanel = new System.Windows.Forms.Panel();
            this.resultsDataGridView = new TestiriumWF.CustomControls.CustomDataGridView();
            this.btnCreateTest = new System.Windows.Forms.Button();
            this.lblCurrentClass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.allCoursesPanel.SuspendLayout();
            this.availableTestsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // allCoursesPanel
            // 
            this.allCoursesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.allCoursesPanel.Controls.Add(this.classesFlowLayoutPanel);
            this.allCoursesPanel.Controls.Add(this.lblTests);
            this.allCoursesPanel.Location = new System.Drawing.Point(0, 0);
            this.allCoursesPanel.Name = "allCoursesPanel";
            this.allCoursesPanel.Size = new System.Drawing.Size(200, 528);
            this.allCoursesPanel.TabIndex = 9;
            // 
            // classesFlowLayoutPanel
            // 
            this.classesFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.classesFlowLayoutPanel.Location = new System.Drawing.Point(8, 40);
            this.classesFlowLayoutPanel.Name = "classesFlowLayoutPanel";
            this.classesFlowLayoutPanel.Size = new System.Drawing.Size(184, 480);
            this.classesFlowLayoutPanel.TabIndex = 1;
            // 
            // lblTests
            // 
            this.lblTests.AutoSize = true;
            this.lblTests.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTests.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTests.Location = new System.Drawing.Point(8, 8);
            this.lblTests.Name = "lblTests";
            this.lblTests.Size = new System.Drawing.Size(74, 25);
            this.lblTests.TabIndex = 0;
            this.lblTests.Text = "Классы";
            // 
            // availableTestsPanel
            // 
            this.availableTestsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.availableTestsPanel.Controls.Add(this.resultsDataGridView);
            this.availableTestsPanel.Controls.Add(this.btnCreateTest);
            this.availableTestsPanel.Controls.Add(this.lblCurrentClass);
            this.availableTestsPanel.Controls.Add(this.label2);
            this.availableTestsPanel.Controls.Add(this.label1);
            this.availableTestsPanel.Location = new System.Drawing.Point(216, 16);
            this.availableTestsPanel.Name = "availableTestsPanel";
            this.availableTestsPanel.Size = new System.Drawing.Size(768, 496);
            this.availableTestsPanel.TabIndex = 10;
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.Location = new System.Drawing.Point(16, 88);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.Size = new System.Drawing.Size(736, 392);
            this.resultsDataGridView.TabIndex = 9;
            // 
            // btnCreateTest
            // 
            this.btnCreateTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(203)))), ((int)(((byte)(129)))));
            this.btnCreateTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCreateTest.Enabled = false;
            this.btnCreateTest.FlatAppearance.BorderSize = 0;
            this.btnCreateTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTest.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateTest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateTest.Location = new System.Drawing.Point(536, 16);
            this.btnCreateTest.Name = "btnCreateTest";
            this.btnCreateTest.Size = new System.Drawing.Size(216, 56);
            this.btnCreateTest.TabIndex = 6;
            this.btnCreateTest.Text = "Экспорт в Excel";
            this.btnCreateTest.UseVisualStyleBackColor = false;
            // 
            // lblCurrentClass
            // 
            this.lblCurrentClass.AutoSize = true;
            this.lblCurrentClass.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentClass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCurrentClass.Location = new System.Drawing.Point(72, 48);
            this.lblCurrentClass.Name = "lblCurrentClass";
            this.lblCurrentClass.Size = new System.Drawing.Size(90, 23);
            this.lblCurrentClass.TabIndex = 8;
            this.lblCurrentClass.Text = "Не выбран";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Класс:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Отчет по тестированию";
            // 
            // ReviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.availableTestsPanel);
            this.Controls.Add(this.allCoursesPanel);
            this.Name = "ReviewControl";
            this.Size = new System.Drawing.Size(1000, 528);
            this.Load += new System.EventHandler(this.ReviewControl_Load);
            this.allCoursesPanel.ResumeLayout(false);
            this.allCoursesPanel.PerformLayout();
            this.availableTestsPanel.ResumeLayout(false);
            this.availableTestsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel allCoursesPanel;
        private System.Windows.Forms.FlowLayoutPanel classesFlowLayoutPanel;
        private System.Windows.Forms.Label lblTests;
        private System.Windows.Forms.Panel availableTestsPanel;
        private CustomControls.CustomDataGridView resultsDataGridView;
        private System.Windows.Forms.Button btnCreateTest;
        private System.Windows.Forms.Label lblCurrentClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
