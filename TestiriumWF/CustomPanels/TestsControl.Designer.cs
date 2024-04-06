namespace TestiriumWF.CustomPanels
{
    partial class TestsControl
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
            this.testsPanel = new System.Windows.Forms.Panel();
            this.availableTestsPanel = new System.Windows.Forms.Panel();
            this.btnCreateTest = new System.Windows.Forms.Button();
            this.lblCurrentCourse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.allCoursesPanel = new System.Windows.Forms.Panel();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.coursesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTests = new System.Windows.Forms.Label();
            this.testsDataGridView = new TestiriumWF.CustomControls.CustomDataGridView();
            this.testsPanel.SuspendLayout();
            this.availableTestsPanel.SuspendLayout();
            this.allCoursesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // testsPanel
            // 
            this.testsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.testsPanel.Controls.Add(this.allCoursesPanel);
            this.testsPanel.Controls.Add(this.availableTestsPanel);
            this.testsPanel.Location = new System.Drawing.Point(0, 0);
            this.testsPanel.Name = "testsPanel";
            this.testsPanel.Size = new System.Drawing.Size(1000, 528);
            this.testsPanel.TabIndex = 8;
            // 
            // availableTestsPanel
            // 
            this.availableTestsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.availableTestsPanel.Controls.Add(this.testsDataGridView);
            this.availableTestsPanel.Controls.Add(this.btnCreateTest);
            this.availableTestsPanel.Controls.Add(this.lblCurrentCourse);
            this.availableTestsPanel.Controls.Add(this.label2);
            this.availableTestsPanel.Controls.Add(this.label1);
            this.availableTestsPanel.Location = new System.Drawing.Point(216, 16);
            this.availableTestsPanel.Name = "availableTestsPanel";
            this.availableTestsPanel.Size = new System.Drawing.Size(768, 496);
            this.availableTestsPanel.TabIndex = 7;
            // 
            // btnCreateTest
            // 
            this.btnCreateTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(203)))), ((int)(((byte)(129)))));
            this.btnCreateTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCreateTest.FlatAppearance.BorderSize = 0;
            this.btnCreateTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTest.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateTest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateTest.Location = new System.Drawing.Point(536, 16);
            this.btnCreateTest.Name = "btnCreateTest";
            this.btnCreateTest.Size = new System.Drawing.Size(216, 56);
            this.btnCreateTest.TabIndex = 6;
            this.btnCreateTest.Text = "Создать тестирование";
            this.btnCreateTest.UseVisualStyleBackColor = false;
            this.btnCreateTest.Click += new System.EventHandler(this.btnCreateTest_Click);
            // 
            // lblCurrentCourse
            // 
            this.lblCurrentCourse.AutoSize = true;
            this.lblCurrentCourse.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentCourse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCurrentCourse.Location = new System.Drawing.Point(88, 48);
            this.lblCurrentCourse.Name = "lblCurrentCourse";
            this.lblCurrentCourse.Size = new System.Drawing.Size(90, 23);
            this.lblCurrentCourse.TabIndex = 8;
            this.lblCurrentCourse.Text = "Не выбран";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Предмет:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Доступные тестирования";
            // 
            // allCoursesPanel
            // 
            this.allCoursesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.allCoursesPanel.Controls.Add(this.btnAddCourse);
            this.allCoursesPanel.Controls.Add(this.coursesFlowLayoutPanel);
            this.allCoursesPanel.Controls.Add(this.lblTests);
            this.allCoursesPanel.Location = new System.Drawing.Point(0, 0);
            this.allCoursesPanel.Name = "allCoursesPanel";
            this.allCoursesPanel.Size = new System.Drawing.Size(200, 528);
            this.allCoursesPanel.TabIndex = 8;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnAddCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddCourse.FlatAppearance.BorderSize = 0;
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCourse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCourse.Location = new System.Drawing.Point(8, 472);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(184, 48);
            this.btnAddCourse.TabIndex = 5;
            this.btnAddCourse.Text = "Добавить предмет";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // coursesFlowLayoutPanel
            // 
            this.coursesFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.coursesFlowLayoutPanel.Location = new System.Drawing.Point(8, 40);
            this.coursesFlowLayoutPanel.Name = "coursesFlowLayoutPanel";
            this.coursesFlowLayoutPanel.Size = new System.Drawing.Size(184, 424);
            this.coursesFlowLayoutPanel.TabIndex = 1;
            // 
            // lblTests
            // 
            this.lblTests.AutoSize = true;
            this.lblTests.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTests.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTests.Location = new System.Drawing.Point(8, 8);
            this.lblTests.Name = "lblTests";
            this.lblTests.Size = new System.Drawing.Size(143, 25);
            this.lblTests.TabIndex = 0;
            this.lblTests.Text = "Ваши предметы";
            // 
            // testsDataGridView
            // 
            this.testsDataGridView.Location = new System.Drawing.Point(16, 88);
            this.testsDataGridView.Name = "testsDataGridView";
            this.testsDataGridView.Size = new System.Drawing.Size(736, 392);
            this.testsDataGridView.TabIndex = 9;
            // 
            // TestsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.testsPanel);
            this.Name = "TestsControl";
            this.Size = new System.Drawing.Size(1000, 528);
            this.Load += new System.EventHandler(this.TestsControl_Load);
            this.testsPanel.ResumeLayout(false);
            this.availableTestsPanel.ResumeLayout(false);
            this.availableTestsPanel.PerformLayout();
            this.allCoursesPanel.ResumeLayout(false);
            this.allCoursesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel testsPanel;
        private System.Windows.Forms.Panel availableTestsPanel;
        private CustomControls.CustomDataGridView testsDataGridView;
        private System.Windows.Forms.Button btnCreateTest;
        private System.Windows.Forms.Label lblCurrentCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel allCoursesPanel;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.FlowLayoutPanel coursesFlowLayoutPanel;
        private System.Windows.Forms.Label lblTests;
    }
}
